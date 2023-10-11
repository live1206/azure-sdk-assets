// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the PacketCoreDataPlane data model.
    /// Packet core data plane resource. Must be created in the same location as its parent packet core control plane.
    /// </summary>
    public partial class PacketCoreDataPlaneData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of PacketCoreDataPlaneData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="userPlaneAccessInterface"> The user plane interface on the access network. For 5G networks, this is the N3 interface. For 4G networks, this is the S1-U interface. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userPlaneAccessInterface"/> is null. </exception>
        public PacketCoreDataPlaneData(AzureLocation location, MobileNetworkInterfaceProperties userPlaneAccessInterface) : base(location)
        {
            Argument.AssertNotNull(userPlaneAccessInterface, nameof(userPlaneAccessInterface));

            UserPlaneAccessInterface = userPlaneAccessInterface;
        }

        /// <summary> Initializes a new instance of PacketCoreDataPlaneData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the packet core data plane resource. </param>
        /// <param name="userPlaneAccessInterface"> The user plane interface on the access network. For 5G networks, this is the N3 interface. For 4G networks, this is the S1-U interface. </param>
        internal PacketCoreDataPlaneData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MobileNetworkProvisioningState? provisioningState, MobileNetworkInterfaceProperties userPlaneAccessInterface) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            UserPlaneAccessInterface = userPlaneAccessInterface;
        }

        /// <summary> The provisioning state of the packet core data plane resource. </summary>
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The user plane interface on the access network. For 5G networks, this is the N3 interface. For 4G networks, this is the S1-U interface. </summary>
        public MobileNetworkInterfaceProperties UserPlaneAccessInterface { get; set; }
    }
}