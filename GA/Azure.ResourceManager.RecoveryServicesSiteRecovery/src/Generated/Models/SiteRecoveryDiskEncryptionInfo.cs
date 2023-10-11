// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery disk encryption info (BEK and KEK). </summary>
    public partial class SiteRecoveryDiskEncryptionInfo
    {
        /// <summary> Initializes a new instance of SiteRecoveryDiskEncryptionInfo. </summary>
        public SiteRecoveryDiskEncryptionInfo()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryDiskEncryptionInfo. </summary>
        /// <param name="diskEncryptionKeyInfo"> The recovery KeyVault reference for secret. </param>
        /// <param name="keyEncryptionKeyInfo"> The recovery KeyVault reference for key. </param>
        internal SiteRecoveryDiskEncryptionInfo(SiteRecoveryDiskEncryptionKeyInfo diskEncryptionKeyInfo, SiteRecoveryKeyEncryptionKeyInfo keyEncryptionKeyInfo)
        {
            DiskEncryptionKeyInfo = diskEncryptionKeyInfo;
            KeyEncryptionKeyInfo = keyEncryptionKeyInfo;
        }

        /// <summary> The recovery KeyVault reference for secret. </summary>
        public SiteRecoveryDiskEncryptionKeyInfo DiskEncryptionKeyInfo { get; set; }
        /// <summary> The recovery KeyVault reference for key. </summary>
        public SiteRecoveryKeyEncryptionKeyInfo KeyEncryptionKeyInfo { get; set; }
    }
}