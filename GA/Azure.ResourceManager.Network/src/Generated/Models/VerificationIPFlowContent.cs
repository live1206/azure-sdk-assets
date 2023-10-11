// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the IP flow to be verified. </summary>
    public partial class VerificationIPFlowContent
    {
        /// <summary> Initializes a new instance of VerificationIPFlowContent. </summary>
        /// <param name="targetResourceId"> The ID of the target resource to perform next-hop on. </param>
        /// <param name="direction"> The direction of the packet represented as a 5-tuple. </param>
        /// <param name="protocol"> Protocol to be verified on. </param>
        /// <param name="localPort"> The local port. Acceptable values are a single integer in the range (0-65535). Support for * for the source port, which depends on the direction. </param>
        /// <param name="remotePort"> The remote port. Acceptable values are a single integer in the range (0-65535). Support for * for the source port, which depends on the direction. </param>
        /// <param name="localIPAddress"> The local IP address. Acceptable values are valid IPv4 addresses. </param>
        /// <param name="remoteIPAddress"> The remote IP address. Acceptable values are valid IPv4 addresses. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/>, <paramref name="localPort"/>, <paramref name="remotePort"/>, <paramref name="localIPAddress"/> or <paramref name="remoteIPAddress"/> is null. </exception>
        public VerificationIPFlowContent(ResourceIdentifier targetResourceId, NetworkTrafficDirection direction, IPFlowProtocol protocol, string localPort, string remotePort, string localIPAddress, string remoteIPAddress)
        {
            Argument.AssertNotNull(targetResourceId, nameof(targetResourceId));
            Argument.AssertNotNull(localPort, nameof(localPort));
            Argument.AssertNotNull(remotePort, nameof(remotePort));
            Argument.AssertNotNull(localIPAddress, nameof(localIPAddress));
            Argument.AssertNotNull(remoteIPAddress, nameof(remoteIPAddress));

            TargetResourceId = targetResourceId;
            Direction = direction;
            Protocol = protocol;
            LocalPort = localPort;
            RemotePort = remotePort;
            LocalIPAddress = localIPAddress;
            RemoteIPAddress = remoteIPAddress;
        }

        /// <summary> The ID of the target resource to perform next-hop on. </summary>
        public ResourceIdentifier TargetResourceId { get; }
        /// <summary> The direction of the packet represented as a 5-tuple. </summary>
        public NetworkTrafficDirection Direction { get; }
        /// <summary> Protocol to be verified on. </summary>
        public IPFlowProtocol Protocol { get; }
        /// <summary> The local port. Acceptable values are a single integer in the range (0-65535). Support for * for the source port, which depends on the direction. </summary>
        public string LocalPort { get; }
        /// <summary> The remote port. Acceptable values are a single integer in the range (0-65535). Support for * for the source port, which depends on the direction. </summary>
        public string RemotePort { get; }
        /// <summary> The local IP address. Acceptable values are valid IPv4 addresses. </summary>
        public string LocalIPAddress { get; }
        /// <summary> The remote IP address. Acceptable values are valid IPv4 addresses. </summary>
        public string RemoteIPAddress { get; }
        /// <summary> The NIC ID. (If VM has multiple NICs and IP forwarding is enabled on any of them, then this parameter must be specified. Otherwise optional). </summary>
        public ResourceIdentifier TargetNicResourceId { get; set; }
    }
}