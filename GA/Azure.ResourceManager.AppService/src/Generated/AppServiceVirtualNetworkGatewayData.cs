// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AppServiceVirtualNetworkGateway data model.
    /// The Virtual Network gateway contract. This is used to give the Virtual Network gateway access to the VPN package.
    /// </summary>
    public partial class AppServiceVirtualNetworkGatewayData : ResourceData
    {
        /// <summary> Initializes a new instance of AppServiceVirtualNetworkGatewayData. </summary>
        public AppServiceVirtualNetworkGatewayData()
        {
        }

        /// <summary> Initializes a new instance of AppServiceVirtualNetworkGatewayData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vnetName"> The Virtual Network name. </param>
        /// <param name="vpnPackageUri"> The URI where the VPN package can be downloaded. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal AppServiceVirtualNetworkGatewayData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string vnetName, Uri vpnPackageUri, string kind) : base(id, name, resourceType, systemData)
        {
            VnetName = vnetName;
            VpnPackageUri = vpnPackageUri;
            Kind = kind;
        }

        /// <summary> The Virtual Network name. </summary>
        public string VnetName { get; set; }
        /// <summary> The URI where the VPN package can be downloaded. </summary>
        public Uri VpnPackageUri { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
