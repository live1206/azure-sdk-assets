// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> E2A Network Mapping fabric specific settings. </summary>
    public partial class VmmToAzureNetworkMappingSettings : NetworkMappingFabricSpecificSettings
    {
        /// <summary> Initializes a new instance of VmmToAzureNetworkMappingSettings. </summary>
        internal VmmToAzureNetworkMappingSettings()
        {
            InstanceType = "VmmToAzure";
        }

        /// <summary> Initializes a new instance of VmmToAzureNetworkMappingSettings. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        internal VmmToAzureNetworkMappingSettings(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "VmmToAzure";
        }
    }
}