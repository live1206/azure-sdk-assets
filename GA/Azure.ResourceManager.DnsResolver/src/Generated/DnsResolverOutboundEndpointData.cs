// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DnsResolver.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing the DnsResolverOutboundEndpoint data model.
    /// Describes an outbound endpoint for a DNS resolver.
    /// </summary>
    public partial class DnsResolverOutboundEndpointData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DnsResolverOutboundEndpointData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="subnet"> The reference to the subnet used for the outbound endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnet"/> is null. </exception>
        public DnsResolverOutboundEndpointData(AzureLocation location, WritableSubResource subnet) : base(location)
        {
            Argument.AssertNotNull(subnet, nameof(subnet));

            Subnet = subnet;
        }

        /// <summary> Initializes a new instance of DnsResolverOutboundEndpointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> ETag of the outbound endpoint. </param>
        /// <param name="subnet"> The reference to the subnet used for the outbound endpoint. </param>
        /// <param name="provisioningState"> The current provisioning state of the outbound endpoint. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="resourceGuid"> The resourceGuid property of the outbound endpoint resource. </param>
        internal DnsResolverOutboundEndpointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, WritableSubResource subnet, DnsResolverProvisioningState? provisioningState, Guid? resourceGuid) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            Subnet = subnet;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
        }

        /// <summary> ETag of the outbound endpoint. </summary>
        public ETag? ETag { get; }
        /// <summary> The reference to the subnet used for the outbound endpoint. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }

        /// <summary> The current provisioning state of the outbound endpoint. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public DnsResolverProvisioningState? ProvisioningState { get; }
        /// <summary> The resourceGuid property of the outbound endpoint resource. </summary>
        public Guid? ResourceGuid { get; }
    }
}