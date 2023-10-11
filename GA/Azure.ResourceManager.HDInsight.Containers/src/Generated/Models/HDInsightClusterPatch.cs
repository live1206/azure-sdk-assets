// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The patch for a cluster. </summary>
    public partial class HDInsightClusterPatch : TrackedResourceData
    {
        /// <summary> Initializes a new instance of HDInsightClusterPatch. </summary>
        /// <param name="location"> The location. </param>
        public HDInsightClusterPatch(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of HDInsightClusterPatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="clusterProfile"> Cluster resource patch properties. </param>
        internal HDInsightClusterPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, UpdatableClusterProfile clusterProfile) : base(id, name, resourceType, systemData, tags, location)
        {
            ClusterProfile = clusterProfile;
        }

        /// <summary> Cluster resource patch properties. </summary>
        public UpdatableClusterProfile ClusterProfile { get; set; }
    }
}