// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    /// <summary> EnabledResourceType definition. </summary>
    public partial class CustomLocationEnabledResourceType : ResourceData
    {
        /// <summary> Initializes a new instance of CustomLocationEnabledResourceType. </summary>
        public CustomLocationEnabledResourceType()
        {
            TypesMetadata = new ChangeTrackingList<CustomLocationEnabledResourceTypeMetadata>();
        }

        /// <summary> Initializes a new instance of CustomLocationEnabledResourceType. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="clusterExtensionId"> Cluster Extension ID. </param>
        /// <param name="extensionType"> Cluster Extension Type. </param>
        /// <param name="typesMetadata"> Metadata of the Resource Type. </param>
        internal CustomLocationEnabledResourceType(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier clusterExtensionId, string extensionType, IList<CustomLocationEnabledResourceTypeMetadata> typesMetadata) : base(id, name, resourceType, systemData)
        {
            ClusterExtensionId = clusterExtensionId;
            ExtensionType = extensionType;
            TypesMetadata = typesMetadata;
        }

        /// <summary> Cluster Extension ID. </summary>
        public ResourceIdentifier ClusterExtensionId { get; set; }
        /// <summary> Cluster Extension Type. </summary>
        public string ExtensionType { get; set; }
        /// <summary> Metadata of the Resource Type. </summary>
        public IList<CustomLocationEnabledResourceTypeMetadata> TypesMetadata { get; }
    }
}