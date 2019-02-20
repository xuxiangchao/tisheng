﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMST.Storage.Client.Proxy.LoginManageProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginManageProxy.ILoginManageProxy")]
    public interface ILoginManageProxy {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManage/Login", ReplyAction="http://tempuri.org/ILoginManage/LoginResponse")]
        string Login(string account, string password, string deviceType, string NICId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManage/Login", ReplyAction="http://tempuri.org/ILoginManage/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string account, string password, string deviceType, string NICId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManage/Logout", ReplyAction="http://tempuri.org/ILoginManage/LogoutResponse")]
        string Logout(string tokenID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManage/Logout", ReplyAction="http://tempuri.org/ILoginManage/LogoutResponse")]
        System.Threading.Tasks.Task<string> LogoutAsync(string tokenID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManage/SaveUserPasswordEdit", ReplyAction="http://tempuri.org/ILoginManage/SaveUserPasswordEditResponse")]
        string SaveUserPasswordEdit(string account, string oldpassword, string newpassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManage/SaveUserPasswordEdit", ReplyAction="http://tempuri.org/ILoginManage/SaveUserPasswordEditResponse")]
        System.Threading.Tasks.Task<string> SaveUserPasswordEditAsync(string account, string oldpassword, string newpassword);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginManageProxyChannel : CMST.Storage.Client.Proxy.LoginManageProxy.ILoginManageProxy, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginManageProxyClient : System.ServiceModel.ClientBase<CMST.Storage.Client.Proxy.LoginManageProxy.ILoginManageProxy>, CMST.Storage.Client.Proxy.LoginManageProxy.ILoginManageProxy {
        
        public LoginManageProxyClient() {
        }
        
        public LoginManageProxyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginManageProxyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginManageProxyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginManageProxyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Login(string account, string password, string deviceType, string NICId) {
            return base.Channel.Login(account, password, deviceType, NICId);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string account, string password, string deviceType, string NICId) {
            return base.Channel.LoginAsync(account, password, deviceType, NICId);
        }
        
        public string Logout(string tokenID) {
            return base.Channel.Logout(tokenID);
        }
        
        public System.Threading.Tasks.Task<string> LogoutAsync(string tokenID) {
            return base.Channel.LogoutAsync(tokenID);
        }
        
        public string SaveUserPasswordEdit(string account, string oldpassword, string newpassword) {
            return base.Channel.SaveUserPasswordEdit(account, oldpassword, newpassword);
        }
        
        public System.Threading.Tasks.Task<string> SaveUserPasswordEditAsync(string account, string oldpassword, string newpassword) {
            return base.Channel.SaveUserPasswordEditAsync(account, oldpassword, newpassword);
        }
    }
}
