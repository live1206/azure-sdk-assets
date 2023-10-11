// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A class representing the CosmosDBForPostgreSqlConfiguration data model.
    /// Represents configuration details for coordinator and node.
    /// </summary>
    public partial class CosmosDBForPostgreSqlConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of CosmosDBForPostgreSqlConfigurationData. </summary>
        public CosmosDBForPostgreSqlConfigurationData()
        {
            ServerRoleGroupConfigurations = new ChangeTrackingList<CosmosDBForPostgreSqlServerRoleGroupConfiguration>();
        }

        /// <summary> Initializes a new instance of CosmosDBForPostgreSqlConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description of the configuration. </param>
        /// <param name="dataType"> Data type of the configuration. </param>
        /// <param name="allowedValues"> Allowed values of the configuration. </param>
        /// <param name="isRestartRequired"> If configuration change requires restart. </param>
        /// <param name="serverRoleGroupConfigurations"> The list of server role group configuration values. </param>
        /// <param name="provisioningState"> Provisioning state of the configuration. </param>
        internal CosmosDBForPostgreSqlConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, CosmosDBForPostgreSqlConfigurationDataType? dataType, string allowedValues, bool? isRestartRequired, IList<CosmosDBForPostgreSqlServerRoleGroupConfiguration> serverRoleGroupConfigurations, CosmosDBForPostgreSqlProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Description = description;
            DataType = dataType;
            AllowedValues = allowedValues;
            IsRestartRequired = isRestartRequired;
            ServerRoleGroupConfigurations = serverRoleGroupConfigurations;
            ProvisioningState = provisioningState;
        }

        /// <summary> Description of the configuration. </summary>
        public string Description { get; }
        /// <summary> Data type of the configuration. </summary>
        public CosmosDBForPostgreSqlConfigurationDataType? DataType { get; }
        /// <summary> Allowed values of the configuration. </summary>
        public string AllowedValues { get; }
        /// <summary> If configuration change requires restart. </summary>
        public bool? IsRestartRequired { get; set; }
        /// <summary> The list of server role group configuration values. </summary>
        public IList<CosmosDBForPostgreSqlServerRoleGroupConfiguration> ServerRoleGroupConfigurations { get; }
        /// <summary> Provisioning state of the configuration. </summary>
        public CosmosDBForPostgreSqlProvisioningState? ProvisioningState { get; }
    }
}