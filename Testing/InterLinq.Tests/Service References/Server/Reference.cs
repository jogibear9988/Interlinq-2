﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterLinq.Tests.Server {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InterLinqQueryBase", Namespace="http://schemas.interlinq.com/2011/03/")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryOfstring))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryOfCustomer))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryOfOrder))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryOfProduct))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryOfSupplier))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(InterLinq.Types.Anonymous.AnonymousMetaType))]
    public partial class InterLinqQueryBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InterLinq.Types.InterLinqType ElementInterLinqTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QueryNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<InterLinq.Expressions.SerializableExpression> QueryParametersField;
        
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
        public InterLinq.Types.InterLinqType ElementInterLinqType {
            get {
                return this.ElementInterLinqTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ElementInterLinqTypeField, value) != true)) {
                    this.ElementInterLinqTypeField = value;
                    this.RaisePropertyChanged("ElementInterLinqType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QueryName {
            get {
                return this.QueryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.QueryNameField, value) != true)) {
                    this.QueryNameField = value;
                    this.RaisePropertyChanged("QueryName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<InterLinq.Expressions.SerializableExpression> QueryParameters {
            get {
                return this.QueryParametersField;
            }
            set {
                if ((object.ReferenceEquals(this.QueryParametersField, value) != true)) {
                    this.QueryParametersField = value;
                    this.RaisePropertyChanged("QueryParameters");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InterLinqQueryOfstring", Namespace="http://schemas.interlinq.com/2011/03/")]
    [System.SerializableAttribute()]
    public partial class InterLinqQueryOfstring : InterLinq.Tests.Server.InterLinqQueryBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InterLinqQueryOfCustomer", Namespace="http://schemas.interlinq.com/2011/03/")]
    [System.SerializableAttribute()]
    public partial class InterLinqQueryOfCustomer : InterLinq.Tests.Server.InterLinqQueryBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InterLinqQueryOfOrder", Namespace="http://schemas.interlinq.com/2011/03/")]
    [System.SerializableAttribute()]
    public partial class InterLinqQueryOfOrder : InterLinq.Tests.Server.InterLinqQueryBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InterLinqQueryOfProduct", Namespace="http://schemas.interlinq.com/2011/03/")]
    [System.SerializableAttribute()]
    public partial class InterLinqQueryOfProduct : InterLinq.Tests.Server.InterLinqQueryBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InterLinqQueryOfSupplier", Namespace="http://schemas.interlinq.com/2011/03/")]
    [System.SerializableAttribute()]
    public partial class InterLinqQueryOfSupplier : InterLinq.Tests.Server.InterLinqQueryBase {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Server.IMockQueryService")]
    public interface IMockQueryService {
        
        // CODEGEN: Der Nachrichtenvertrag wird generiert, da der Wrappernamespace (http://schemas.interlinq.com/2011/03/server) von Nachricht "RetrieveRequest" nicht mit dem Standardwert (http://tempuri.org/) übereinstimmt.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.interlinq.com/2011/03/server/IQueryRemoteHandler/Retrieve", ReplyAction="http://schemas.interlinq.com/2011/03/server/IQueryRemoteHandler/RetrieveResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://schemas.interlinq.com/2011/03/server/IQueryRemoteHandler/RetrieveException" +
            "Fault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableInvocationExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableBinaryExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableLambdaExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableParameterExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableExpressionTyped))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableConditionalExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableConstantExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableListInitExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableNewExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableMemberExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableMemberInitExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableMethodCallExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableNewArrayExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableTypeBinaryExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableUnaryExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.Anonymous.AnonymousMetaType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.InterLinqType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.InterLinqMemberInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Types.Anonymous.AnonymousMetaProperty>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.Anonymous.AnonymousMetaProperty))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.InterLinqPropertyInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.InterLinqFieldInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.InterLinqMethodBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Types.InterLinqType>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.InterLinqConstructorInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.InterLinqMethodInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableTypes.SerializableMemberMemberBinding))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableTypes.SerializableMemberBinding))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableTypes.SerializableMemberListBinding))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Expressions.SerializableTypes.SerializableElementInit>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableTypes.SerializableElementInit))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Expressions.SerializableExpression>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Expressions.SerializableTypes.SerializableMemberAssignment))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Expressions.SerializableTypes.SerializableMemberBinding>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.Anonymous.AnonymousObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Types.Anonymous.AnonymousProperty>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.Anonymous.AnonymousProperty))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Expressions.SerializableParameterExpression>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Types.InterLinqMemberInfo>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Types.Anonymous.InterLinqGroupingBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Types.Anonymous.AnonymousObject>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryOfstring))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryOfCustomer))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryOfOrder))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryOfProduct))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Tests.Server.InterLinqQueryOfSupplier))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Linq.Expressions.ExpressionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Linq.Expressions.MemberBindingType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Reflection.MemberInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Reflection.MethodInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Reflection.MethodBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<object>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Tests.Entities.Customer))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Tests.Entities.Order>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Tests.Entities.Order))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Tests.Entities.Customer>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Tests.Entities.Product))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Tests.Entities.Product>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(InterLinq.Tests.Entities.Supplier))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<InterLinq.Tests.Entities.Supplier>))]
        InterLinq.Tests.Server.RetrieveResponse Retrieve(InterLinq.Tests.Server.RetrieveRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Retrieve", WrapperNamespace="http://schemas.interlinq.com/2011/03/server", IsWrapped=true)]
    public partial class RetrieveRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.interlinq.com/2011/03/server", Order=0)]
        public InterLinq.Expressions.SerializableExpression expression;
        
        public RetrieveRequest() {
        }
        
        public RetrieveRequest(InterLinq.Expressions.SerializableExpression expression) {
            this.expression = expression;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RetrieveResponse", WrapperNamespace="http://schemas.interlinq.com/2011/03/server", IsWrapped=true)]
    public partial class RetrieveResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.interlinq.com/2011/03/server", Order=0)]
        public object RetrieveResult;
        
        public RetrieveResponse() {
        }
        
        public RetrieveResponse(object RetrieveResult) {
            this.RetrieveResult = RetrieveResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMockQueryServiceChannel : InterLinq.Tests.Server.IMockQueryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MockQueryServiceClient : System.ServiceModel.ClientBase<InterLinq.Tests.Server.IMockQueryService>, InterLinq.Tests.Server.IMockQueryService {
        
        public MockQueryServiceClient() {
        }
        
        public MockQueryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MockQueryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MockQueryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MockQueryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InterLinq.Tests.Server.RetrieveResponse InterLinq.Tests.Server.IMockQueryService.Retrieve(InterLinq.Tests.Server.RetrieveRequest request) {
            return base.Channel.Retrieve(request);
        }
        
        public object Retrieve(InterLinq.Expressions.SerializableExpression expression) {
            InterLinq.Tests.Server.RetrieveRequest inValue = new InterLinq.Tests.Server.RetrieveRequest();
            inValue.expression = expression;
            InterLinq.Tests.Server.RetrieveResponse retVal = ((InterLinq.Tests.Server.IMockQueryService)(this)).Retrieve(inValue);
            return retVal.RetrieveResult;
        }
    }
}
