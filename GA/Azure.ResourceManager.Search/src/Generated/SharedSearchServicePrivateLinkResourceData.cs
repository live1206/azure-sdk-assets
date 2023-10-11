// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    /// <summary>
    /// A class representing the SharedSearchServicePrivateLinkResource data model.
    /// Describes a Shared Private Link Resource managed by the Azure Cognitive Search service.
    /// </summary>
    public partial class SharedSearchServicePrivateLinkResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of SharedSearchServicePrivateLinkResourceData. </summary>
        public SharedSearchServicePrivateLinkResourceData()
        {
        }

        /// <summary> Initializes a new instance of SharedSearchServicePrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Describes the properties of a Shared Private Link Resource managed by the Azure Cognitive Search service. </param>
        internal SharedSearchServicePrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SharedSearchServicePrivateLinkResourceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Describes the properties of a Shared Private Link Resource managed by the Azure Cognitive Search service. </summary>
        public SharedSearchServicePrivateLinkResourceProperties Properties { get; set; }
    }
}
