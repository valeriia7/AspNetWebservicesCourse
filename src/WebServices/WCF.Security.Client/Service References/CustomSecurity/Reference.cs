﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF.Security.Client.CustomSecurity {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomSecurity.ICustomSecurityService")]
    public interface ICustomSecurityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomSecurityService/DoWork", ReplyAction="http://tempuri.org/ICustomSecurityService/DoWorkResponse")]
        string DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomSecurityService/DoWork", ReplyAction="http://tempuri.org/ICustomSecurityService/DoWorkResponse")]
        System.Threading.Tasks.Task<string> DoWorkAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomSecurityServiceChannel : WCF.Security.Client.CustomSecurity.ICustomSecurityService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomSecurityServiceClient : System.ServiceModel.ClientBase<WCF.Security.Client.CustomSecurity.ICustomSecurityService>, WCF.Security.Client.CustomSecurity.ICustomSecurityService {
        
        public CustomSecurityServiceClient() {
        }
        
        public CustomSecurityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomSecurityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomSecurityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomSecurityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DoWork() {
            return base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task<string> DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
    }
}