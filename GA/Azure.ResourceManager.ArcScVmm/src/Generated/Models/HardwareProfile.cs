// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Defines the resource properties. </summary>
    public partial class HardwareProfile
    {
        /// <summary> Initializes a new instance of HardwareProfile. </summary>
        public HardwareProfile()
        {
        }

        /// <summary> Initializes a new instance of HardwareProfile. </summary>
        /// <param name="memoryMB"> MemoryMB is the size of a virtual machine's memory, in MB. </param>
        /// <param name="cpuCount"> Gets or sets the number of vCPUs for the vm. </param>
        /// <param name="limitCpuForMigration"> Gets or sets a value indicating whether to enable processor compatibility mode for live migration of VMs. </param>
        /// <param name="dynamicMemoryEnabled"> Gets or sets a value indicating whether to enable dynamic memory or not. </param>
        /// <param name="dynamicMemoryMaxMB"> Gets or sets the max dynamic memory for the vm. </param>
        /// <param name="dynamicMemoryMinMB"> Gets or sets the min dynamic memory for the vm. </param>
        /// <param name="isHighlyAvailable"> Gets highly available property. </param>
        internal HardwareProfile(int? memoryMB, int? cpuCount, LimitCpuForMigration? limitCpuForMigration, DynamicMemoryEnabled? dynamicMemoryEnabled, int? dynamicMemoryMaxMB, int? dynamicMemoryMinMB, string isHighlyAvailable)
        {
            MemoryMB = memoryMB;
            CpuCount = cpuCount;
            LimitCpuForMigration = limitCpuForMigration;
            DynamicMemoryEnabled = dynamicMemoryEnabled;
            DynamicMemoryMaxMB = dynamicMemoryMaxMB;
            DynamicMemoryMinMB = dynamicMemoryMinMB;
            IsHighlyAvailable = isHighlyAvailable;
        }

        /// <summary> MemoryMB is the size of a virtual machine's memory, in MB. </summary>
        public int? MemoryMB { get; set; }
        /// <summary> Gets or sets the number of vCPUs for the vm. </summary>
        public int? CpuCount { get; set; }
        /// <summary> Gets or sets a value indicating whether to enable processor compatibility mode for live migration of VMs. </summary>
        public LimitCpuForMigration? LimitCpuForMigration { get; set; }
        /// <summary> Gets or sets a value indicating whether to enable dynamic memory or not. </summary>
        public DynamicMemoryEnabled? DynamicMemoryEnabled { get; set; }
        /// <summary> Gets or sets the max dynamic memory for the vm. </summary>
        public int? DynamicMemoryMaxMB { get; set; }
        /// <summary> Gets or sets the min dynamic memory for the vm. </summary>
        public int? DynamicMemoryMinMB { get; set; }
        /// <summary> Gets highly available property. </summary>
        public string IsHighlyAvailable { get; set; }
    }
}