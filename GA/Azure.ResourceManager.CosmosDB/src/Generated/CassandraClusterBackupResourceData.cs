// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the CassandraClusterBackupResource data model.
    /// A restorable backup of a Cassandra cluster.
    /// </summary>
    public partial class CassandraClusterBackupResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of CassandraClusterBackupResourceData. </summary>
        public CassandraClusterBackupResourceData()
        {
        }

        /// <summary> Initializes a new instance of CassandraClusterBackupResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"></param>
        internal CassandraClusterBackupResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BackupResourceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Gets or sets the properties. </summary>
        internal BackupResourceProperties Properties { get; set; }
        /// <summary> The time this backup was taken, formatted like 2021-01-21T17:35:21. </summary>
        public DateTimeOffset? BackupResourceTimestamp
        {
            get => Properties is null ? default : Properties.Timestamp;
            set
            {
                if (Properties is null)
                    Properties = new BackupResourceProperties();
                Properties.Timestamp = value;
            }
        }
    }
}
