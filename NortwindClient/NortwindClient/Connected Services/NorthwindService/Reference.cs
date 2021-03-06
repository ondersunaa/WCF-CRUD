//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/NorthwindService.Models")]
    public partial class Employee : object
    {
        
        private string AciklamaField;
        
        private string AdSoyadField;
        
        private int EmployeeIdField;
        
        private System.DateTime GirisSaatiField;
        
        private string TcNoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Aciklama
        {
            get
            {
                return this.AciklamaField;
            }
            set
            {
                this.AciklamaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AdSoyad
        {
            get
            {
                return this.AdSoyadField;
            }
            set
            {
                this.AdSoyadField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeId
        {
            get
            {
                return this.EmployeeIdField;
            }
            set
            {
                this.EmployeeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime GirisSaati
        {
            get
            {
                return this.GirisSaatiField;
            }
            set
            {
                this.GirisSaatiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TcNo
        {
            get
            {
                return this.TcNoField;
            }
            set
            {
                this.TcNoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NorthwindService.INorthwindService")]
    public interface INorthwindService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/GetAllEmployees", ReplyAction="http://tempuri.org/INorthwindService/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<NorthwindService.Employee[]> GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/GetEmployeeById", ReplyAction="http://tempuri.org/INorthwindService/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<NorthwindService.Employee> GetEmployeeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/UpdateEmployee", ReplyAction="http://tempuri.org/INorthwindService/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task UpdateEmployeeAsync(NorthwindService.Employee model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/DeleteEmployee", ReplyAction="http://tempuri.org/INorthwindService/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task DeleteEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/InsertEmployee", ReplyAction="http://tempuri.org/INorthwindService/InsertEmployeeResponse")]
        System.Threading.Tasks.Task InsertEmployeeAsync(NorthwindService.Employee model);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface INorthwindServiceChannel : NorthwindService.INorthwindService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class NorthwindServiceClient : System.ServiceModel.ClientBase<NorthwindService.INorthwindService>, NorthwindService.INorthwindService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public NorthwindServiceClient() : 
                base(NorthwindServiceClient.GetDefaultBinding(), NorthwindServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_INorthwindService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NorthwindServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(NorthwindServiceClient.GetBindingForEndpoint(endpointConfiguration), NorthwindServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NorthwindServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(NorthwindServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NorthwindServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(NorthwindServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NorthwindServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<NorthwindService.Employee[]> GetAllEmployeesAsync()
        {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public System.Threading.Tasks.Task<NorthwindService.Employee> GetEmployeeByIdAsync(int id)
        {
            return base.Channel.GetEmployeeByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task UpdateEmployeeAsync(NorthwindService.Employee model)
        {
            return base.Channel.UpdateEmployeeAsync(model);
        }
        
        public System.Threading.Tasks.Task DeleteEmployeeAsync(int id)
        {
            return base.Channel.DeleteEmployeeAsync(id);
        }
        
        public System.Threading.Tasks.Task InsertEmployeeAsync(NorthwindService.Employee model)
        {
            return base.Channel.InsertEmployeeAsync(model);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INorthwindService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INorthwindService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8080/NorthwindService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return NorthwindServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_INorthwindService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return NorthwindServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_INorthwindService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_INorthwindService,
        }
    }
}
