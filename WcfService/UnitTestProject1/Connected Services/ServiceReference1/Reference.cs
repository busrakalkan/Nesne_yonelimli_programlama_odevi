﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/register", ReplyAction="http://tempuri.org/IService1/registerResponse")]
        int register(string username, string password, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/register", ReplyAction="http://tempuri.org/IService1/registerResponse")]
        System.Threading.Tasks.Task<int> registerAsync(string username, string password, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        int login(string username, string password, string adres, string sipariş);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        System.Threading.Tasks.Task<int> loginAsync(string username, string password, string adres, string sipariş);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : UnitTestProject1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<UnitTestProject1.ServiceReference1.IService1>, UnitTestProject1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int register(string username, string password, string email) {
            return base.Channel.register(username, password, email);
        }
        
        public System.Threading.Tasks.Task<int> registerAsync(string username, string password, string email) {
            return base.Channel.registerAsync(username, password, email);
        }
        
        public int login(string username, string password, string adres, string sipariş) {
            return base.Channel.login(username, password, adres, sipariş);
        }
        
        public System.Threading.Tasks.Task<int> loginAsync(string username, string password, string adres, string sipariş) {
            return base.Channel.loginAsync(username, password, adres, sipariş);
        }
    }
}
