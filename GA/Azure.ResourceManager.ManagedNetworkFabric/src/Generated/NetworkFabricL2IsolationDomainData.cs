// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricL2IsolationDomain data model.
    /// The L2 Isolation Domain resource definition.
    /// </summary>
    public partial class NetworkFabricL2IsolationDomainData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkFabricL2IsolationDomainData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="networkFabricId"> ARM Resource ID of the Network Fabric. </param>
        /// <param name="vlanId"> Vlan Identifier of the Network Fabric. Example: 501. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricId"/> is null. </exception>
        public NetworkFabricL2IsolationDomainData(AzureLocation location, ResourceIdentifier networkFabricId, int vlanId) : base(location)
        {
            Argument.AssertNotNull(networkFabricId, nameof(networkFabricId));

            NetworkFabricId = networkFabricId;
            VlanId = vlanId;
        }

        /// <summary> Initializes a new instance of NetworkFabricL2IsolationDomainData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="networkFabricId"> ARM Resource ID of the Network Fabric. </param>
        /// <param name="vlanId"> Vlan Identifier of the Network Fabric. Example: 501. </param>
        /// <param name="mtu"> Maximum transmission unit. Default value is 1500. </param>
        /// <param name="configurationState"> Configuration state of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="administrativeState"> Administrative state of the resource. </param>
        internal NetworkFabricL2IsolationDomainData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, ResourceIdentifier networkFabricId, int vlanId, int? mtu, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            NetworkFabricId = networkFabricId;
            VlanId = vlanId;
            Mtu = mtu;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> ARM Resource ID of the Network Fabric. </summary>
        public ResourceIdentifier NetworkFabricId { get; set; }
        /// <summary> Vlan Identifier of the Network Fabric. Example: 501. </summary>
        public int VlanId { get; set; }
        /// <summary> Maximum transmission unit. Default value is 1500. </summary>
        public int? Mtu { get; set; }
        /// <summary> Configuration state of the resource. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> Administrative state of the resource. </summary>
        public NetworkFabricAdministrativeState? AdministrativeState { get; }
    }
}