// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkFunction.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.NetworkFunction
{
    /// <summary>
    /// A class representing the AzureTrafficCollector data model.
    /// Azure Traffic Collector resource.
    /// </summary>
    public partial class AzureTrafficCollectorData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AzureTrafficCollectorData. </summary>
        /// <param name="location"> The location. </param>
        public AzureTrafficCollectorData(AzureLocation location) : base(location)
        {
            CollectorPolicies = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of AzureTrafficCollectorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="collectorPolicies"> Collector Policies for Azure Traffic Collector. </param>
        /// <param name="virtualHub"> The virtualHub to which the Azure Traffic Collector belongs. </param>
        /// <param name="provisioningState"> The provisioning state of the application rule collection resource. </param>
        internal AzureTrafficCollectorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, IReadOnlyList<SubResource> collectorPolicies, SubResource virtualHub, CollectorProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            CollectorPolicies = collectorPolicies;
            VirtualHub = virtualHub;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Collector Policies for Azure Traffic Collector. </summary>
        public IReadOnlyList<SubResource> CollectorPolicies { get; }
        /// <summary> The virtualHub to which the Azure Traffic Collector belongs. </summary>
        internal SubResource VirtualHub { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier VirtualHubId
        {
            get => VirtualHub is null ? default : VirtualHub.Id;
        }

        /// <summary> The provisioning state of the application rule collection resource. </summary>
        public CollectorProvisioningState? ProvisioningState { get; }
    }
}
