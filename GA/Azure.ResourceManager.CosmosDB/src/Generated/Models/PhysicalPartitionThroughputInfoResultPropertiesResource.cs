// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> properties of physical partition throughput info. </summary>
    internal partial class PhysicalPartitionThroughputInfoResultPropertiesResource : PhysicalPartitionThroughputInfoProperties
    {
        /// <summary> Initializes a new instance of PhysicalPartitionThroughputInfoResultPropertiesResource. </summary>
        public PhysicalPartitionThroughputInfoResultPropertiesResource()
        {
        }

        /// <summary> Initializes a new instance of PhysicalPartitionThroughputInfoResultPropertiesResource. </summary>
        /// <param name="physicalPartitionThroughputInfo"> Array of physical partition throughput info objects. </param>
        internal PhysicalPartitionThroughputInfoResultPropertiesResource(IList<PhysicalPartitionThroughputInfoResource> physicalPartitionThroughputInfo) : base(physicalPartitionThroughputInfo)
        {
        }
    }
}