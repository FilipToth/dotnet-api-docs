﻿module TestLambdaExpression

// <Snippet2>
open System
open System.IO

let message1 = "The first line of a message"
let message2 = "The second line of a message"

let writeToConsole string1 string2 = 
    printfn $"{string1}\n{string2}"

let writeToFile string1 string2 =
    use writer = new StreamWriter(Environment.GetCommandLineArgs().[1], false)
    writer.WriteLine $"{string1}\n{string2}"

let concat =
    Action<string, string>(fun string1 string2 ->
        if Environment.GetCommandLineArgs().Length > 1 then
            writeToFile string1 string2
        else
            writeToConsole string1 string2
    )

concat.Invoke(message1, message2)

// </Snippet2>
