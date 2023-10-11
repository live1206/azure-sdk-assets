// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary>
    /// A class representing the DeviceUpdateInstance data model.
    /// Device Update instance details.
    /// </summary>
    public partial class DeviceUpdateInstanceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DeviceUpdateInstanceData. </summary>
        /// <param name="location"> The location. </param>
        public DeviceUpdateInstanceData(AzureLocation location) : base(location)
        {
            IotHubs = new ChangeTrackingList<IotHubSettings>();
        }

        /// <summary> Initializes a new instance of DeviceUpdateInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="accountName"> Parent Device Update Account name which Instance belongs to. </param>
        /// <param name="iotHubs"> List of IoT Hubs associated with the account. </param>
        /// <param name="enableDiagnostics"> Enables or Disables the diagnostic logs collection. </param>
        /// <param name="diagnosticStorageProperties"> Customer-initiated diagnostic log collection storage properties. </param>
        internal DeviceUpdateInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProvisioningState? provisioningState, string accountName, IList<IotHubSettings> iotHubs, bool? enableDiagnostics, DiagnosticStorageProperties diagnosticStorageProperties) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            AccountName = accountName;
            IotHubs = iotHubs;
            EnableDiagnostics = enableDiagnostics;
            DiagnosticStorageProperties = diagnosticStorageProperties;
        }

        /// <summary> Provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Parent Device Update Account name which Instance belongs to. </summary>
        public string AccountName { get; }
        /// <summary> List of IoT Hubs associated with the account. </summary>
        public IList<IotHubSettings> IotHubs { get; }
        /// <summary> Enables or Disables the diagnostic logs collection. </summary>
        public bool? EnableDiagnostics { get; set; }
        /// <summary> Customer-initiated diagnostic log collection storage properties. </summary>
        public DiagnosticStorageProperties DiagnosticStorageProperties { get; set; }
    }
}