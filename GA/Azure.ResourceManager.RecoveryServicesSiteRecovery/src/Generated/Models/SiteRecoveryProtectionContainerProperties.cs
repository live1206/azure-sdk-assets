// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Protection profile custom data details. </summary>
    public partial class SiteRecoveryProtectionContainerProperties
    {
        /// <summary> Initializes a new instance of SiteRecoveryProtectionContainerProperties. </summary>
        internal SiteRecoveryProtectionContainerProperties()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryProtectionContainerProperties. </summary>
        /// <param name="fabricFriendlyName"> Fabric friendly name. </param>
        /// <param name="friendlyName"> The name. </param>
        /// <param name="fabricType"> The fabric type. </param>
        /// <param name="protectedItemCount"> Number of protected PEs. </param>
        /// <param name="pairingStatus"> The pairing status of this cloud. </param>
        /// <param name="role"> The role of this cloud. </param>
        /// <param name="fabricSpecificDetails"> Fabric specific details. </param>
        internal SiteRecoveryProtectionContainerProperties(string fabricFriendlyName, string friendlyName, string fabricType, int? protectedItemCount, string pairingStatus, string role, ProtectionContainerFabricSpecificDetails fabricSpecificDetails)
        {
            FabricFriendlyName = fabricFriendlyName;
            FriendlyName = friendlyName;
            FabricType = fabricType;
            ProtectedItemCount = protectedItemCount;
            PairingStatus = pairingStatus;
            Role = role;
            FabricSpecificDetails = fabricSpecificDetails;
        }

        /// <summary> Fabric friendly name. </summary>
        public string FabricFriendlyName { get; }
        /// <summary> The name. </summary>
        public string FriendlyName { get; }
        /// <summary> The fabric type. </summary>
        public string FabricType { get; }
        /// <summary> Number of protected PEs. </summary>
        public int? ProtectedItemCount { get; }
        /// <summary> The pairing status of this cloud. </summary>
        public string PairingStatus { get; }
        /// <summary> The role of this cloud. </summary>
        public string Role { get; }
        /// <summary> Fabric specific details. </summary>
        internal ProtectionContainerFabricSpecificDetails FabricSpecificDetails { get; }
        /// <summary> Gets the class type. Overridden in derived classes. </summary>
        public string FabricSpecificDetailsInstanceType
        {
            get => FabricSpecificDetails?.InstanceType;
        }
    }
}