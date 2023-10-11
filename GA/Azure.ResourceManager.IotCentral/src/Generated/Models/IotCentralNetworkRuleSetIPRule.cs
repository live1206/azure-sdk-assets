// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> An object for an IP range that will be allowed access. </summary>
    public partial class IotCentralNetworkRuleSetIPRule
    {
        /// <summary> Initializes a new instance of IotCentralNetworkRuleSetIPRule. </summary>
        public IotCentralNetworkRuleSetIPRule()
        {
        }

        /// <summary> Initializes a new instance of IotCentralNetworkRuleSetIPRule. </summary>
        /// <param name="filterName"> The readable name of the IP rule. </param>
        /// <param name="ipMask"> The CIDR block defining the IP range. </param>
        internal IotCentralNetworkRuleSetIPRule(string filterName, string ipMask)
        {
            FilterName = filterName;
            IPMask = ipMask;
        }

        /// <summary> The readable name of the IP rule. </summary>
        public string FilterName { get; set; }
        /// <summary> The CIDR block defining the IP range. </summary>
        public string IPMask { get; set; }
    }
}