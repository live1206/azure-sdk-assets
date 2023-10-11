// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Event details for VMwareCbt provider. </summary>
    public partial class VMwareCbtEventDetails : SiteRecoveryEventProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of VMwareCbtEventDetails. </summary>
        internal VMwareCbtEventDetails()
        {
            InstanceType = "VMwareCbt";
        }

        /// <summary> Initializes a new instance of VMwareCbtEventDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="migrationItemName"> The migration item name. </param>
        internal VMwareCbtEventDetails(string instanceType, string migrationItemName) : base(instanceType)
        {
            MigrationItemName = migrationItemName;
            InstanceType = instanceType ?? "VMwareCbt";
        }

        /// <summary> The migration item name. </summary>
        public string MigrationItemName { get; }
    }
}