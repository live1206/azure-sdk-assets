// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PrivateDns.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.PrivateDns
{
    /// <summary>
    /// A class representing the VirtualNetworkLink data model.
    /// Describes a link to virtual network for a Private DNS zone.
    /// </summary>
    public partial class VirtualNetworkLinkData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualNetworkLinkData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualNetworkLinkData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The ETag of the virtual network link. </param>
        /// <param name="virtualNetwork"> The reference of the virtual network. </param>
        /// <param name="registrationEnabled"> Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled?. </param>
        /// <param name="virtualNetworkLinkState"> The status of the virtual network link to the Private DNS zone. Possible values are 'InProgress' and 'Done'. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="privateDnsProvisioningState"> The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored. </param>
        internal VirtualNetworkLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, WritableSubResource virtualNetwork, bool? registrationEnabled, VirtualNetworkLinkState? virtualNetworkLinkState, PrivateDnsProvisioningState? privateDnsProvisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            VirtualNetwork = virtualNetwork;
            RegistrationEnabled = registrationEnabled;
            VirtualNetworkLinkState = virtualNetworkLinkState;
            PrivateDnsProvisioningState = privateDnsProvisioningState;
        }

        /// <summary> The ETag of the virtual network link. </summary>
        public ETag? ETag { get; set; }
        /// <summary> The reference of the virtual network. </summary>
        internal WritableSubResource VirtualNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualNetworkId
        {
            get => VirtualNetwork is null ? default : VirtualNetwork.Id;
            set
            {
                if (VirtualNetwork is null)
                    VirtualNetwork = new WritableSubResource();
                VirtualNetwork.Id = value;
            }
        }

        /// <summary> Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled?. </summary>
        public bool? RegistrationEnabled { get; set; }
        /// <summary> The status of the virtual network link to the Private DNS zone. Possible values are 'InProgress' and 'Done'. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public VirtualNetworkLinkState? VirtualNetworkLinkState { get; }
        /// <summary> The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public PrivateDnsProvisioningState? PrivateDnsProvisioningState { get; }
    }
}