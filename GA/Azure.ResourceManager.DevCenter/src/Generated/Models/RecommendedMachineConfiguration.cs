// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Properties for a recommended machine configuration. </summary>
    public partial class RecommendedMachineConfiguration
    {
        /// <summary> Initializes a new instance of RecommendedMachineConfiguration. </summary>
        internal RecommendedMachineConfiguration()
        {
        }

        /// <summary> Initializes a new instance of RecommendedMachineConfiguration. </summary>
        /// <param name="memory"> Recommended memory range. </param>
        /// <param name="vCpus"> Recommended vCPU range. </param>
        internal RecommendedMachineConfiguration(DevCenterResourceRange memory, DevCenterResourceRange vCpus)
        {
            Memory = memory;
            VCpus = vCpus;
        }

        /// <summary> Recommended memory range. </summary>
        public DevCenterResourceRange Memory { get; }
        /// <summary> Recommended vCPU range. </summary>
        public DevCenterResourceRange VCpus { get; }
    }
}