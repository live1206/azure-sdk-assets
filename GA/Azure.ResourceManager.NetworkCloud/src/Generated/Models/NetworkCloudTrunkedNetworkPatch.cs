// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> TrunkedNetworkPatchParameters represents the body of the request to patch the Trunked network. </summary>
    public partial class NetworkCloudTrunkedNetworkPatch
    {
        /// <summary> Initializes a new instance of NetworkCloudTrunkedNetworkPatch. </summary>
        public NetworkCloudTrunkedNetworkPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}