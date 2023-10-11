// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ManagedNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ManagedNetwork
{
    /// <summary>
    /// A class representing the ManagedNetworkGroup data model.
    /// The Managed Network Group resource
    /// </summary>
    public partial class ManagedNetworkGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedNetworkGroupData. </summary>
        public ManagedNetworkGroupData()
        {
            ManagementGroups = new ChangeTrackingList<WritableSubResource>();
            Subscriptions = new ChangeTrackingList<WritableSubResource>();
            VirtualNetworks = new ChangeTrackingList<WritableSubResource>();
            Subnets = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of ManagedNetworkGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Responsibility role under which this Managed Network Group will be created. </param>
        /// <param name="provisioningState"> Provisioning state of the ManagedNetwork resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="managementGroups"> The collection of management groups covered by the Managed Network. </param>
        /// <param name="subscriptions"> The collection of subscriptions covered by the Managed Network. </param>
        /// <param name="virtualNetworks"> The collection of virtual nets covered by the Managed Network. </param>
        /// <param name="subnets"> The collection of  subnets covered by the Managed Network. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal ManagedNetworkGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedNetworkKind? kind, ProvisioningState? provisioningState, ETag? etag, IList<WritableSubResource> managementGroups, IList<WritableSubResource> subscriptions, IList<WritableSubResource> virtualNetworks, IList<WritableSubResource> subnets, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ProvisioningState = provisioningState;
            ETag = etag;
            ManagementGroups = managementGroups;
            Subscriptions = subscriptions;
            VirtualNetworks = virtualNetworks;
            Subnets = subnets;
            Location = location;
        }

        /// <summary> Responsibility role under which this Managed Network Group will be created. </summary>
        public ManagedNetworkKind? Kind { get; set; }
        /// <summary> Provisioning state of the ManagedNetwork resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The collection of management groups covered by the Managed Network. </summary>
        public IList<WritableSubResource> ManagementGroups { get; }
        /// <summary> The collection of subscriptions covered by the Managed Network. </summary>
        public IList<WritableSubResource> Subscriptions { get; }
        /// <summary> The collection of virtual nets covered by the Managed Network. </summary>
        public IList<WritableSubResource> VirtualNetworks { get; }
        /// <summary> The collection of  subnets covered by the Managed Network. </summary>
        public IList<WritableSubResource> Subnets { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; set; }
    }
}