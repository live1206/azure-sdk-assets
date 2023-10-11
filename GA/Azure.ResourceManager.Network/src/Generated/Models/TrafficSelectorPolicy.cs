// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> An traffic selector policy for a virtual network gateway connection. </summary>
    public partial class TrafficSelectorPolicy
    {
        /// <summary> Initializes a new instance of TrafficSelectorPolicy. </summary>
        /// <param name="localAddressRanges"> A collection of local address spaces in CIDR format. </param>
        /// <param name="remoteAddressRanges"> A collection of remote address spaces in CIDR format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localAddressRanges"/> or <paramref name="remoteAddressRanges"/> is null. </exception>
        public TrafficSelectorPolicy(IEnumerable<string> localAddressRanges, IEnumerable<string> remoteAddressRanges)
        {
            Argument.AssertNotNull(localAddressRanges, nameof(localAddressRanges));
            Argument.AssertNotNull(remoteAddressRanges, nameof(remoteAddressRanges));

            LocalAddressRanges = localAddressRanges.ToList();
            RemoteAddressRanges = remoteAddressRanges.ToList();
        }

        /// <summary> Initializes a new instance of TrafficSelectorPolicy. </summary>
        /// <param name="localAddressRanges"> A collection of local address spaces in CIDR format. </param>
        /// <param name="remoteAddressRanges"> A collection of remote address spaces in CIDR format. </param>
        internal TrafficSelectorPolicy(IList<string> localAddressRanges, IList<string> remoteAddressRanges)
        {
            LocalAddressRanges = localAddressRanges;
            RemoteAddressRanges = remoteAddressRanges;
        }

        /// <summary> A collection of local address spaces in CIDR format. </summary>
        public IList<string> LocalAddressRanges { get; }
        /// <summary> A collection of remote address spaces in CIDR format. </summary>
        public IList<string> RemoteAddressRanges { get; }
    }
}