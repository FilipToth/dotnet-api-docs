﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


// <snippet2>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://microsoft.wcf.documentation", ConfigurationName="ISampleService")]
public interface ISampleService
{

    [System.ServiceModel.OperationContractAttribute(
      Action="http://microsoft.wcf.documentation/ISampleService/SampleMethod",
      ReplyAction="http://microsoft.wcf.documentation/ISampleService/SampleMethodResponse"
    )]
    [return: System.ServiceModel.MessageParameterAttribute(Name="Output")]
    string SampleMethod(string Input);
}
// </snippet2>

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface ISampleServiceChannel : ISampleService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class SampleServiceClient : System.ServiceModel.ClientBase<ISampleService>, ISampleService
{

    public SampleServiceClient()
    {
    }

    public SampleServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public SampleServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public SampleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public SampleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public string SampleMethod(string Input)
    {
        return base.Channel.SampleMethod(Input);
    }
}
