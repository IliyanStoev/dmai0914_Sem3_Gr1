﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormClient.WinformReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListForObjects", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinFormClient.WinformReference.Homework[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinFormClient.WinformReference.Homework))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinFormClient.WinformReference.Assignment))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinFormClient.WinformReference.Teacher))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinFormClient.WinformReference.Person))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinFormClient.WinformReference.Child))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinFormClient.WinformReference.Assignment[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinFormClient.WinformReference.TutoringTime))]
    public partial class ListForObjects : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[] AslField;
        
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
        public object[] Asl {
            get {
                return this.AslField;
            }
            set {
                if ((object.ReferenceEquals(this.AslField, value) != true)) {
                    this.AslField = value;
                    this.RaisePropertyChanged("Asl");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Homework", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Model")]
    [System.SerializableAttribute()]
    public partial class Homework : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WinFormClient.WinformReference.Assignment AssignmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WinFormClient.WinformReference.Person ChildField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiskNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public WinFormClient.WinformReference.Assignment Assignment {
            get {
                return this.AssignmentField;
            }
            set {
                if ((object.ReferenceEquals(this.AssignmentField, value) != true)) {
                    this.AssignmentField = value;
                    this.RaisePropertyChanged("Assignment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WinFormClient.WinformReference.Person Child {
            get {
                return this.ChildField;
            }
            set {
                if ((object.ReferenceEquals(this.ChildField, value) != true)) {
                    this.ChildField = value;
                    this.RaisePropertyChanged("Child");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DiskName {
            get {
                return this.DiskNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DiskNameField, value) != true)) {
                    this.DiskNameField = value;
                    this.RaisePropertyChanged("DiskName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Assignment", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Model")]
    [System.SerializableAttribute()]
    public partial class Assignment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime deadlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string exerciseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string subjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WinFormClient.WinformReference.Teacher teacherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
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
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime deadline {
            get {
                return this.deadlineField;
            }
            set {
                if ((this.deadlineField.Equals(value) != true)) {
                    this.deadlineField = value;
                    this.RaisePropertyChanged("deadline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string exercise {
            get {
                return this.exerciseField;
            }
            set {
                if ((object.ReferenceEquals(this.exerciseField, value) != true)) {
                    this.exerciseField = value;
                    this.RaisePropertyChanged("exercise");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string subject {
            get {
                return this.subjectField;
            }
            set {
                if ((object.ReferenceEquals(this.subjectField, value) != true)) {
                    this.subjectField = value;
                    this.RaisePropertyChanged("subject");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WinFormClient.WinformReference.Teacher teacher {
            get {
                return this.teacherField;
            }
            set {
                if ((object.ReferenceEquals(this.teacherField, value) != true)) {
                    this.teacherField = value;
                    this.RaisePropertyChanged("teacher");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Teacher", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Model")]
    [System.SerializableAttribute()]
    public partial class Teacher : WinFormClient.WinformReference.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinFormClient.WinformReference.Child))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinFormClient.WinformReference.Teacher))]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserTypeField;
        
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserType {
            get {
                return this.UserTypeField;
            }
            set {
                if ((this.UserTypeField.Equals(value) != true)) {
                    this.UserTypeField = value;
                    this.RaisePropertyChanged("UserType");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Child", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Model")]
    [System.SerializableAttribute()]
    public partial class Child : WinFormClient.WinformReference.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GradeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Grade {
            get {
                return this.GradeField;
            }
            set {
                if ((object.ReferenceEquals(this.GradeField, value) != true)) {
                    this.GradeField = value;
                    this.RaisePropertyChanged("Grade");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TutoringTime", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Model")]
    [System.SerializableAttribute()]
    public partial class TutoringTime : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AvailableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WinFormClient.WinformReference.Teacher TeacherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimeField;
        
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
        public bool Available {
            get {
                return this.AvailableField;
            }
            set {
                if ((this.AvailableField.Equals(value) != true)) {
                    this.AvailableField = value;
                    this.RaisePropertyChanged("Available");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WinFormClient.WinformReference.Teacher Teacher {
            get {
                return this.TeacherField;
            }
            set {
                if ((object.ReferenceEquals(this.TeacherField, value) != true)) {
                    this.TeacherField = value;
                    this.RaisePropertyChanged("Teacher");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Time {
            get {
                return this.TimeField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeField, value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WinformReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WinFormClient.WinformReference.ListForObjects))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WinFormClient.WinformReference.Homework[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WinFormClient.WinformReference.Homework))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WinFormClient.WinformReference.Assignment))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WinFormClient.WinformReference.Teacher))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WinFormClient.WinformReference.Person))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WinFormClient.WinformReference.Child))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WinFormClient.WinformReference.Assignment[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WinFormClient.WinformReference.TutoringTime))]
        object Login(string User, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<object> LoginAsync(string User, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SubmitHomework", ReplyAction="http://tempuri.org/IService1/SubmitHomeworkResponse")]
        int SubmitHomework(int childId, int assignmentId, System.DateTime date, string diskName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SubmitHomework", ReplyAction="http://tempuri.org/IService1/SubmitHomeworkResponse")]
        System.Threading.Tasks.Task<int> SubmitHomeworkAsync(int childId, int assignmentId, System.DateTime date, string diskName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateAssignment", ReplyAction="http://tempuri.org/IService1/CreateAssignmentResponse")]
        int CreateAssignment(int teacherId, string subject, string title, string exercise, System.DateTime date, System.DateTime deadline);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateAssignment", ReplyAction="http://tempuri.org/IService1/CreateAssignmentResponse")]
        System.Threading.Tasks.Task<int> CreateAssignmentAsync(int teacherId, string subject, string title, string exercise, System.DateTime date, System.DateTime deadline);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllHomeworksById", ReplyAction="http://tempuri.org/IService1/GetAllHomeworksByIdResponse")]
        WinFormClient.WinformReference.ListForObjects GetAllHomeworksById(int assignmentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllHomeworksById", ReplyAction="http://tempuri.org/IService1/GetAllHomeworksByIdResponse")]
        System.Threading.Tasks.Task<WinFormClient.WinformReference.ListForObjects> GetAllHomeworksByIdAsync(int assignmentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllHomeworksByChildId", ReplyAction="http://tempuri.org/IService1/GetAllHomeworksByChildIdResponse")]
        WinFormClient.WinformReference.Homework[] GetAllHomeworksByChildId(int childId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllHomeworksByChildId", ReplyAction="http://tempuri.org/IService1/GetAllHomeworksByChildIdResponse")]
        System.Threading.Tasks.Task<WinFormClient.WinformReference.Homework[]> GetAllHomeworksByChildIdAsync(int childId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAssignmentsForTeacherById", ReplyAction="http://tempuri.org/IService1/GetAllAssignmentsForTeacherByIdResponse")]
        WinFormClient.WinformReference.ListForObjects GetAllAssignmentsForTeacherById(int teacherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAssignmentsForTeacherById", ReplyAction="http://tempuri.org/IService1/GetAllAssignmentsForTeacherByIdResponse")]
        System.Threading.Tasks.Task<WinFormClient.WinformReference.ListForObjects> GetAllAssignmentsForTeacherByIdAsync(int teacherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAssignments", ReplyAction="http://tempuri.org/IService1/GetAllAssignmentsResponse")]
        WinFormClient.WinformReference.Assignment[] GetAllAssignments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAssignments", ReplyAction="http://tempuri.org/IService1/GetAllAssignmentsResponse")]
        System.Threading.Tasks.Task<WinFormClient.WinformReference.Assignment[]> GetAllAssignmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetHomeworkById", ReplyAction="http://tempuri.org/IService1/GetHomeworkByIdResponse")]
        WinFormClient.WinformReference.Homework GetHomeworkById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetHomeworkById", ReplyAction="http://tempuri.org/IService1/GetHomeworkByIdResponse")]
        System.Threading.Tasks.Task<WinFormClient.WinformReference.Homework> GetHomeworkByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateTutoringTime", ReplyAction="http://tempuri.org/IService1/CreateTutoringTimeResponse")]
        int CreateTutoringTime(System.DateTime date, bool availability, int teacherId, string time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateTutoringTime", ReplyAction="http://tempuri.org/IService1/CreateTutoringTimeResponse")]
        System.Threading.Tasks.Task<int> CreateTutoringTimeAsync(System.DateTime date, bool availability, int teacherId, string time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTtTimesByTime", ReplyAction="http://tempuri.org/IService1/GetTtTimesByTimeResponse")]
        WinFormClient.WinformReference.TutoringTime GetTtTimesByTime(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTtTimesByTime", ReplyAction="http://tempuri.org/IService1/GetTtTimesByTimeResponse")]
        System.Threading.Tasks.Task<WinFormClient.WinformReference.TutoringTime> GetTtTimesByTimeAsync(System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WinFormClient.WinformReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WinFormClient.WinformReference.IService1>, WinFormClient.WinformReference.IService1 {
        
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
        
        public object Login(string User, string Password) {
            return base.Channel.Login(User, Password);
        }
        
        public System.Threading.Tasks.Task<object> LoginAsync(string User, string Password) {
            return base.Channel.LoginAsync(User, Password);
        }
        
        public int SubmitHomework(int childId, int assignmentId, System.DateTime date, string diskName) {
            return base.Channel.SubmitHomework(childId, assignmentId, date, diskName);
        }
        
        public System.Threading.Tasks.Task<int> SubmitHomeworkAsync(int childId, int assignmentId, System.DateTime date, string diskName) {
            return base.Channel.SubmitHomeworkAsync(childId, assignmentId, date, diskName);
        }
        
        public int CreateAssignment(int teacherId, string subject, string title, string exercise, System.DateTime date, System.DateTime deadline) {
            return base.Channel.CreateAssignment(teacherId, subject, title, exercise, date, deadline);
        }
        
        public System.Threading.Tasks.Task<int> CreateAssignmentAsync(int teacherId, string subject, string title, string exercise, System.DateTime date, System.DateTime deadline) {
            return base.Channel.CreateAssignmentAsync(teacherId, subject, title, exercise, date, deadline);
        }
        
        public WinFormClient.WinformReference.ListForObjects GetAllHomeworksById(int assignmentId) {
            return base.Channel.GetAllHomeworksById(assignmentId);
        }
        
        public System.Threading.Tasks.Task<WinFormClient.WinformReference.ListForObjects> GetAllHomeworksByIdAsync(int assignmentId) {
            return base.Channel.GetAllHomeworksByIdAsync(assignmentId);
        }
        
        public WinFormClient.WinformReference.Homework[] GetAllHomeworksByChildId(int childId) {
            return base.Channel.GetAllHomeworksByChildId(childId);
        }
        
        public System.Threading.Tasks.Task<WinFormClient.WinformReference.Homework[]> GetAllHomeworksByChildIdAsync(int childId) {
            return base.Channel.GetAllHomeworksByChildIdAsync(childId);
        }
        
        public WinFormClient.WinformReference.ListForObjects GetAllAssignmentsForTeacherById(int teacherId) {
            return base.Channel.GetAllAssignmentsForTeacherById(teacherId);
        }
        
        public System.Threading.Tasks.Task<WinFormClient.WinformReference.ListForObjects> GetAllAssignmentsForTeacherByIdAsync(int teacherId) {
            return base.Channel.GetAllAssignmentsForTeacherByIdAsync(teacherId);
        }
        
        public WinFormClient.WinformReference.Assignment[] GetAllAssignments() {
            return base.Channel.GetAllAssignments();
        }
        
        public System.Threading.Tasks.Task<WinFormClient.WinformReference.Assignment[]> GetAllAssignmentsAsync() {
            return base.Channel.GetAllAssignmentsAsync();
        }
        
        public WinFormClient.WinformReference.Homework GetHomeworkById(int id) {
            return base.Channel.GetHomeworkById(id);
        }
        
        public System.Threading.Tasks.Task<WinFormClient.WinformReference.Homework> GetHomeworkByIdAsync(int id) {
            return base.Channel.GetHomeworkByIdAsync(id);
        }
        
        public int CreateTutoringTime(System.DateTime date, bool availability, int teacherId, string time) {
            return base.Channel.CreateTutoringTime(date, availability, teacherId, time);
        }
        
        public System.Threading.Tasks.Task<int> CreateTutoringTimeAsync(System.DateTime date, bool availability, int teacherId, string time) {
            return base.Channel.CreateTutoringTimeAsync(date, availability, teacherId, time);
        }
        
        public WinFormClient.WinformReference.TutoringTime GetTtTimesByTime(System.DateTime date) {
            return base.Channel.GetTtTimesByTime(date);
        }
        
        public System.Threading.Tasks.Task<WinFormClient.WinformReference.TutoringTime> GetTtTimesByTimeAsync(System.DateTime date) {
            return base.Channel.GetTtTimesByTimeAsync(date);
        }
    }
}
