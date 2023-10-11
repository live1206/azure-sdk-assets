// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The resource requests. </summary>
    public partial class ContainerResourceRequestsContent
    {
        /// <summary> Initializes a new instance of ContainerResourceRequestsContent. </summary>
        /// <param name="memoryInGB"> The memory request in GB of this container instance. </param>
        /// <param name="cpu"> The CPU request of this container instance. </param>
        public ContainerResourceRequestsContent(double memoryInGB, double cpu)
        {
            MemoryInGB = memoryInGB;
            Cpu = cpu;
        }

        /// <summary> Initializes a new instance of ContainerResourceRequestsContent. </summary>
        /// <param name="memoryInGB"> The memory request in GB of this container instance. </param>
        /// <param name="cpu"> The CPU request of this container instance. </param>
        /// <param name="gpu"> The GPU request of this container instance. </param>
        internal ContainerResourceRequestsContent(double memoryInGB, double cpu, ContainerGpuResourceInfo gpu)
        {
            MemoryInGB = memoryInGB;
            Cpu = cpu;
            Gpu = gpu;
        }

        /// <summary> The memory request in GB of this container instance. </summary>
        public double MemoryInGB { get; set; }
        /// <summary> The CPU request of this container instance. </summary>
        public double Cpu { get; set; }
        /// <summary> The GPU request of this container instance. </summary>
        public ContainerGpuResourceInfo Gpu { get; set; }
    }
}
