// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> The network profile definition. </summary>
    public partial class NetworkProfile
    {
        /// <summary> Initializes a new instance of NetworkProfile. </summary>
        public NetworkProfile()
        {
            NetworkInterfaces = new ChangeTrackingList<NetworkInterface>();
        }

        /// <summary> Initializes a new instance of NetworkProfile. </summary>
        /// <param name="subnet"> Specifies the identifier of the subnet. </param>
        /// <param name="networkInterfaces"> Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM. </param>
        internal NetworkProfile(WritableSubResource subnet, IList<NetworkInterface> networkInterfaces)
        {
            Subnet = subnet;
            NetworkInterfaces = networkInterfaces;
        }

        /// <summary> Specifies the identifier of the subnet. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }

        /// <summary> Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM. </summary>
        public IList<NetworkInterface> NetworkInterfaces { get; }
    }
}