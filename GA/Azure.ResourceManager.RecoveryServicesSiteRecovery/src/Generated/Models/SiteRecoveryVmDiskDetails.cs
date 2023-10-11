// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Disk details for E2A provider. </summary>
    public partial class SiteRecoveryVmDiskDetails
    {
        /// <summary> Initializes a new instance of SiteRecoveryVmDiskDetails. </summary>
        internal SiteRecoveryVmDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryVmDiskDetails. </summary>
        /// <param name="vhdType"> VHD type. </param>
        /// <param name="vhdId"> The VHD id. </param>
        /// <param name="diskId"> The disk resource id. </param>
        /// <param name="vhdName"> VHD name. </param>
        /// <param name="maxSizeMB"> Max side in MB. </param>
        /// <param name="targetDiskLocation"> Blob uri of the Azure disk. </param>
        /// <param name="targetDiskName"> The target Azure disk name. </param>
        /// <param name="lunId"> Ordinal\LunId of the disk for the Azure VM. </param>
        /// <param name="diskEncryptionSetId"> The DiskEncryptionSet ARM ID. </param>
        /// <param name="customTargetDiskName"> The custom target Azure disk name. </param>
        internal SiteRecoveryVmDiskDetails(string vhdType, string vhdId, string diskId, string vhdName, string maxSizeMB, string targetDiskLocation, string targetDiskName, string lunId, ResourceIdentifier diskEncryptionSetId, string customTargetDiskName)
        {
            VhdType = vhdType;
            VhdId = vhdId;
            DiskId = diskId;
            VhdName = vhdName;
            MaxSizeMB = maxSizeMB;
            TargetDiskLocation = targetDiskLocation;
            TargetDiskName = targetDiskName;
            LunId = lunId;
            DiskEncryptionSetId = diskEncryptionSetId;
            CustomTargetDiskName = customTargetDiskName;
        }

        /// <summary> VHD type. </summary>
        public string VhdType { get; }
        /// <summary> The VHD id. </summary>
        public string VhdId { get; }
        /// <summary> The disk resource id. </summary>
        public string DiskId { get; }
        /// <summary> VHD name. </summary>
        public string VhdName { get; }
        /// <summary> Max side in MB. </summary>
        public string MaxSizeMB { get; }
        /// <summary> Blob uri of the Azure disk. </summary>
        public string TargetDiskLocation { get; }
        /// <summary> The target Azure disk name. </summary>
        public string TargetDiskName { get; }
        /// <summary> Ordinal\LunId of the disk for the Azure VM. </summary>
        public string LunId { get; }
        /// <summary> The DiskEncryptionSet ARM ID. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; }
        /// <summary> The custom target Azure disk name. </summary>
        public string CustomTargetDiskName { get; }
    }
}