// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> the service specific properties of a provisioning service, including keys, linked iot hubs, current state, and system generated properties such as hostname and idScope. </summary>
    public partial class DeviceProvisioningServiceProperties
    {
        /// <summary> Initializes a new instance of DeviceProvisioningServiceProperties. </summary>
        public DeviceProvisioningServiceProperties()
        {
            IPFilterRules = new ChangeTrackingList<DeviceProvisioningServicesIPFilterRule>();
            PrivateEndpointConnections = new ChangeTrackingList<DeviceProvisioningServicesPrivateEndpointConnectionData>();
            IotHubs = new ChangeTrackingList<IotHubDefinitionDescription>();
            AuthorizationPolicies = new ChangeTrackingList<DeviceProvisioningServicesSharedAccessKey>();
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServiceProperties. </summary>
        /// <param name="state"> Current state of the provisioning service. </param>
        /// <param name="publicNetworkAccess"> Whether requests from Public Network are allowed. </param>
        /// <param name="ipFilterRules"> The IP filter rules. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections created on this IotHub. </param>
        /// <param name="provisioningState"> The ARM provisioning state of the provisioning service. </param>
        /// <param name="iotHubs"> List of IoT hubs associated with this provisioning service. </param>
        /// <param name="allocationPolicy"> Allocation policy to be used by this provisioning service. </param>
        /// <param name="serviceOperationsHostName"> Service endpoint for provisioning service. </param>
        /// <param name="deviceProvisioningHostName"> Device endpoint for this provisioning service. </param>
        /// <param name="idScope"> Unique identifier of this provisioning service. </param>
        /// <param name="authorizationPolicies"> List of authorization keys for a provisioning service. </param>
        /// <param name="isDataResidencyEnabled">
        /// Optional.
        /// Indicates if the DPS instance has Data Residency enabled, removing the cross geo-pair disaster recovery.
        /// </param>
        internal DeviceProvisioningServiceProperties(DeviceProvisioningServicesState? state, DeviceProvisioningServicesPublicNetworkAccess? publicNetworkAccess, IList<DeviceProvisioningServicesIPFilterRule> ipFilterRules, IList<DeviceProvisioningServicesPrivateEndpointConnectionData> privateEndpointConnections, string provisioningState, IList<IotHubDefinitionDescription> iotHubs, DeviceProvisioningServicesAllocationPolicy? allocationPolicy, string serviceOperationsHostName, string deviceProvisioningHostName, string idScope, IList<DeviceProvisioningServicesSharedAccessKey> authorizationPolicies, bool? isDataResidencyEnabled)
        {
            State = state;
            PublicNetworkAccess = publicNetworkAccess;
            IPFilterRules = ipFilterRules;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            IotHubs = iotHubs;
            AllocationPolicy = allocationPolicy;
            ServiceOperationsHostName = serviceOperationsHostName;
            DeviceProvisioningHostName = deviceProvisioningHostName;
            IdScope = idScope;
            AuthorizationPolicies = authorizationPolicies;
            IsDataResidencyEnabled = isDataResidencyEnabled;
        }

        /// <summary> Current state of the provisioning service. </summary>
        public DeviceProvisioningServicesState? State { get; set; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public DeviceProvisioningServicesPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The IP filter rules. </summary>
        public IList<DeviceProvisioningServicesIPFilterRule> IPFilterRules { get; }
        /// <summary> Private endpoint connections created on this IotHub. </summary>
        public IList<DeviceProvisioningServicesPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The ARM provisioning state of the provisioning service. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> List of IoT hubs associated with this provisioning service. </summary>
        public IList<IotHubDefinitionDescription> IotHubs { get; }
        /// <summary> Allocation policy to be used by this provisioning service. </summary>
        public DeviceProvisioningServicesAllocationPolicy? AllocationPolicy { get; set; }
        /// <summary> Service endpoint for provisioning service. </summary>
        public string ServiceOperationsHostName { get; }
        /// <summary> Device endpoint for this provisioning service. </summary>
        public string DeviceProvisioningHostName { get; }
        /// <summary> Unique identifier of this provisioning service. </summary>
        public string IdScope { get; }
        /// <summary> List of authorization keys for a provisioning service. </summary>
        public IList<DeviceProvisioningServicesSharedAccessKey> AuthorizationPolicies { get; }
        /// <summary>
        /// Optional.
        /// Indicates if the DPS instance has Data Residency enabled, removing the cross geo-pair disaster recovery.
        /// </summary>
        public bool? IsDataResidencyEnabled { get; set; }
    }
}
