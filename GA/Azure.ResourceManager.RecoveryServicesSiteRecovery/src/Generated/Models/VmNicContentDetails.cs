// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Hyper V VM network input details. </summary>
    public partial class VmNicContentDetails
    {
        /// <summary> Initializes a new instance of VmNicContentDetails. </summary>
        public VmNicContentDetails()
        {
            IPConfigs = new ChangeTrackingList<HyperVFailoverIPConfigDetails>();
        }

        /// <summary> The nic Id. </summary>
        public string NicId { get; set; }
        /// <summary> The IP configurations to be used by NIC during test failover and failover. </summary>
        public IList<HyperVFailoverIPConfigDetails> IPConfigs { get; }
        /// <summary> Selection type for failover. </summary>
        public string SelectionType { get; set; }
        /// <summary> The id of the NSG associated with the NIC. </summary>
        public string RecoveryNetworkSecurityGroupId { get; set; }
        /// <summary> Whether the NIC has accelerated networking enabled. </summary>
        public bool? IsAcceleratedNetworkingOnRecoveryEnabled { get; set; }
        /// <summary> The NSG to be used by NIC during test failover. </summary>
        public string TfoNetworkSecurityGroupId { get; set; }
        /// <summary> Whether the test NIC has accelerated networking enabled. </summary>
        public bool? IsAcceleratedNetworkingOnTfoEnabled { get; set; }
        /// <summary> The name of the NIC to be used when creating target NICs. </summary>
        public string RecoveryNicName { get; set; }
        /// <summary> The resource group of the NIC to be used when creating target NICs. </summary>
        public string RecoveryNicResourceGroupName { get; set; }
        /// <summary> A value indicating whether an existing NIC is allowed to be reused during failover subject to availability. </summary>
        public bool? IsReuseExistingNicAllowed { get; set; }
        /// <summary> The name of the NIC to be used when creating target NICs in TFO. </summary>
        public string TfoNicName { get; set; }
        /// <summary> The resource group of the NIC to be used when creating target NICs in TFO. </summary>
        public string TfoNicResourceGroupName { get; set; }
        /// <summary> A value indicating whether an existing NIC is allowed to be reused during test failover subject to availability. </summary>
        public bool? IsTfoReuseExistingNicAllowed { get; set; }
        /// <summary> Target NIC name. </summary>
        public string TargetNicName { get; set; }
    }
}