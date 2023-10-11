// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The supported capabilities. </summary>
    public partial class ContainerSupportedCapabilities
    {
        /// <summary> Initializes a new instance of ContainerSupportedCapabilities. </summary>
        internal ContainerSupportedCapabilities()
        {
        }

        /// <summary> Initializes a new instance of ContainerSupportedCapabilities. </summary>
        /// <param name="maxMemoryInGB"> The maximum allowed memory request in GB. </param>
        /// <param name="maxCpu"> The maximum allowed CPU request in cores. </param>
        /// <param name="maxGpuCount"> The maximum allowed GPU count. </param>
        internal ContainerSupportedCapabilities(float? maxMemoryInGB, float? maxCpu, float? maxGpuCount)
        {
            MaxMemoryInGB = maxMemoryInGB;
            MaxCpu = maxCpu;
            MaxGpuCount = maxGpuCount;
        }

        /// <summary> The maximum allowed memory request in GB. </summary>
        public float? MaxMemoryInGB { get; }
        /// <summary> The maximum allowed CPU request in cores. </summary>
        public float? MaxCpu { get; }
        /// <summary> The maximum allowed GPU count. </summary>
        public float? MaxGpuCount { get; }
    }
}