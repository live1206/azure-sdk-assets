// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Current TCP connectivity information from the App Service Environment to a single endpoint. </summary>
    public partial class OutboundEndpointDetail
    {
        /// <summary> Initializes a new instance of OutboundEndpointDetail. </summary>
        internal OutboundEndpointDetail()
        {
        }

        /// <summary> Initializes a new instance of OutboundEndpointDetail. </summary>
        /// <param name="ipAddress"> An IP Address that Domain Name currently resolves to. </param>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <param name="latencyInMs"> The time in milliseconds it takes for a TCP connection to be created from the App Service Environment to this IpAddress at this Port. </param>
        /// <param name="isAccessible"> Whether it is possible to create a TCP connection from the App Service Environment to this IpAddress at this Port. </param>
        internal OutboundEndpointDetail(IPAddress ipAddress, int? port, double? latencyInMs, bool? isAccessible)
        {
            IPAddress = ipAddress;
            Port = port;
            LatencyInMs = latencyInMs;
            IsAccessible = isAccessible;
        }

        /// <summary> An IP Address that Domain Name currently resolves to. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The port an endpoint is connected to. </summary>
        public int? Port { get; }
        /// <summary> The time in milliseconds it takes for a TCP connection to be created from the App Service Environment to this IpAddress at this Port. </summary>
        public double? LatencyInMs { get; }
        /// <summary> Whether it is possible to create a TCP connection from the App Service Environment to this IpAddress at this Port. </summary>
        public bool? IsAccessible { get; }
    }
}