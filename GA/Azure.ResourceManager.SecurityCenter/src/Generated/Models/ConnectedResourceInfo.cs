// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Describes properties of a connected resource. </summary>
    public partial class ConnectedResourceInfo
    {
        /// <summary> Initializes a new instance of ConnectedResourceInfo. </summary>
        internal ConnectedResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of ConnectedResourceInfo. </summary>
        /// <param name="connectedResourceId"> The Azure resource id of the connected resource. </param>
        /// <param name="tcpPorts"> The allowed tcp ports. </param>
        /// <param name="udpPorts"> The allowed udp ports. </param>
        internal ConnectedResourceInfo(ResourceIdentifier connectedResourceId, string tcpPorts, string udpPorts)
        {
            ConnectedResourceId = connectedResourceId;
            TcpPorts = tcpPorts;
            UdpPorts = udpPorts;
        }

        /// <summary> The Azure resource id of the connected resource. </summary>
        public ResourceIdentifier ConnectedResourceId { get; }
        /// <summary> The allowed tcp ports. </summary>
        public string TcpPorts { get; }
        /// <summary> The allowed udp ports. </summary>
        public string UdpPorts { get; }
    }
}