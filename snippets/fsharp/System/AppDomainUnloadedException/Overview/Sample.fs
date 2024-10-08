﻿//<Snippet1>
open System
open System.Threading

// TestClass derives from MarshalByRefObject, so it can be marshaled
// across application domain boundaries.
type TestClass() =
    inherit MarshalByRefObject()
    member _.UnloadCurrentDomain (state: obj) =
        printfn $"\nUnloading the current AppDomain{state}."

        // Unload the current application domain. This causes
        // an AppDomainUnloadedException to be thrown.
        //
        AppDomain.Unload AppDomain.CurrentDomain

let threadProc (state: obj) =
    // Create an application domain, and create an instance
    // of TestClass in the application domain. The first
    // parameter of CreateInstanceAndUnwrap is the name of
    // this executable. If you compile the example code using
    // any name other than "Sample.exe", you must change the
    // parameter appropriately.
    let ad = AppDomain.CreateDomain "TestDomain"
    let tc = ad.CreateInstanceAndUnwrap("Sample", "TestClass") :?> TestClass

    // In the new application domain, execute a method that
    // unloads the AppDomain. The unhandled exception this
    // causes ends the current thread.
    tc.UnloadCurrentDomain state

    printfn "ThreadProc: This message is never displayed."

// 1. Queue ThreadProc as a task for a ThreadPool thread.
ThreadPool.QueueUserWorkItem(threadProc, " from a ThreadPool thread") |> ignore
Thread.Sleep 1000

// 2. Execute ThreadProc on an ordinary thread.
let t = Thread(ParameterizedThreadStart threadProc) 
t.Start " from an ordinary thread"
t.Join()

// 3. Execute ThreadProc on the main thread, with
//    exception handling.
try
    threadProc " from the main application thread (handled)"
with :? AppDomainUnloadedException as adue ->
    printfn $"Main thread caught AppDomainUnloadedException: {adue.Message}"

// 4. Execute ThreadProc on the main thread without
//    exception handling.
threadProc " from the main application thread (unhandled)"

printfn "Main: This message is never displayed."

(* This code example produces output similar to the following:
Unloading the current AppDomain from a ThreadPool thread.

Unloading the current AppDomain from an ordinary thread.

Unloading the current AppDomain from the main application thread (handled).
Main thread caught AppDomainUnloadedException: The application domain in which the thread was running has been unloaded.

Unloading the current AppDomain from the main application thread (unhandled).

Unhandled Exception: System.AppDomainUnloadedException: The application domain in which the thread was running has been unloaded.
   at TestClass.UnloadCurrentDomain(Object state)
   at Example.ThreadProc(Object state)
   at Example.main()
 *)
//</Snippet1>