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
    /// A class representing the MigrationRecoveryPoint data model.
    /// Recovery point for a migration item.
    /// </summary>
    public partial class MigrationRecoveryPointData : ResourceData
    {
        /// <summary> Initializes a new instance of MigrationRecoveryPointData. </summary>
        internal MigrationRecoveryPointData()
        {
        }

        /// <summary> Initializes a new instance of MigrationRecoveryPointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Recovery point properties. </param>
        /// <param name="location"> Resource Location. </param>
        internal MigrationRecoveryPointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MigrationRecoveryPointProperties properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> Recovery point properties. </summary>
        public MigrationRecoveryPointProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}
