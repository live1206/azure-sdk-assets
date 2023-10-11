// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing the SiteRecoveryVaultSetting data model.
    /// Vault setting.
    /// </summary>
    public partial class SiteRecoveryVaultSettingData : ResourceData
    {
        /// <summary> Initializes a new instance of SiteRecoveryVaultSettingData. </summary>
        internal SiteRecoveryVaultSettingData()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryVaultSettingData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The vault setting properties. </param>
        /// <param name="location"> Resource Location. </param>
        internal SiteRecoveryVaultSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SiteRecoveryVaultSettingProperties properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> The vault setting properties. </summary>
        public SiteRecoveryVaultSettingProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}