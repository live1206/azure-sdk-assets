// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A system service running on a compute. </summary>
    public partial class MachineLearningComputeSystemService
    {
        /// <summary> Initializes a new instance of MachineLearningComputeSystemService. </summary>
        internal MachineLearningComputeSystemService()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningComputeSystemService. </summary>
        /// <param name="systemServiceType"> The type of this system service. </param>
        /// <param name="publicIPAddress"> Public IP address. </param>
        /// <param name="version"> The version for this type. </param>
        internal MachineLearningComputeSystemService(string systemServiceType, string publicIPAddress, string version)
        {
            SystemServiceType = systemServiceType;
            PublicIPAddress = publicIPAddress;
            Version = version;
        }

        /// <summary> The type of this system service. </summary>
        public string SystemServiceType { get; }
        /// <summary> Public IP address. </summary>
        public string PublicIPAddress { get; }
        /// <summary> The version for this type. </summary>
        public string Version { get; }
    }
}