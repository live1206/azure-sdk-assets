// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The GitHubConnectorStats. </summary>
    public partial class GitHubConnectorStats : ResourceData
    {
        /// <summary> Initializes a new instance of GitHubConnectorStats. </summary>
        public GitHubConnectorStats()
        {
        }

        /// <summary> Initializes a new instance of GitHubConnectorStats. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"></param>
        internal GitHubConnectorStats(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, GitHubConnectorStatsProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Gets or sets the properties. </summary>
        public GitHubConnectorStatsProperties Properties { get; set; }
    }
}
