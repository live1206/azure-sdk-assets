// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// A class representing the DatabaseMigrationSqlVm data model.
    /// Database Migration Resource for SQL Virtual Machine.
    /// </summary>
    public partial class DatabaseMigrationSqlVmData : ResourceData
    {
        /// <summary> Initializes a new instance of DatabaseMigrationSqlVmData. </summary>
        public DatabaseMigrationSqlVmData()
        {
        }

        /// <summary> Initializes a new instance of DatabaseMigrationSqlVmData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Database Migration Resource properties for SQL Virtual Machine. </param>
        internal DatabaseMigrationSqlVmData(ResourceIdentifier id, string name, Core.ResourceType resourceType, SystemData systemData, DatabaseMigrationSqlVmProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Database Migration Resource properties for SQL Virtual Machine. </summary>
        public DatabaseMigrationSqlVmProperties Properties { get; set; }
    }
}