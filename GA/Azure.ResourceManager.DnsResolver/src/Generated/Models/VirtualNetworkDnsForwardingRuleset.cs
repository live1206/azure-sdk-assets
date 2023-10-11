// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> Reference to DNS forwarding ruleset and associated virtual network link. </summary>
    public partial class VirtualNetworkDnsForwardingRuleset
    {
        /// <summary> Initializes a new instance of VirtualNetworkDnsForwardingRuleset. </summary>
        internal VirtualNetworkDnsForwardingRuleset()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkDnsForwardingRuleset. </summary>
        /// <param name="id"> DNS Forwarding Ruleset Resource ID. </param>
        /// <param name="virtualNetworkLink"> The reference to the virtual network link. </param>
        internal VirtualNetworkDnsForwardingRuleset(ResourceIdentifier id, WritableSubResource virtualNetworkLink)
        {
            Id = id;
            VirtualNetworkLink = virtualNetworkLink;
        }

        /// <summary> DNS Forwarding Ruleset Resource ID. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> The reference to the virtual network link. </summary>
        internal WritableSubResource VirtualNetworkLink { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualNetworkLinkId
        {
            get => VirtualNetworkLink?.Id;
        }
    }
}