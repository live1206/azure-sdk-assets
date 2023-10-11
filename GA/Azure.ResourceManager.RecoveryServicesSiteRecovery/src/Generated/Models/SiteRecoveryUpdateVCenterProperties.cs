// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The properties of an update vCenter request. </summary>
    public partial class SiteRecoveryUpdateVCenterProperties
    {
        /// <summary> Initializes a new instance of SiteRecoveryUpdateVCenterProperties. </summary>
        public SiteRecoveryUpdateVCenterProperties()
        {
        }

        /// <summary> The friendly name of the vCenter. </summary>
        public string FriendlyName { get; set; }
        /// <summary> The IP address of the vCenter to be discovered. </summary>
        public IPAddress IPAddress { get; set; }
        /// <summary> The process server Id from where the update can be orchestrated. </summary>
        public Guid? ProcessServerId { get; set; }
        /// <summary> The port number for discovery. </summary>
        public string Port { get; set; }
        /// <summary> The CS account Id which has privileges to update the vCenter. </summary>
        public string RunAsAccountId { get; set; }
    }
}