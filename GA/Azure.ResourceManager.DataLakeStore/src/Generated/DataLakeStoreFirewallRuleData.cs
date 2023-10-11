// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    /// <summary>
    /// A class representing the DataLakeStoreFirewallRule data model.
    /// Data Lake Store firewall rule information.
    /// </summary>
    public partial class DataLakeStoreFirewallRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of DataLakeStoreFirewallRuleData. </summary>
        internal DataLakeStoreFirewallRuleData()
        {
        }

        /// <summary> Initializes a new instance of DataLakeStoreFirewallRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startIPAddress"> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <param name="endIPAddress"> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        internal DataLakeStoreFirewallRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IPAddress startIPAddress, IPAddress endIPAddress) : base(id, name, resourceType, systemData)
        {
            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
        }

        /// <summary> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </summary>
        public IPAddress StartIPAddress { get; }
        /// <summary> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </summary>
        public IPAddress EndIPAddress { get; }
    }
}