// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Cassandra keyspace resource object. </summary>
    public partial class CassandraKeyspaceResourceInfo
    {
        /// <summary> Initializes a new instance of CassandraKeyspaceResourceInfo. </summary>
        /// <param name="keyspaceName"> Name of the Cosmos DB Cassandra keyspace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyspaceName"/> is null. </exception>
        public CassandraKeyspaceResourceInfo(string keyspaceName)
        {
            Argument.AssertNotNull(keyspaceName, nameof(keyspaceName));

            KeyspaceName = keyspaceName;
        }

        /// <summary> Name of the Cosmos DB Cassandra keyspace. </summary>
        public string KeyspaceName { get; set; }
    }
}