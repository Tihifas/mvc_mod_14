﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotoSharingApplication.GeocodeService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GeocodeService.ILocationCheckerService")]
    public interface ILocationCheckerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationCheckerService/GetLocation", ReplyAction="http://tempuri.org/ILocationCheckerService/GetLocationResponse")]
        string GetLocation(string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationCheckerService/GetLocation", ReplyAction="http://tempuri.org/ILocationCheckerService/GetLocationResponse")]
        System.Threading.Tasks.Task<string> GetLocationAsync(string address);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILocationCheckerServiceChannel : PhotoSharingApplication.GeocodeService.ILocationCheckerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LocationCheckerServiceClient : System.ServiceModel.ClientBase<PhotoSharingApplication.GeocodeService.ILocationCheckerService>, PhotoSharingApplication.GeocodeService.ILocationCheckerService {
        
        public LocationCheckerServiceClient() {
        }
        
        public LocationCheckerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LocationCheckerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocationCheckerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocationCheckerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetLocation(string address) {
            return base.Channel.GetLocation(address);
        }
        
        public System.Threading.Tasks.Task<string> GetLocationAsync(string address) {
            return base.Channel.GetLocationAsync(address);
        }
    }
}
