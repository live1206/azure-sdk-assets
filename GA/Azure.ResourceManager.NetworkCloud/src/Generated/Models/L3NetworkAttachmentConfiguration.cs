// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> L3NetworkAttachmentConfiguration represents the configuration of the attachment of a Layer 3 network. </summary>
    public partial class L3NetworkAttachmentConfiguration
    {
        /// <summary> Initializes a new instance of L3NetworkAttachmentConfiguration. </summary>
        /// <param name="networkId"> The resource ID of the network that is being configured for attachment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkId"/> is null. </exception>
        public L3NetworkAttachmentConfiguration(ResourceIdentifier networkId)
        {
            Argument.AssertNotNull(networkId, nameof(networkId));

            NetworkId = networkId;
        }

        /// <summary> Initializes a new instance of L3NetworkAttachmentConfiguration. </summary>
        /// <param name="ipamEnabled"> The indication of whether this network will or will not perform IP address management and allocate IP addresses when attached. </param>
        /// <param name="networkId"> The resource ID of the network that is being configured for attachment. </param>
        /// <param name="pluginType"> The indicator of how this network will be utilized by the Kubernetes cluster. </param>
        internal L3NetworkAttachmentConfiguration(L3NetworkConfigurationIpamEnabled? ipamEnabled, ResourceIdentifier networkId, KubernetesPluginType? pluginType)
        {
            IpamEnabled = ipamEnabled;
            NetworkId = networkId;
            PluginType = pluginType;
        }

        /// <summary> The indication of whether this network will or will not perform IP address management and allocate IP addresses when attached. </summary>
        public L3NetworkConfigurationIpamEnabled? IpamEnabled { get; set; }
        /// <summary> The resource ID of the network that is being configured for attachment. </summary>
        public ResourceIdentifier NetworkId { get; set; }
        /// <summary> The indicator of how this network will be utilized by the Kubernetes cluster. </summary>
        public KubernetesPluginType? PluginType { get; set; }
    }
}