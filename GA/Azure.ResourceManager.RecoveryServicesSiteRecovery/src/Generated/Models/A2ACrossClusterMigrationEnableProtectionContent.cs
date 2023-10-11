// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A Cross-Cluster Migration enable protection input. </summary>
    public partial class A2ACrossClusterMigrationEnableProtectionContent : EnableProtectionProviderSpecificContent
    {
        /// <summary> Initializes a new instance of A2ACrossClusterMigrationEnableProtectionContent. </summary>
        public A2ACrossClusterMigrationEnableProtectionContent()
        {
            InstanceType = "A2ACrossClusterMigration";
        }

        /// <summary> The fabric specific object Id of the virtual machine. </summary>
        public ResourceIdentifier FabricObjectId { get; set; }
        /// <summary> The recovery container Id. </summary>
        public ResourceIdentifier RecoveryContainerId { get; set; }
    }
}