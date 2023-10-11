// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedCassandraKeyspaceResourceInfo. </summary>
    public partial class ExtendedCassandraKeyspaceResourceInfo : CassandraKeyspaceResourceInfo
    {
        /// <summary> Initializes a new instance of ExtendedCassandraKeyspaceResourceInfo. </summary>
        /// <param name="keyspaceName"> Name of the Cosmos DB Cassandra keyspace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyspaceName"/> is null. </exception>
        public ExtendedCassandraKeyspaceResourceInfo(string keyspaceName) : base(keyspaceName)
        {
            Argument.AssertNotNull(keyspaceName, nameof(keyspaceName));
        }

        /// <summary> Initializes a new instance of ExtendedCassandraKeyspaceResourceInfo. </summary>
        /// <param name="keyspaceName"> Name of the Cosmos DB Cassandra keyspace. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyspaceName"/> is null. </exception>
        internal ExtendedCassandraKeyspaceResourceInfo(string keyspaceName, string rid, float? timestamp, ETag? etag) : base(keyspaceName)
        {
            Argument.AssertNotNull(keyspaceName, nameof(keyspaceName));

            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}