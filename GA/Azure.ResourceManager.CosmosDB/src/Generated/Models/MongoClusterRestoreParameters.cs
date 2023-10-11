// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters used for restore operations. </summary>
    public partial class MongoClusterRestoreParameters
    {
        /// <summary> Initializes a new instance of MongoClusterRestoreParameters. </summary>
        public MongoClusterRestoreParameters()
        {
        }

        /// <summary> Initializes a new instance of MongoClusterRestoreParameters. </summary>
        /// <param name="pointInTimeUTC"> UTC point in time to restore a mongo cluster. </param>
        /// <param name="sourceResourceId"> Resource ID to locate the source cluster to restore. </param>
        internal MongoClusterRestoreParameters(DateTimeOffset? pointInTimeUTC, string sourceResourceId)
        {
            PointInTimeUTC = pointInTimeUTC;
            SourceResourceId = sourceResourceId;
        }

        /// <summary> UTC point in time to restore a mongo cluster. </summary>
        public DateTimeOffset? PointInTimeUTC { get; set; }
        /// <summary> Resource ID to locate the source cluster to restore. </summary>
        public string SourceResourceId { get; set; }
    }
}