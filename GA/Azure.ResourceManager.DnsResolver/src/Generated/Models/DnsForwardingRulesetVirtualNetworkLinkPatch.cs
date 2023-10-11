// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> Describes a virtual network link for PATCH operation. </summary>
    public partial class DnsForwardingRulesetVirtualNetworkLinkPatch
    {
        /// <summary> Initializes a new instance of DnsForwardingRulesetVirtualNetworkLinkPatch. </summary>
        public DnsForwardingRulesetVirtualNetworkLinkPatch()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Metadata attached to the virtual network link. </summary>
        public IDictionary<string, string> Metadata { get; }
    }
}