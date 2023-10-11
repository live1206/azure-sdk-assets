// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the ExpressRouteCrossConnectionPeering data model.
    /// Peering in an ExpressRoute Cross Connection resource.
    /// </summary>
    public partial class ExpressRouteCrossConnectionPeeringData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionPeeringData. </summary>
        public ExpressRouteCrossConnectionPeeringData()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionPeeringData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="peeringType"> The peering type. </param>
        /// <param name="state"> The peering state. </param>
        /// <param name="azureASN"> The Azure ASN. </param>
        /// <param name="peerASN"> The peer ASN. </param>
        /// <param name="primaryPeerAddressPrefix"> The primary address prefix. </param>
        /// <param name="secondaryPeerAddressPrefix"> The secondary address prefix. </param>
        /// <param name="primaryAzurePort"> The primary port. </param>
        /// <param name="secondaryAzurePort"> The secondary port. </param>
        /// <param name="sharedKey"> The shared key. </param>
        /// <param name="vlanId"> The VLAN ID. </param>
        /// <param name="microsoftPeeringConfig"> The Microsoft peering configuration. </param>
        /// <param name="provisioningState"> The provisioning state of the express route cross connection peering resource. </param>
        /// <param name="gatewayManagerETag"> The GatewayManager Etag. </param>
        /// <param name="lastModifiedBy"> Who was the last to modify the peering. </param>
        /// <param name="ipv6PeeringConfig"> The IPv6 peering configuration. </param>
        internal ExpressRouteCrossConnectionPeeringData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, ExpressRoutePeeringType? peeringType, ExpressRoutePeeringState? state, int? azureASN, long? peerASN, string primaryPeerAddressPrefix, string secondaryPeerAddressPrefix, string primaryAzurePort, string secondaryAzurePort, string sharedKey, int? vlanId, ExpressRouteCircuitPeeringConfig microsoftPeeringConfig, NetworkProvisioningState? provisioningState, string gatewayManagerETag, string lastModifiedBy, IPv6ExpressRouteCircuitPeeringConfig ipv6PeeringConfig) : base(id, name, resourceType)
        {
            ETag = etag;
            PeeringType = peeringType;
            State = state;
            AzureASN = azureASN;
            PeerASN = peerASN;
            PrimaryPeerAddressPrefix = primaryPeerAddressPrefix;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            PrimaryAzurePort = primaryAzurePort;
            SecondaryAzurePort = secondaryAzurePort;
            SharedKey = sharedKey;
            VlanId = vlanId;
            MicrosoftPeeringConfig = microsoftPeeringConfig;
            ProvisioningState = provisioningState;
            GatewayManagerETag = gatewayManagerETag;
            LastModifiedBy = lastModifiedBy;
            IPv6PeeringConfig = ipv6PeeringConfig;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The peering type. </summary>
        public ExpressRoutePeeringType? PeeringType { get; set; }
        /// <summary> The peering state. </summary>
        public ExpressRoutePeeringState? State { get; set; }
        /// <summary> The Azure ASN. </summary>
        public int? AzureASN { get; }
        /// <summary> The peer ASN. </summary>
        public long? PeerASN { get; set; }
        /// <summary> The primary address prefix. </summary>
        public string PrimaryPeerAddressPrefix { get; set; }
        /// <summary> The secondary address prefix. </summary>
        public string SecondaryPeerAddressPrefix { get; set; }
        /// <summary> The primary port. </summary>
        public string PrimaryAzurePort { get; }
        /// <summary> The secondary port. </summary>
        public string SecondaryAzurePort { get; }
        /// <summary> The shared key. </summary>
        public string SharedKey { get; set; }
        /// <summary> The VLAN ID. </summary>
        public int? VlanId { get; set; }
        /// <summary> The Microsoft peering configuration. </summary>
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig { get; set; }
        /// <summary> The provisioning state of the express route cross connection peering resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The GatewayManager Etag. </summary>
        public string GatewayManagerETag { get; set; }
        /// <summary> Who was the last to modify the peering. </summary>
        public string LastModifiedBy { get; }
        /// <summary> The IPv6 peering configuration. </summary>
        public IPv6ExpressRouteCircuitPeeringConfig IPv6PeeringConfig { get; set; }
    }
}