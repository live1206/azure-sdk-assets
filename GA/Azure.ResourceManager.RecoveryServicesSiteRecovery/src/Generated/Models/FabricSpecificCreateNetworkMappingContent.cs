// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Input details specific to fabrics during Network Mapping.
    /// Please note <see cref="FabricSpecificCreateNetworkMappingContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2ACreateNetworkMappingContent"/>, <see cref="VmmToAzureCreateNetworkMappingContent"/> and <see cref="VmmToVmmCreateNetworkMappingContent"/>.
    /// </summary>
    public abstract partial class FabricSpecificCreateNetworkMappingContent
    {
        /// <summary> Initializes a new instance of FabricSpecificCreateNetworkMappingContent. </summary>
        protected FabricSpecificCreateNetworkMappingContent()
        {
        }

        /// <summary> The instance type. </summary>
        internal string InstanceType { get; set; }
    }
}