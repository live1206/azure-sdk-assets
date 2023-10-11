// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Dynamic match configuration object. </summary>
    public partial class CommonDynamicMatchConfiguration
    {
        /// <summary> Initializes a new instance of CommonDynamicMatchConfiguration. </summary>
        public CommonDynamicMatchConfiguration()
        {
            IPGroups = new ChangeTrackingList<MatchConfigurationIPGroupProperties>();
            VlanGroups = new ChangeTrackingList<VlanGroupProperties>();
            PortGroups = new ChangeTrackingList<PortGroupProperties>();
        }

        /// <summary> Initializes a new instance of CommonDynamicMatchConfiguration. </summary>
        /// <param name="ipGroups"> List of IP Groups. </param>
        /// <param name="vlanGroups"> List of vlan groups. </param>
        /// <param name="portGroups"> List of the port groups. </param>
        internal CommonDynamicMatchConfiguration(IList<MatchConfigurationIPGroupProperties> ipGroups, IList<VlanGroupProperties> vlanGroups, IList<PortGroupProperties> portGroups)
        {
            IPGroups = ipGroups;
            VlanGroups = vlanGroups;
            PortGroups = portGroups;
        }

        /// <summary> List of IP Groups. </summary>
        public IList<MatchConfigurationIPGroupProperties> IPGroups { get; }
        /// <summary> List of vlan groups. </summary>
        public IList<VlanGroupProperties> VlanGroups { get; }
        /// <summary> List of the port groups. </summary>
        public IList<PortGroupProperties> PortGroups { get; }
    }
}