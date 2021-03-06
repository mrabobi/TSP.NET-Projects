﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferencePhoto
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Categories", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos", IsReference=true)]
    public partial class Categories : object
    {
        
        private string CategoryNameField;
        
        private int ID_CategoryField;
        
        private System.Collections.Generic.List<ServiceReferencePhoto.PicTable> PicTableField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName
        {
            get
            {
                return this.CategoryNameField;
            }
            set
            {
                this.CategoryNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Category
        {
            get
            {
                return this.ID_CategoryField;
            }
            set
            {
                this.ID_CategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferencePhoto.PicTable> PicTable
        {
            get
            {
                return this.PicTableField;
            }
            set
            {
                this.PicTableField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PicTable", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos", IsReference=true)]
    public partial class PicTable : object
    {
        
        private System.Collections.Generic.List<ServiceReferencePhoto.Categories> CategoriesField;
        
        private System.DateTime Data_createField;
        
        private string DescriptionField;
        
        private int ID_IMGField;
        
        private string LocationField;
        
        private string Name_imgField;
        
        private string PathField;
        
        private System.Collections.Generic.List<ServiceReferencePhoto.Person> PersonField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferencePhoto.Categories> Categories
        {
            get
            {
                return this.CategoriesField;
            }
            set
            {
                this.CategoriesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data_create
        {
            get
            {
                return this.Data_createField;
            }
            set
            {
                this.Data_createField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_IMG
        {
            get
            {
                return this.ID_IMGField;
            }
            set
            {
                this.ID_IMGField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name_img
        {
            get
            {
                return this.Name_imgField;
            }
            set
            {
                this.Name_imgField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferencePhoto.Person> Person
        {
            get
            {
                return this.PersonField;
            }
            set
            {
                this.PersonField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos")]
    public partial class Person : object
    {
        
        private string FirstNameField;
        
        private int ID_PersonField;
        
        private System.Collections.Generic.List<ServiceReferencePhoto.PicTable> PicTableField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Person
        {
            get
            {
                return this.ID_PersonField;
            }
            set
            {
                this.ID_PersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferencePhoto.PicTable> PicTable
        {
            get
            {
                return this.PicTableField;
            }
            set
            {
                this.PicTableField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePhoto.IMyPhotosService")]
    public interface IMyPhotosService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategories/isInCategories", ReplyAction="http://tempuri.org/ICategories/isInCategoriesResponse")]
        System.Threading.Tasks.Task<bool> isInCategoriesAsync(string index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategories/GetCategoriesById", ReplyAction="http://tempuri.org/ICategories/GetCategoriesByIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhoto.Categories>> GetCategoriesByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/existPerson", ReplyAction="http://tempuri.org/IPerson/existPersonResponse")]
        System.Threading.Tasks.Task<bool> existPersonAsync(string nameP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/AddEntry", ReplyAction="http://tempuri.org/IPicTable/AddEntryResponse")]
        System.Threading.Tasks.Task AddEntryAsync(string name, string path, string description, string location, System.DateTime dt, System.Collections.Generic.List<string> categories, System.Collections.Generic.List<string> peoplys);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/updateEntry", ReplyAction="http://tempuri.org/IPicTable/updateEntryResponse")]
        System.Threading.Tasks.Task updateEntryAsync(int id, string title, string description, string location, System.Collections.Generic.List<string> categories, System.Collections.Generic.List<string> peoples);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/GetAllPicsForLoad", ReplyAction="http://tempuri.org/IPicTable/GetAllPicsForLoadResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhoto.PicTable>> GetAllPicsForLoadAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/RemoveEntry", ReplyAction="http://tempuri.org/IPicTable/RemoveEntryResponse")]
        System.Threading.Tasks.Task RemoveEntryAsync(int ImageIndex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/getDataFiltered", ReplyAction="http://tempuri.org/IPicTable/getDataFilteredResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhoto.PicTable>> getDataFilteredAsync(string filterString, string text);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMyPhotosServiceChannel : ServiceReferencePhoto.IMyPhotosService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MyPhotosServiceClient : System.ServiceModel.ClientBase<ServiceReferencePhoto.IMyPhotosService>, ServiceReferencePhoto.IMyPhotosService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MyPhotosServiceClient() : 
                base(MyPhotosServiceClient.GetDefaultBinding(), MyPhotosServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MyPhotosServiceClient.GetBindingForEndpoint(endpointConfiguration), MyPhotosServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MyPhotosServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MyPhotosServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> isInCategoriesAsync(string index)
        {
            return base.Channel.isInCategoriesAsync(index);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhoto.Categories>> GetCategoriesByIdAsync(int id)
        {
            return base.Channel.GetCategoriesByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<bool> existPersonAsync(string nameP)
        {
            return base.Channel.existPersonAsync(nameP);
        }
        
        public System.Threading.Tasks.Task AddEntryAsync(string name, string path, string description, string location, System.DateTime dt, System.Collections.Generic.List<string> categories, System.Collections.Generic.List<string> peoplys)
        {
            return base.Channel.AddEntryAsync(name, path, description, location, dt, categories, peoplys);
        }
        
        public System.Threading.Tasks.Task updateEntryAsync(int id, string title, string description, string location, System.Collections.Generic.List<string> categories, System.Collections.Generic.List<string> peoples)
        {
            return base.Channel.updateEntryAsync(id, title, description, location, categories, peoples);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhoto.PicTable>> GetAllPicsForLoadAsync()
        {
            return base.Channel.GetAllPicsForLoadAsync();
        }
        
        public System.Threading.Tasks.Task RemoveEntryAsync(int ImageIndex)
        {
            return base.Channel.RemoveEntryAsync(ImageIndex);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhoto.PicTable>> getDataFilteredAsync(string filterString, string text)
        {
            return base.Channel.getDataFilteredAsync(filterString, text);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MyPhotosServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MyPhotosServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService,
        }
    }
}
