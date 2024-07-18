﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilesServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UploadFileModel", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayer.File")]
    public partial class UploadFileModel : object
    {
        
        private string ApplicationNameField;
        
        private int ContentLengthField;
        
        private string ContentTypeField;
        
        private string FileNameField;
        
        private byte[] InputStreamField;
        
        private bool ReplaceIfExistField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationName
        {
            get
            {
                return this.ApplicationNameField;
            }
            set
            {
                this.ApplicationNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ContentLength
        {
            get
            {
                return this.ContentLengthField;
            }
            set
            {
                this.ContentLengthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContentType
        {
            get
            {
                return this.ContentTypeField;
            }
            set
            {
                this.ContentTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName
        {
            get
            {
                return this.FileNameField;
            }
            set
            {
                this.FileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] InputStream
        {
            get
            {
                return this.InputStreamField;
            }
            set
            {
                this.InputStreamField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ReplaceIfExist
        {
            get
            {
                return this.ReplaceIfExistField;
            }
            set
            {
                this.ReplaceIfExistField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileModel", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayer.File")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FilesServiceReference.CopyFileModel))]
    public partial class FileModel : object
    {
        
        private string ApplicationNameField;
        
        private string FileNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationName
        {
            get
            {
                return this.ApplicationNameField;
            }
            set
            {
                this.ApplicationNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName
        {
            get
            {
                return this.FileNameField;
            }
            set
            {
                this.FileNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CopyFileModel", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayer.File")]
    public partial class CopyFileModel : FilesServiceReference.FileModel
    {
        
        private string NewFileNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NewFileName
        {
            get
            {
                return this.NewFileNameField;
            }
            set
            {
                this.NewFileNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FilesServiceReference.IFile")]
    public interface IFile
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/Upload", ReplyAction="http://tempuri.org/IFile/UploadResponse")]
        System.Threading.Tasks.Task<string> UploadAsync(FilesServiceReference.UploadFileModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/View", ReplyAction="http://tempuri.org/IFile/ViewResponse")]
        System.Threading.Tasks.Task<string> ViewAsync(FilesServiceReference.FileModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/Download", ReplyAction="http://tempuri.org/IFile/DownloadResponse")]
        System.Threading.Tasks.Task<string> DownloadAsync(FilesServiceReference.FileModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/DownloadBytes", ReplyAction="http://tempuri.org/IFile/DownloadBytesResponse")]
        System.Threading.Tasks.Task<byte[]> DownloadBytesAsync(FilesServiceReference.FileModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/Delete", ReplyAction="http://tempuri.org/IFile/DeleteResponse")]
        System.Threading.Tasks.Task<string> DeleteAsync(FilesServiceReference.FileModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/Copy", ReplyAction="http://tempuri.org/IFile/CopyResponse")]
        System.Threading.Tasks.Task<string> CopyAsync(FilesServiceReference.CopyFileModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/MergePDFs", ReplyAction="http://tempuri.org/IFile/MergePDFsResponse")]
        System.Threading.Tasks.Task<byte[]> MergePDFsAsync(string[] pdfs);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IFileChannel : FilesServiceReference.IFile, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class FileClient : System.ServiceModel.ClientBase<FilesServiceReference.IFile>, FilesServiceReference.IFile
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FileClient() : 
                base(FileClient.GetDefaultBinding(), FileClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_IFile.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FileClient(EndpointConfiguration endpointConfiguration) : 
                base(FileClient.GetBindingForEndpoint(endpointConfiguration), FileClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FileClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FileClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FileClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FileClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FileClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> UploadAsync(FilesServiceReference.UploadFileModel model)
        {
            return base.Channel.UploadAsync(model);
        }
        
        public System.Threading.Tasks.Task<string> ViewAsync(FilesServiceReference.FileModel model)
        {
            return base.Channel.ViewAsync(model);
        }
        
        public System.Threading.Tasks.Task<string> DownloadAsync(FilesServiceReference.FileModel model)
        {
            return base.Channel.DownloadAsync(model);
        }
        
        public System.Threading.Tasks.Task<byte[]> DownloadBytesAsync(FilesServiceReference.FileModel model)
        {
            return base.Channel.DownloadBytesAsync(model);
        }
        
        public System.Threading.Tasks.Task<string> DeleteAsync(FilesServiceReference.FileModel model)
        {
            return base.Channel.DeleteAsync(model);
        }
        
        public System.Threading.Tasks.Task<string> CopyAsync(FilesServiceReference.CopyFileModel model)
        {
            return base.Channel.CopyAsync(model);
        }
        
        public System.Threading.Tasks.Task<byte[]> MergePDFsAsync(string[] pdfs)
        {
            return base.Channel.MergePDFsAsync(pdfs);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IFile))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.TransferMode = System.ServiceModel.TransferMode.Streamed;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IFile))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://bld01.ekfu.local/FileService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return FileClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_IFile);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return FileClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_IFile);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IFile,
        }
    }
}