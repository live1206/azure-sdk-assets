// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of P2S Vpn connection health request. </summary>
    public partial class P2SVpnConnectionHealthContent
    {
        /// <summary> Initializes a new instance of P2SVpnConnectionHealthContent. </summary>
        public P2SVpnConnectionHealthContent()
        {
            VpnUserNamesFilter = new ChangeTrackingList<string>();
        }

        /// <summary> The list of p2s vpn user names whose p2s vpn connection detailed health to retrieve for. </summary>
        public IList<string> VpnUserNamesFilter { get; }
        /// <summary> The sas-url to download the P2S Vpn connection health detail. </summary>
        public Uri OutputBlobSasUri { get; set; }
    }
}