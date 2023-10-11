// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Cassandra table schema. </summary>
    public partial class CassandraSchema
    {
        /// <summary> Initializes a new instance of CassandraSchema. </summary>
        public CassandraSchema()
        {
            Columns = new ChangeTrackingList<CassandraColumn>();
            PartitionKeys = new ChangeTrackingList<CassandraPartitionKey>();
            ClusterKeys = new ChangeTrackingList<CassandraClusterKey>();
        }

        /// <summary> Initializes a new instance of CassandraSchema. </summary>
        /// <param name="columns"> List of Cassandra table columns. </param>
        /// <param name="partitionKeys"> List of partition key. </param>
        /// <param name="clusterKeys"> List of cluster key. </param>
        internal CassandraSchema(IList<CassandraColumn> columns, IList<CassandraPartitionKey> partitionKeys, IList<CassandraClusterKey> clusterKeys)
        {
            Columns = columns;
            PartitionKeys = partitionKeys;
            ClusterKeys = clusterKeys;
        }

        /// <summary> List of Cassandra table columns. </summary>
        public IList<CassandraColumn> Columns { get; }
        /// <summary> List of partition key. </summary>
        public IList<CassandraPartitionKey> PartitionKeys { get; }
        /// <summary> List of cluster key. </summary>
        public IList<CassandraClusterKey> ClusterKeys { get; }
    }
}