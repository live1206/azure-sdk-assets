// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> HyperV migrate fabric model custom properties. </summary>
    public partial class HyperVMigrateFabricModelCustomProperties : FabricModelCustomProperties
    {
        /// <summary> Initializes a new instance of HyperVMigrateFabricModelCustomProperties. </summary>
        /// <param name="hyperVSiteId"> Gets or sets the ARM Id of the HyperV site. </param>
        /// <param name="migrationSolutionId"> Gets or sets the migration solution ARM Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hyperVSiteId"/> or <paramref name="migrationSolutionId"/> is null. </exception>
        public HyperVMigrateFabricModelCustomProperties(ResourceIdentifier hyperVSiteId, ResourceIdentifier migrationSolutionId)
        {
            Argument.AssertNotNull(hyperVSiteId, nameof(hyperVSiteId));
            Argument.AssertNotNull(migrationSolutionId, nameof(migrationSolutionId));

            HyperVSiteId = hyperVSiteId;
            MigrationSolutionId = migrationSolutionId;
            InstanceType = "HyperVMigrate";
        }

        /// <summary> Initializes a new instance of HyperVMigrateFabricModelCustomProperties. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        /// <param name="hyperVSiteId"> Gets or sets the ARM Id of the HyperV site. </param>
        /// <param name="fabricResourceId"> Gets or sets the fabric resource Id. </param>
        /// <param name="fabricContainerId"> Gets or sets the fabric container Id. </param>
        /// <param name="migrationSolutionId"> Gets or sets the migration solution ARM Id. </param>
        /// <param name="migrationHubUri"> Gets or sets the migration hub Uri. </param>
        internal HyperVMigrateFabricModelCustomProperties(string instanceType, ResourceIdentifier hyperVSiteId, ResourceIdentifier fabricResourceId, string fabricContainerId, ResourceIdentifier migrationSolutionId, Uri migrationHubUri) : base(instanceType)
        {
            HyperVSiteId = hyperVSiteId;
            FabricResourceId = fabricResourceId;
            FabricContainerId = fabricContainerId;
            MigrationSolutionId = migrationSolutionId;
            MigrationHubUri = migrationHubUri;
            InstanceType = instanceType ?? "HyperVMigrate";
        }

        /// <summary> Gets or sets the ARM Id of the HyperV site. </summary>
        public ResourceIdentifier HyperVSiteId { get; set; }
        /// <summary> Gets or sets the fabric resource Id. </summary>
        public ResourceIdentifier FabricResourceId { get; }
        /// <summary> Gets or sets the fabric container Id. </summary>
        public string FabricContainerId { get; }
        /// <summary> Gets or sets the migration solution ARM Id. </summary>
        public ResourceIdentifier MigrationSolutionId { get; set; }
        /// <summary> Gets or sets the migration hub Uri. </summary>
        public Uri MigrationHubUri { get; }
    }
}