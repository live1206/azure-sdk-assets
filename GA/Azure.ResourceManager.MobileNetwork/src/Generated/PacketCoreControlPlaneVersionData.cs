// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the PacketCoreControlPlaneVersion data model.
    /// Packet core control plane version resource.
    /// </summary>
    public partial class PacketCoreControlPlaneVersionData : ResourceData
    {
        /// <summary> Initializes a new instance of PacketCoreControlPlaneVersionData. </summary>
        public PacketCoreControlPlaneVersionData()
        {
            Platforms = new ChangeTrackingList<MobileNetworkPlatform>();
        }

        /// <summary> Initializes a new instance of PacketCoreControlPlaneVersionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the packet core control plane version resource. </param>
        /// <param name="platforms"> Platform specific packet core control plane version properties. </param>
        internal PacketCoreControlPlaneVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MobileNetworkProvisioningState? provisioningState, IList<MobileNetworkPlatform> platforms) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            Platforms = platforms;
        }

        /// <summary> The provisioning state of the packet core control plane version resource. </summary>
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Platform specific packet core control plane version properties. </summary>
        public IList<MobileNetworkPlatform> Platforms { get; }
    }
}