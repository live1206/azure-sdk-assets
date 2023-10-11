// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Cassandra table resource object. </summary>
    public partial class CassandraTableResourceInfo
    {
        /// <summary> Initializes a new instance of CassandraTableResourceInfo. </summary>
        /// <param name="tableName"> Name of the Cosmos DB Cassandra table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public CassandraTableResourceInfo(string tableName)
        {
            Argument.AssertNotNull(tableName, nameof(tableName));

            TableName = tableName;
        }

        /// <summary> Initializes a new instance of CassandraTableResourceInfo. </summary>
        /// <param name="tableName"> Name of the Cosmos DB Cassandra table. </param>
        /// <param name="defaultTtl"> Time to live of the Cosmos DB Cassandra table. </param>
        /// <param name="schema"> Schema of the Cosmos DB Cassandra table. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        internal CassandraTableResourceInfo(string tableName, int? defaultTtl, CassandraSchema schema, int? analyticalStorageTtl)
        {
            TableName = tableName;
            DefaultTtl = defaultTtl;
            Schema = schema;
            AnalyticalStorageTtl = analyticalStorageTtl;
        }

        /// <summary> Name of the Cosmos DB Cassandra table. </summary>
        public string TableName { get; set; }
        /// <summary> Time to live of the Cosmos DB Cassandra table. </summary>
        public int? DefaultTtl { get; set; }
        /// <summary> Schema of the Cosmos DB Cassandra table. </summary>
        public CassandraSchema Schema { get; set; }
        /// <summary> Analytical TTL. </summary>
        public int? AnalyticalStorageTtl { get; set; }
    }
}
