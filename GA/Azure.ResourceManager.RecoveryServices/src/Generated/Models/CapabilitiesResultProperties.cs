// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Capabilities properties in response. </summary>
    internal partial class CapabilitiesResultProperties
    {
        /// <summary> Initializes a new instance of CapabilitiesResultProperties. </summary>
        public CapabilitiesResultProperties()
        {
            DnsZones = new ChangeTrackingList<DnsZoneResult>();
        }

        /// <summary> Initializes a new instance of CapabilitiesResultProperties. </summary>
        /// <param name="dnsZones"></param>
        internal CapabilitiesResultProperties(IList<DnsZoneResult> dnsZones)
        {
            DnsZones = dnsZones;
        }

        /// <summary> Gets the dns zones. </summary>
        public IList<DnsZoneResult> DnsZones { get; }
    }
}