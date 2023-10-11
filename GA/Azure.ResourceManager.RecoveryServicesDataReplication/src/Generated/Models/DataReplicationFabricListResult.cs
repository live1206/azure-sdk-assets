// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Fabric model collection. </summary>
    internal partial class DataReplicationFabricListResult
    {
        /// <summary> Initializes a new instance of DataReplicationFabricListResult. </summary>
        internal DataReplicationFabricListResult()
        {
            Value = new ChangeTrackingList<DataReplicationFabricData>();
        }

        /// <summary> Initializes a new instance of DataReplicationFabricListResult. </summary>
        /// <param name="value"> Gets or sets the list of fabrics. </param>
        /// <param name="nextLink"> Gets or sets the value of next link. </param>
        internal DataReplicationFabricListResult(IReadOnlyList<DataReplicationFabricData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets the list of fabrics. </summary>
        public IReadOnlyList<DataReplicationFabricData> Value { get; }
        /// <summary> Gets or sets the value of next link. </summary>
        public string NextLink { get; }
    }
}