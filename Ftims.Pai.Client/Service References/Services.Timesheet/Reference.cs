﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ftims.Pai.Client.Services.Timesheet {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Timesheet", Namespace="http://schemas.datacontract.org/2004/07/Ftims.Pai.Service.TimesheetService.DTO")]
    [System.SerializableAttribute()]
    public partial class Timesheet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateTimesheet", Namespace="http://schemas.datacontract.org/2004/07/Ftims.Pai.Service.TimesheetService.DTO")]
    [System.SerializableAttribute()]
    public partial class CreateTimesheet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Services.Timesheet.ITimesheetService")]
    public interface ITimesheetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimesheetService/Get", ReplyAction="http://tempuri.org/ITimesheetService/GetResponse")]
        Ftims.Pai.Client.Services.Timesheet.Timesheet Get(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimesheetService/Get", ReplyAction="http://tempuri.org/ITimesheetService/GetResponse")]
        System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Timesheet.Timesheet> GetAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimesheetService/GetAll", ReplyAction="http://tempuri.org/ITimesheetService/GetAllResponse")]
        Ftims.Pai.Client.Services.Timesheet.Timesheet[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimesheetService/GetAll", ReplyAction="http://tempuri.org/ITimesheetService/GetAllResponse")]
        System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Timesheet.Timesheet[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimesheetService/Create", ReplyAction="http://tempuri.org/ITimesheetService/CreateResponse")]
        Ftims.Pai.Client.Services.Timesheet.Timesheet Create(Ftims.Pai.Client.Services.Timesheet.CreateTimesheet task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimesheetService/Create", ReplyAction="http://tempuri.org/ITimesheetService/CreateResponse")]
        System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Timesheet.Timesheet> CreateAsync(Ftims.Pai.Client.Services.Timesheet.CreateTimesheet task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimesheetService/Update", ReplyAction="http://tempuri.org/ITimesheetService/UpdateResponse")]
        void Update(string id, Ftims.Pai.Client.Services.Timesheet.Timesheet task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimesheetService/Update", ReplyAction="http://tempuri.org/ITimesheetService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string id, Ftims.Pai.Client.Services.Timesheet.Timesheet task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimesheetService/Delete", ReplyAction="http://tempuri.org/ITimesheetService/DeleteResponse")]
        void Delete(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimesheetService/Delete", ReplyAction="http://tempuri.org/ITimesheetService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITimesheetServiceChannel : Ftims.Pai.Client.Services.Timesheet.ITimesheetService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TimesheetServiceClient : System.ServiceModel.ClientBase<Ftims.Pai.Client.Services.Timesheet.ITimesheetService>, Ftims.Pai.Client.Services.Timesheet.ITimesheetService {
        
        public TimesheetServiceClient() {
        }
        
        public TimesheetServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TimesheetServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimesheetServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimesheetServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Ftims.Pai.Client.Services.Timesheet.Timesheet Get(string id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Timesheet.Timesheet> GetAsync(string id) {
            return base.Channel.GetAsync(id);
        }
        
        public Ftims.Pai.Client.Services.Timesheet.Timesheet[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Timesheet.Timesheet[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public Ftims.Pai.Client.Services.Timesheet.Timesheet Create(Ftims.Pai.Client.Services.Timesheet.CreateTimesheet task) {
            return base.Channel.Create(task);
        }
        
        public System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Timesheet.Timesheet> CreateAsync(Ftims.Pai.Client.Services.Timesheet.CreateTimesheet task) {
            return base.Channel.CreateAsync(task);
        }
        
        public void Update(string id, Ftims.Pai.Client.Services.Timesheet.Timesheet task) {
            base.Channel.Update(id, task);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string id, Ftims.Pai.Client.Services.Timesheet.Timesheet task) {
            return base.Channel.UpdateAsync(id, task);
        }
        
        public void Delete(string id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(string id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
