// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> A rule governing the accessibility from a specific virtual network. </summary>
    public partial class CognitiveServicesVirtualNetworkRule
    {
        /// <summary> Initializes a new instance of CognitiveServicesVirtualNetworkRule. </summary>
        /// <param name="id"> Full resource id of a vnet subnet, such as '/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public CognitiveServicesVirtualNetworkRule(ResourceIdentifier id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of CognitiveServicesVirtualNetworkRule. </summary>
        /// <param name="id"> Full resource id of a vnet subnet, such as '/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1'. </param>
        /// <param name="state"> Gets the state of virtual network rule. </param>
        /// <param name="ignoreMissingVnetServiceEndpoint"> Ignore missing vnet service endpoint or not. </param>
        internal CognitiveServicesVirtualNetworkRule(ResourceIdentifier id, string state, bool? ignoreMissingVnetServiceEndpoint)
        {
            Id = id;
            State = state;
            IgnoreMissingVnetServiceEndpoint = ignoreMissingVnetServiceEndpoint;
        }

        /// <summary> Full resource id of a vnet subnet, such as '/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1'. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Gets the state of virtual network rule. </summary>
        public string State { get; set; }
        /// <summary> Ignore missing vnet service endpoint or not. </summary>
        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
    }
}