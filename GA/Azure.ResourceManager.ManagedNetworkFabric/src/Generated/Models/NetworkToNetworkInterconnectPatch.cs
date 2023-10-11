// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The Network To Network Interconnect resource patch definition. </summary>
    public partial class NetworkToNetworkInterconnectPatch : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkToNetworkInterconnectPatch. </summary>
        public NetworkToNetworkInterconnectPatch()
        {
        }

        /// <summary> Initializes a new instance of NetworkToNetworkInterconnectPatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="layer2Configuration"> Common properties for Layer2Configuration. </param>
        /// <param name="optionBLayer3Configuration"> Common properties for Layer3Configuration. </param>
        /// <param name="npbStaticRouteConfiguration"> NPB Static Route Configuration properties. </param>
        /// <param name="importRoutePolicy"> Import Route Policy information. </param>
        /// <param name="exportRoutePolicy"> Export Route Policy information. </param>
        /// <param name="egressAclId"> Egress Acl. ARM resource ID of Access Control Lists. </param>
        /// <param name="ingressAclId"> Ingress Acl. ARM resource ID of Access Control Lists. </param>
        internal NetworkToNetworkInterconnectPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Layer2Configuration layer2Configuration, OptionBLayer3Configuration optionBLayer3Configuration, NpbStaticRouteConfiguration npbStaticRouteConfiguration, ImportRoutePolicyInformation importRoutePolicy, ExportRoutePolicyInformation exportRoutePolicy, ResourceIdentifier egressAclId, ResourceIdentifier ingressAclId) : base(id, name, resourceType, systemData)
        {
            Layer2Configuration = layer2Configuration;
            OptionBLayer3Configuration = optionBLayer3Configuration;
            NpbStaticRouteConfiguration = npbStaticRouteConfiguration;
            ImportRoutePolicy = importRoutePolicy;
            ExportRoutePolicy = exportRoutePolicy;
            EgressAclId = egressAclId;
            IngressAclId = ingressAclId;
        }

        /// <summary> Common properties for Layer2Configuration. </summary>
        public Layer2Configuration Layer2Configuration { get; set; }
        /// <summary> Common properties for Layer3Configuration. </summary>
        public OptionBLayer3Configuration OptionBLayer3Configuration { get; set; }
        /// <summary> NPB Static Route Configuration properties. </summary>
        public NpbStaticRouteConfiguration NpbStaticRouteConfiguration { get; set; }
        /// <summary> Import Route Policy information. </summary>
        public ImportRoutePolicyInformation ImportRoutePolicy { get; set; }
        /// <summary> Export Route Policy information. </summary>
        public ExportRoutePolicyInformation ExportRoutePolicy { get; set; }
        /// <summary> Egress Acl. ARM resource ID of Access Control Lists. </summary>
        public ResourceIdentifier EgressAclId { get; set; }
        /// <summary> Ingress Acl. ARM resource ID of Access Control Lists. </summary>
        public ResourceIdentifier IngressAclId { get; set; }
    }
}