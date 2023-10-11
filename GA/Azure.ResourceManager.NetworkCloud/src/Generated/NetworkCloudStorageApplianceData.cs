// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the NetworkCloudStorageAppliance data model.
    /// StorageAppliance represents on-premises Network Cloud storage appliance.
    /// </summary>
    public partial class NetworkCloudStorageApplianceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkCloudStorageApplianceData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="administratorCredentials"> The credentials of the administrative interface on this storage appliance. </param>
        /// <param name="rackId"> The resource ID of the rack where this storage appliance resides. </param>
        /// <param name="rackSlot"> The slot the storage appliance is in the rack based on the BOM configuration. </param>
        /// <param name="serialNumber"> The serial number for the storage appliance. </param>
        /// <param name="storageApplianceSkuId"> The SKU for the storage appliance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/>, <paramref name="administratorCredentials"/>, <paramref name="rackId"/>, <paramref name="serialNumber"/> or <paramref name="storageApplianceSkuId"/> is null. </exception>
        public NetworkCloudStorageApplianceData(AzureLocation location, ExtendedLocation extendedLocation, AdministrativeCredentials administratorCredentials, ResourceIdentifier rackId, long rackSlot, string serialNumber, string storageApplianceSkuId) : base(location)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));
            Argument.AssertNotNull(administratorCredentials, nameof(administratorCredentials));
            Argument.AssertNotNull(rackId, nameof(rackId));
            Argument.AssertNotNull(serialNumber, nameof(serialNumber));
            Argument.AssertNotNull(storageApplianceSkuId, nameof(storageApplianceSkuId));

            ExtendedLocation = extendedLocation;
            AdministratorCredentials = administratorCredentials;
            RackId = rackId;
            RackSlot = rackSlot;
            SerialNumber = serialNumber;
            StorageApplianceSkuId = storageApplianceSkuId;
        }

        /// <summary> Initializes a new instance of NetworkCloudStorageApplianceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="administratorCredentials"> The credentials of the administrative interface on this storage appliance. </param>
        /// <param name="capacity"> The total capacity of the storage appliance. </param>
        /// <param name="capacityUsed"> The amount of storage consumed. </param>
        /// <param name="clusterId"> The resource ID of the cluster this storage appliance is associated with. </param>
        /// <param name="detailedStatus"> The detailed status of the storage appliance. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="managementIPv4Address"> The endpoint for the management interface of the storage appliance. </param>
        /// <param name="provisioningState"> The provisioning state of the storage appliance. </param>
        /// <param name="rackId"> The resource ID of the rack where this storage appliance resides. </param>
        /// <param name="rackSlot"> The slot the storage appliance is in the rack based on the BOM configuration. </param>
        /// <param name="remoteVendorManagementFeature"> The indicator of whether the storage appliance supports remote vendor management. </param>
        /// <param name="remoteVendorManagementStatus"> The indicator of whether the remote vendor management feature is enabled or disabled, or unsupported if it is an unsupported feature. </param>
        /// <param name="serialNumber"> The serial number for the storage appliance. </param>
        /// <param name="storageApplianceSkuId"> The SKU for the storage appliance. </param>
        internal NetworkCloudStorageApplianceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, AdministrativeCredentials administratorCredentials, long? capacity, long? capacityUsed, ResourceIdentifier clusterId, StorageApplianceDetailedStatus? detailedStatus, string detailedStatusMessage, IPAddress managementIPv4Address, StorageApplianceProvisioningState? provisioningState, ResourceIdentifier rackId, long rackSlot, RemoteVendorManagementFeature? remoteVendorManagementFeature, RemoteVendorManagementStatus? remoteVendorManagementStatus, string serialNumber, string storageApplianceSkuId) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            AdministratorCredentials = administratorCredentials;
            Capacity = capacity;
            CapacityUsed = capacityUsed;
            ClusterId = clusterId;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            ManagementIPv4Address = managementIPv4Address;
            ProvisioningState = provisioningState;
            RackId = rackId;
            RackSlot = rackSlot;
            RemoteVendorManagementFeature = remoteVendorManagementFeature;
            RemoteVendorManagementStatus = remoteVendorManagementStatus;
            SerialNumber = serialNumber;
            StorageApplianceSkuId = storageApplianceSkuId;
        }

        /// <summary> The extended location of the cluster associated with the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The credentials of the administrative interface on this storage appliance. </summary>
        public AdministrativeCredentials AdministratorCredentials { get; set; }
        /// <summary> The total capacity of the storage appliance. </summary>
        public long? Capacity { get; }
        /// <summary> The amount of storage consumed. </summary>
        public long? CapacityUsed { get; }
        /// <summary> The resource ID of the cluster this storage appliance is associated with. </summary>
        public ResourceIdentifier ClusterId { get; }
        /// <summary> The detailed status of the storage appliance. </summary>
        public StorageApplianceDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> The endpoint for the management interface of the storage appliance. </summary>
        public IPAddress ManagementIPv4Address { get; }
        /// <summary> The provisioning state of the storage appliance. </summary>
        public StorageApplianceProvisioningState? ProvisioningState { get; }
        /// <summary> The resource ID of the rack where this storage appliance resides. </summary>
        public ResourceIdentifier RackId { get; set; }
        /// <summary> The slot the storage appliance is in the rack based on the BOM configuration. </summary>
        public long RackSlot { get; set; }
        /// <summary> The indicator of whether the storage appliance supports remote vendor management. </summary>
        public RemoteVendorManagementFeature? RemoteVendorManagementFeature { get; }
        /// <summary> The indicator of whether the remote vendor management feature is enabled or disabled, or unsupported if it is an unsupported feature. </summary>
        public RemoteVendorManagementStatus? RemoteVendorManagementStatus { get; }
        /// <summary> The serial number for the storage appliance. </summary>
        public string SerialNumber { get; set; }
        /// <summary> The SKU for the storage appliance. </summary>
        public string StorageApplianceSkuId { get; set; }
    }
}