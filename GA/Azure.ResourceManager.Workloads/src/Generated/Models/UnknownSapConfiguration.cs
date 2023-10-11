// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The UnknownSapConfiguration. </summary>
    internal partial class UnknownSapConfiguration : SapConfiguration
    {
        /// <summary> Initializes a new instance of UnknownSapConfiguration. </summary>
        /// <param name="configurationType"> The configuration Type. </param>
        internal UnknownSapConfiguration(SapConfigurationType configurationType) : base(configurationType)
        {
            ConfigurationType = configurationType;
        }
    }
}