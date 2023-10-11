// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Peer routing details. </summary>
    public partial class PeerRoute
    {
        /// <summary> Initializes a new instance of PeerRoute. </summary>
        internal PeerRoute()
        {
        }

        /// <summary> Initializes a new instance of PeerRoute. </summary>
        /// <param name="localAddress"> The peer's local address. </param>
        /// <param name="network"> The route's network prefix. </param>
        /// <param name="nextHop"> The route's next hop. </param>
        /// <param name="sourcePeer"> The peer this route was learned from. </param>
        /// <param name="origin"> The source this route was learned from. </param>
        /// <param name="asPath"> The route's AS path sequence. </param>
        /// <param name="weight"> The route's weight. </param>
        internal PeerRoute(string localAddress, string network, string nextHop, string sourcePeer, string origin, string asPath, int? weight)
        {
            LocalAddress = localAddress;
            Network = network;
            NextHop = nextHop;
            SourcePeer = sourcePeer;
            Origin = origin;
            AsPath = asPath;
            Weight = weight;
        }

        /// <summary> The peer's local address. </summary>
        public string LocalAddress { get; }
        /// <summary> The route's network prefix. </summary>
        public string Network { get; }
        /// <summary> The route's next hop. </summary>
        public string NextHop { get; }
        /// <summary> The peer this route was learned from. </summary>
        public string SourcePeer { get; }
        /// <summary> The source this route was learned from. </summary>
        public string Origin { get; }
        /// <summary> The route's AS path sequence. </summary>
        public string AsPath { get; }
        /// <summary> The route's weight. </summary>
        public int? Weight { get; }
    }
}