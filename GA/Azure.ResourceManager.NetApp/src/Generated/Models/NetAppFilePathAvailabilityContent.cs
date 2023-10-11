// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> File path availability request content - availability is based on the name and the subnetId. </summary>
    public partial class NetAppFilePathAvailabilityContent
    {
        /// <summary> Initializes a new instance of NetAppFilePathAvailabilityContent. </summary>
        /// <param name="name"> File path to verify. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="subnetId"/> is null. </exception>
        public NetAppFilePathAvailabilityContent(string name, ResourceIdentifier subnetId)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(subnetId, nameof(subnetId));

            Name = name;
            SubnetId = subnetId;
        }

        /// <summary> File path to verify. </summary>
        public string Name { get; }
        /// <summary> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </summary>
        public ResourceIdentifier SubnetId { get; }
    }
}
