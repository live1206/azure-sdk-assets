// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The ip configuration for a container network interface. </summary>
    public partial class ContainerNetworkInterfaceIPConfiguration
    {
        /// <summary> Initializes a new instance of ContainerNetworkInterfaceIPConfiguration. </summary>
        internal ContainerNetworkInterfaceIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ContainerNetworkInterfaceIPConfiguration. </summary>
        /// <param name="name"> The name of the resource. This name can be used to access the resource. </param>
        /// <param name="containerNetworkInterfaceIPConfigurationType"> Sub Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The provisioning state of the container network interface IP configuration resource. </param>
        internal ContainerNetworkInterfaceIPConfiguration(string name, string containerNetworkInterfaceIPConfigurationType, ETag? etag, NetworkProvisioningState? provisioningState)
        {
            Name = name;
            ContainerNetworkInterfaceIpConfigurationType = containerNetworkInterfaceIPConfigurationType;
            ETag = etag;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource. This name can be used to access the resource. </summary>
        public string Name { get; }
        /// <summary> Sub Resource type. </summary>
        public string ContainerNetworkInterfaceIpConfigurationType { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The provisioning state of the container network interface IP configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}