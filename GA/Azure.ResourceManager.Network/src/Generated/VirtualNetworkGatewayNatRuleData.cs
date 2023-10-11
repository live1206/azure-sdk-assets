// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the VirtualNetworkGatewayNatRule data model.
    /// VirtualNetworkGatewayNatRule Resource.
    /// </summary>
    public partial class VirtualNetworkGatewayNatRuleData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of VirtualNetworkGatewayNatRuleData. </summary>
        public VirtualNetworkGatewayNatRuleData()
        {
            InternalMappings = new ChangeTrackingList<VpnNatRuleMapping>();
            ExternalMappings = new ChangeTrackingList<VpnNatRuleMapping>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayNatRuleData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The provisioning state of the NAT Rule resource. </param>
        /// <param name="vpnNatRuleType"> The type of NAT rule for VPN NAT. </param>
        /// <param name="mode"> The Source NAT direction of a VPN NAT. </param>
        /// <param name="internalMappings"> The private IP address internal mapping for NAT. </param>
        /// <param name="externalMappings"> The private IP address external mapping for NAT. </param>
        /// <param name="ipConfigurationId"> The IP Configuration ID this NAT rule applies to. </param>
        internal VirtualNetworkGatewayNatRuleData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, NetworkProvisioningState? provisioningState, VpnNatRuleType? vpnNatRuleType, VpnNatRuleMode? mode, IList<VpnNatRuleMapping> internalMappings, IList<VpnNatRuleMapping> externalMappings, string ipConfigurationId) : base(id, name, resourceType)
        {
            ETag = etag;
            ProvisioningState = provisioningState;
            VpnNatRuleType = vpnNatRuleType;
            Mode = mode;
            InternalMappings = internalMappings;
            ExternalMappings = externalMappings;
            IPConfigurationId = ipConfigurationId;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The provisioning state of the NAT Rule resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The type of NAT rule for VPN NAT. </summary>
        public VpnNatRuleType? VpnNatRuleType { get; set; }
        /// <summary> The Source NAT direction of a VPN NAT. </summary>
        public VpnNatRuleMode? Mode { get; set; }
        /// <summary> The private IP address internal mapping for NAT. </summary>
        public IList<VpnNatRuleMapping> InternalMappings { get; }
        /// <summary> The private IP address external mapping for NAT. </summary>
        public IList<VpnNatRuleMapping> ExternalMappings { get; }
        /// <summary> The IP Configuration ID this NAT rule applies to. </summary>
        public string IPConfigurationId { get; set; }
    }
}