// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of a virtual machine that determine how it is connected to a load balancer. </summary>
    internal partial class SharedPublicIPAddressConfiguration
    {
        /// <summary> Initializes a new instance of SharedPublicIPAddressConfiguration. </summary>
        public SharedPublicIPAddressConfiguration()
        {
            InboundNatRules = new ChangeTrackingList<DevTestLabInboundNatRule>();
        }

        /// <summary> Initializes a new instance of SharedPublicIPAddressConfiguration. </summary>
        /// <param name="inboundNatRules"> The incoming NAT rules. </param>
        internal SharedPublicIPAddressConfiguration(IList<DevTestLabInboundNatRule> inboundNatRules)
        {
            InboundNatRules = inboundNatRules;
        }

        /// <summary> The incoming NAT rules. </summary>
        public IList<DevTestLabInboundNatRule> InboundNatRules { get; }
    }
}