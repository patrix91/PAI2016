﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ftims.Pai.Client.Services.Employee {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Ftims.Pai.Service.TimesheetService.DTO")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateEmployee", Namespace="http://schemas.datacontract.org/2004/07/Ftims.Pai.Service.TimesheetService.DTO")]
    [System.SerializableAttribute()]
    public partial class CreateEmployee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ManagerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ManagerId {
            get {
                return this.ManagerIdField;
            }
            set {
                if ((this.ManagerIdField.Equals(value) != true)) {
                    this.ManagerIdField = value;
                    this.RaisePropertyChanged("ManagerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Project", Namespace="http://schemas.datacontract.org/2004/07/Ftims.Pai.Service.TimesheetService.DTO")]
    [System.SerializableAttribute()]
    public partial class Project : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Services.Employee.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/Get", ReplyAction="http://tempuri.org/IEmployeeService/GetResponse")]
        Ftims.Pai.Client.Services.Employee.Employee Get(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/Get", ReplyAction="http://tempuri.org/IEmployeeService/GetResponse")]
        System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Employee> GetAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetSubordinates", ReplyAction="http://tempuri.org/IEmployeeService/GetSubordinatesResponse")]
        Ftims.Pai.Client.Services.Employee.Employee[] GetSubordinates(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetSubordinates", ReplyAction="http://tempuri.org/IEmployeeService/GetSubordinatesResponse")]
        System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Employee[]> GetSubordinatesAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetDetails", ReplyAction="http://tempuri.org/IEmployeeService/GetDetailsResponse")]
        Ftims.Pai.Client.Services.Employee.Employee GetDetails(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetDetails", ReplyAction="http://tempuri.org/IEmployeeService/GetDetailsResponse")]
        System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Employee> GetDetailsAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetAll", ReplyAction="http://tempuri.org/IEmployeeService/GetAllResponse")]
        Ftims.Pai.Client.Services.Employee.Employee[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetAll", ReplyAction="http://tempuri.org/IEmployeeService/GetAllResponse")]
        System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Employee[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/Create", ReplyAction="http://tempuri.org/IEmployeeService/CreateResponse")]
        Ftims.Pai.Client.Services.Employee.Employee Create(Ftims.Pai.Client.Services.Employee.CreateEmployee task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/Create", ReplyAction="http://tempuri.org/IEmployeeService/CreateResponse")]
        System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Employee> CreateAsync(Ftims.Pai.Client.Services.Employee.CreateEmployee task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/Update", ReplyAction="http://tempuri.org/IEmployeeService/UpdateResponse")]
        void Update(string id, Ftims.Pai.Client.Services.Employee.Employee task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/Update", ReplyAction="http://tempuri.org/IEmployeeService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string id, Ftims.Pai.Client.Services.Employee.Employee task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/Delete", ReplyAction="http://tempuri.org/IEmployeeService/DeleteResponse")]
        void Delete(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/Delete", ReplyAction="http://tempuri.org/IEmployeeService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetTimesheets", ReplyAction="http://tempuri.org/IEmployeeService/GetTimesheetsResponse")]
        Ftims.Pai.Client.Services.Employee.Timesheet[] GetTimesheets(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetTimesheets", ReplyAction="http://tempuri.org/IEmployeeService/GetTimesheetsResponse")]
        System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Timesheet[]> GetTimesheetsAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetProjects", ReplyAction="http://tempuri.org/IEmployeeService/GetProjectsResponse")]
        Ftims.Pai.Client.Services.Employee.Project[] GetProjects(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetProjects", ReplyAction="http://tempuri.org/IEmployeeService/GetProjectsResponse")]
        System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Project[]> GetProjectsAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : Ftims.Pai.Client.Services.Employee.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<Ftims.Pai.Client.Services.Employee.IEmployeeService>, Ftims.Pai.Client.Services.Employee.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Ftims.Pai.Client.Services.Employee.Employee Get(string id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Employee> GetAsync(string id) {
            return base.Channel.GetAsync(id);
        }
        
        public Ftims.Pai.Client.Services.Employee.Employee[] GetSubordinates(string id) {
            return base.Channel.GetSubordinates(id);
        }
        
        public System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Employee[]> GetSubordinatesAsync(string id) {
            return base.Channel.GetSubordinatesAsync(id);
        }
        
        public Ftims.Pai.Client.Services.Employee.Employee GetDetails(string id) {
            return base.Channel.GetDetails(id);
        }
        
        public System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Employee> GetDetailsAsync(string id) {
            return base.Channel.GetDetailsAsync(id);
        }
        
        public Ftims.Pai.Client.Services.Employee.Employee[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Employee[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public Ftims.Pai.Client.Services.Employee.Employee Create(Ftims.Pai.Client.Services.Employee.CreateEmployee task) {
            return base.Channel.Create(task);
        }
        
        public System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Employee> CreateAsync(Ftims.Pai.Client.Services.Employee.CreateEmployee task) {
            return base.Channel.CreateAsync(task);
        }
        
        public void Update(string id, Ftims.Pai.Client.Services.Employee.Employee task) {
            base.Channel.Update(id, task);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string id, Ftims.Pai.Client.Services.Employee.Employee task) {
            return base.Channel.UpdateAsync(id, task);
        }
        
        public void Delete(string id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(string id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public Ftims.Pai.Client.Services.Employee.Timesheet[] GetTimesheets(string id) {
            return base.Channel.GetTimesheets(id);
        }
        
        public System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Timesheet[]> GetTimesheetsAsync(string id) {
            return base.Channel.GetTimesheetsAsync(id);
        }
        
        public Ftims.Pai.Client.Services.Employee.Project[] GetProjects(string id) {
            return base.Channel.GetProjects(id);
        }
        
        public System.Threading.Tasks.Task<Ftims.Pai.Client.Services.Employee.Project[]> GetProjectsAsync(string id) {
            return base.Channel.GetProjectsAsync(id);
        }
    }
}