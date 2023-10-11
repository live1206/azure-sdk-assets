// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Managed Resource Group configuration properties. </summary>
    public partial class ManagedResourceGroupConfiguration
    {
        /// <summary> Initializes a new instance of ManagedResourceGroupConfiguration. </summary>
        public ManagedResourceGroupConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ManagedResourceGroupConfiguration. </summary>
        /// <param name="name"> The NFC service will be hosted in a Managed resource group. </param>
        /// <param name="location"> Managed resource group location. </param>
        internal ManagedResourceGroupConfiguration(string name, AzureLocation? location)
        {
            Name = name;
            Location = location;
        }

        /// <summary> The NFC service will be hosted in a Managed resource group. </summary>
        public string Name { get; set; }
        /// <summary> Managed resource group location. </summary>
        public AzureLocation? Location { get; set; }
    }
}