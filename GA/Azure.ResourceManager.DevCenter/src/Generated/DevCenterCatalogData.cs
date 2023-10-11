// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing the DevCenterCatalog data model.
    /// Represents a catalog.
    /// </summary>
    public partial class DevCenterCatalogData : ResourceData
    {
        /// <summary> Initializes a new instance of DevCenterCatalogData. </summary>
        public DevCenterCatalogData()
        {
        }

        /// <summary> Initializes a new instance of DevCenterCatalogData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="gitHub"> Properties for a GitHub catalog type. </param>
        /// <param name="adoGit"> Properties for an Azure DevOps catalog type. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="syncState"> The synchronization state of the catalog. </param>
        /// <param name="lastSyncOn"> When the catalog was last synced. </param>
        internal DevCenterCatalogData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DevCenterGitCatalog gitHub, DevCenterGitCatalog adoGit, DevCenterProvisioningState? provisioningState, DevCenterCatalogSyncState? syncState, DateTimeOffset? lastSyncOn) : base(id, name, resourceType, systemData)
        {
            GitHub = gitHub;
            AdoGit = adoGit;
            ProvisioningState = provisioningState;
            SyncState = syncState;
            LastSyncOn = lastSyncOn;
        }

        /// <summary> Properties for a GitHub catalog type. </summary>
        public DevCenterGitCatalog GitHub { get; set; }
        /// <summary> Properties for an Azure DevOps catalog type. </summary>
        public DevCenterGitCatalog AdoGit { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public DevCenterProvisioningState? ProvisioningState { get; }
        /// <summary> The synchronization state of the catalog. </summary>
        public DevCenterCatalogSyncState? SyncState { get; }
        /// <summary> When the catalog was last synced. </summary>
        public DateTimeOffset? LastSyncOn { get; }
    }
}