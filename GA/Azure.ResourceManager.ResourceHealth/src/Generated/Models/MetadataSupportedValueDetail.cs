// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> The metadata supported value detail. </summary>
    public partial class MetadataSupportedValueDetail
    {
        /// <summary> Initializes a new instance of MetadataSupportedValueDetail. </summary>
        internal MetadataSupportedValueDetail()
        {
            ResourceTypes = new ChangeTrackingList<ResourceType>();
        }

        /// <summary> Initializes a new instance of MetadataSupportedValueDetail. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="displayName"> The display name. </param>
        /// <param name="resourceTypes"> The list of associated resource types. </param>
        internal MetadataSupportedValueDetail(string id, string displayName, IReadOnlyList<ResourceType> resourceTypes)
        {
            Id = id;
            DisplayName = displayName;
            ResourceTypes = resourceTypes;
        }

        /// <summary> The id. </summary>
        public string Id { get; }
        /// <summary> The display name. </summary>
        public string DisplayName { get; }
        /// <summary> The list of associated resource types. </summary>
        public IReadOnlyList<ResourceType> ResourceTypes { get; }
    }
}