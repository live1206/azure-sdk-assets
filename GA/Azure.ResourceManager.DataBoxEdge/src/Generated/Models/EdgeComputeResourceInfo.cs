// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Compute infrastructure Resource. </summary>
    public partial class EdgeComputeResourceInfo
    {
        /// <summary> Initializes a new instance of EdgeComputeResourceInfo. </summary>
        /// <param name="processorCount"> Processor count. </param>
        /// <param name="memoryInGB"> Memory in GB. </param>
        public EdgeComputeResourceInfo(int processorCount, long memoryInGB)
        {
            ProcessorCount = processorCount;
            MemoryInGB = memoryInGB;
        }

        /// <summary> Processor count. </summary>
        public int ProcessorCount { get; set; }
        /// <summary> Memory in GB. </summary>
        public long MemoryInGB { get; set; }
    }
}