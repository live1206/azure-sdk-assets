// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Describes remote addresses that is recommended to communicate with the Azure resource on some (Protocol, Port, Direction). All other remote addresses are recommended to be blocked. </summary>
    public partial class RecommendedSecurityRule
    {
        /// <summary> Initializes a new instance of RecommendedSecurityRule. </summary>
        public RecommendedSecurityRule()
        {
            Protocols = new ChangeTrackingList<SecurityTransportProtocol>();
            IPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RecommendedSecurityRule. </summary>
        /// <param name="name"> The name of the rule. </param>
        /// <param name="direction"> The rule's direction. </param>
        /// <param name="destinationPort"> The rule's destination port. </param>
        /// <param name="protocols"> The rule's transport protocols. </param>
        /// <param name="ipAddresses"> The remote IP addresses that should be able to communicate with the Azure resource on the rule's destination port and protocol. </param>
        internal RecommendedSecurityRule(string name, SecurityTrafficDirection? direction, int? destinationPort, IList<SecurityTransportProtocol> protocols, IList<string> ipAddresses)
        {
            Name = name;
            Direction = direction;
            DestinationPort = destinationPort;
            Protocols = protocols;
            IPAddresses = ipAddresses;
        }

        /// <summary> The name of the rule. </summary>
        public string Name { get; set; }
        /// <summary> The rule's direction. </summary>
        public SecurityTrafficDirection? Direction { get; set; }
        /// <summary> The rule's destination port. </summary>
        public int? DestinationPort { get; set; }
        /// <summary> The rule's transport protocols. </summary>
        public IList<SecurityTransportProtocol> Protocols { get; }
        /// <summary> The remote IP addresses that should be able to communicate with the Azure resource on the rule's destination port and protocol. </summary>
        public IList<string> IPAddresses { get; }
    }
}