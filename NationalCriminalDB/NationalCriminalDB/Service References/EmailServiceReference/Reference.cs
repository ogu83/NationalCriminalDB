﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NationalCriminalDB.EmailServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmailSendRequest", Namespace="http://schemas.datacontract.org/2004/07/NationalCriminalDB.EmailService")]
    [System.SerializableAttribute()]
    public partial class EmailSendRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NationalCriminalDB.EmailServiceReference.DataRangeOfint AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NationalCriminalDB.EmailServiceReference.DataRangeOfdecimal HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationalityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NationalCriminalDB.EmailServiceReference.EmailSendRequest.SexType SexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NationalCriminalDB.EmailServiceReference.DataRangeOfdecimal WeightField;
        
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
        public NationalCriminalDB.EmailServiceReference.DataRangeOfint Age {
            get {
                return this.AgeField;
            }
            set {
                if ((object.ReferenceEquals(this.AgeField, value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
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
        public NationalCriminalDB.EmailServiceReference.DataRangeOfdecimal Height {
            get {
                return this.HeightField;
            }
            set {
                if ((object.ReferenceEquals(this.HeightField, value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nationality {
            get {
                return this.NationalityField;
            }
            set {
                if ((object.ReferenceEquals(this.NationalityField, value) != true)) {
                    this.NationalityField = value;
                    this.RaisePropertyChanged("Nationality");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NationalCriminalDB.EmailServiceReference.EmailSendRequest.SexType Sex {
            get {
                return this.SexField;
            }
            set {
                if ((this.SexField.Equals(value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NationalCriminalDB.EmailServiceReference.DataRangeOfdecimal Weight {
            get {
                return this.WeightField;
            }
            set {
                if ((object.ReferenceEquals(this.WeightField, value) != true)) {
                    this.WeightField = value;
                    this.RaisePropertyChanged("Weight");
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
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="EmailSendRequest.SexType", Namespace="http://schemas.datacontract.org/2004/07/NationalCriminalDB.EmailService")]
        public enum SexType : int {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Indetermined = 0,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Male = 1,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Female = 2,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            All = 3,
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataRangeOfint", Namespace="http://schemas.datacontract.org/2004/07/NationalCriminalDB.EmailService")]
    [System.SerializableAttribute()]
    public partial class DataRangeOfint : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaximumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MinimumField;
        
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
        public int Maximum {
            get {
                return this.MaximumField;
            }
            set {
                if ((this.MaximumField.Equals(value) != true)) {
                    this.MaximumField = value;
                    this.RaisePropertyChanged("Maximum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Minimum {
            get {
                return this.MinimumField;
            }
            set {
                if ((this.MinimumField.Equals(value) != true)) {
                    this.MinimumField = value;
                    this.RaisePropertyChanged("Minimum");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataRangeOfdecimal", Namespace="http://schemas.datacontract.org/2004/07/NationalCriminalDB.EmailService")]
    [System.SerializableAttribute()]
    public partial class DataRangeOfdecimal : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MaximumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MinimumField;
        
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
        public decimal Maximum {
            get {
                return this.MaximumField;
            }
            set {
                if ((this.MaximumField.Equals(value) != true)) {
                    this.MaximumField = value;
                    this.RaisePropertyChanged("Maximum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Minimum {
            get {
                return this.MinimumField;
            }
            set {
                if ((this.MinimumField.Equals(value) != true)) {
                    this.MinimumField = value;
                    this.RaisePropertyChanged("Minimum");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EmailSendResponse", Namespace="http://schemas.datacontract.org/2004/07/NationalCriminalDB.EmailService")]
    [System.SerializableAttribute()]
    public partial class EmailSendResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ResultField;
        
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
        public bool Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmailServiceReference.IEmailService")]
    public interface IEmailService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendCriminalRecords", ReplyAction="http://tempuri.org/IEmailService/SendCriminalRecordsResponse")]
        NationalCriminalDB.EmailServiceReference.EmailSendResponse SendCriminalRecords(NationalCriminalDB.EmailServiceReference.EmailSendRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendCriminalRecords", ReplyAction="http://tempuri.org/IEmailService/SendCriminalRecordsResponse")]
        System.Threading.Tasks.Task<NationalCriminalDB.EmailServiceReference.EmailSendResponse> SendCriminalRecordsAsync(NationalCriminalDB.EmailServiceReference.EmailSendRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmailServiceChannel : NationalCriminalDB.EmailServiceReference.IEmailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmailServiceClient : System.ServiceModel.ClientBase<NationalCriminalDB.EmailServiceReference.IEmailService>, NationalCriminalDB.EmailServiceReference.IEmailService {
        
        public EmailServiceClient() {
        }
        
        public EmailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NationalCriminalDB.EmailServiceReference.EmailSendResponse SendCriminalRecords(NationalCriminalDB.EmailServiceReference.EmailSendRequest request) {
            return base.Channel.SendCriminalRecords(request);
        }
        
        public System.Threading.Tasks.Task<NationalCriminalDB.EmailServiceReference.EmailSendResponse> SendCriminalRecordsAsync(NationalCriminalDB.EmailServiceReference.EmailSendRequest request) {
            return base.Channel.SendCriminalRecordsAsync(request);
        }
    }
}
