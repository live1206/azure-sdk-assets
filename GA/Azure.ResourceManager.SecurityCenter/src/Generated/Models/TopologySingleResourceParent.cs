// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The TopologySingleResourceParent. </summary>
    public partial class TopologySingleResourceParent
    {
        /// <summary> Initializes a new instance of TopologySingleResourceParent. </summary>
        internal TopologySingleResourceParent()
        {
        }

        /// <summary> Initializes a new instance of TopologySingleResourceParent. </summary>
        /// <param name="resourceId"> Azure resource id which serves as parent resource in topology view. </param>
        internal TopologySingleResourceParent(ResourceIdentifier resourceId)
        {
            ResourceId = resourceId;
        }

        /// <summary> Azure resource id which serves as parent resource in topology view. </summary>
        public ResourceIdentifier ResourceId { get; }
    }
}