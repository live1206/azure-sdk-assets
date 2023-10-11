// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityDevOps.Models;

namespace Azure.ResourceManager.SecurityDevOps
{
    /// <summary>
    /// A class representing the AzureDevOpsRepo data model.
    /// Azure DevOps Repo Proxy Resource.
    /// </summary>
    public partial class AzureDevOpsRepoData : ResourceData
    {
        /// <summary> Initializes a new instance of AzureDevOpsRepoData. </summary>
        public AzureDevOpsRepoData()
        {
        }

        /// <summary> Initializes a new instance of AzureDevOpsRepoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> AzureDevOps Repo properties. </param>
        internal AzureDevOpsRepoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureDevOpsRepoProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> AzureDevOps Repo properties. </summary>
        public AzureDevOpsRepoProperties Properties { get; set; }
    }
}
