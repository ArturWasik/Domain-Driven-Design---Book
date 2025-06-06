﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Discovery.AccountManagement {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Follower", Namespace="http://schemas.datacontract.org/2004/07/AccountManagement")]
    [System.SerializableAttribute()]
    public partial class Follower : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FollowerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FollowerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] SocialTagsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FollowerId {
            get {
                return this.FollowerIdField;
            }
            set {
                if ((object.ReferenceEquals(this.FollowerIdField, value) != true)) {
                    this.FollowerIdField = value;
                    this.RaisePropertyChanged("FollowerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FollowerName {
            get {
                return this.FollowerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FollowerNameField, value) != true)) {
                    this.FollowerNameField = value;
                    this.RaisePropertyChanged("FollowerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] SocialTags {
            get {
                return this.SocialTagsField;
            }
            set {
                if ((object.ReferenceEquals(this.SocialTagsField, value) != true)) {
                    this.SocialTagsField = value;
                    this.RaisePropertyChanged("SocialTags");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountManagement.IFollowerDirectory")]
    public interface IFollowerDirectory {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFollowerDirectory/FindUsersFollowers", ReplyAction="http://tempuri.org/IFollowerDirectory/FindUsersFollowersResponse")]
        Discovery.AccountManagement.Follower[] FindUsersFollowers(string accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFollowerDirectory/FindUsersFollowers", ReplyAction="http://tempuri.org/IFollowerDirectory/FindUsersFollowersResponse")]
        System.Threading.Tasks.Task<Discovery.AccountManagement.Follower[]> FindUsersFollowersAsync(string accountId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFollowerDirectoryChannel : Discovery.AccountManagement.IFollowerDirectory, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FollowerDirectoryClient : System.ServiceModel.ClientBase<Discovery.AccountManagement.IFollowerDirectory>, Discovery.AccountManagement.IFollowerDirectory {
        
        public FollowerDirectoryClient() {
        }
        
        public FollowerDirectoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FollowerDirectoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FollowerDirectoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FollowerDirectoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Discovery.AccountManagement.Follower[] FindUsersFollowers(string accountId) {
            return base.Channel.FindUsersFollowers(accountId);
        }
        
        public System.Threading.Tasks.Task<Discovery.AccountManagement.Follower[]> FindUsersFollowersAsync(string accountId) {
            return base.Channel.FindUsersFollowersAsync(accountId);
        }
    }
}
