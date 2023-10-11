// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Agent disk details. </summary>
    public partial class SiteRecoveryAgentDiskDetails
    {
        /// <summary> Initializes a new instance of SiteRecoveryAgentDiskDetails. </summary>
        internal SiteRecoveryAgentDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryAgentDiskDetails. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="diskName"> The disk name. </param>
        /// <param name="isOSDisk"> A value indicating whether the disk is the OS disk. </param>
        /// <param name="capacityInBytes"> The disk capacity in bytes. </param>
        /// <param name="lunId"> The lun of disk. </param>
        internal SiteRecoveryAgentDiskDetails(string diskId, string diskName, string isOSDisk, long? capacityInBytes, int? lunId)
        {
            DiskId = diskId;
            DiskName = diskName;
            IsOSDisk = isOSDisk;
            CapacityInBytes = capacityInBytes;
            LunId = lunId;
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The disk name. </summary>
        public string DiskName { get; }
        /// <summary> A value indicating whether the disk is the OS disk. </summary>
        public string IsOSDisk { get; }
        /// <summary> The disk capacity in bytes. </summary>
        public long? CapacityInBytes { get; }
        /// <summary> The lun of disk. </summary>
        public int? LunId { get; }
    }
}