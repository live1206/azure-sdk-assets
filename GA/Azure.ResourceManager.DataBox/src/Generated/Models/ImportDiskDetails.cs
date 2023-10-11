// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Import disk details. </summary>
    public partial class ImportDiskDetails
    {
        /// <summary> Initializes a new instance of ImportDiskDetails. </summary>
        /// <param name="manifestFile"> The relative path of the manifest file on the disk. </param>
        /// <param name="manifestHash"> The Base16-encoded MD5 hash of the manifest file on the disk. </param>
        /// <param name="bitLockerKey"> BitLocker key used to encrypt the disk. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="manifestFile"/>, <paramref name="manifestHash"/> or <paramref name="bitLockerKey"/> is null. </exception>
        public ImportDiskDetails(string manifestFile, string manifestHash, string bitLockerKey)
        {
            Argument.AssertNotNull(manifestFile, nameof(manifestFile));
            Argument.AssertNotNull(manifestHash, nameof(manifestHash));
            Argument.AssertNotNull(bitLockerKey, nameof(bitLockerKey));

            ManifestFile = manifestFile;
            ManifestHash = manifestHash;
            BitLockerKey = bitLockerKey;
        }

        /// <summary> Initializes a new instance of ImportDiskDetails. </summary>
        /// <param name="manifestFile"> The relative path of the manifest file on the disk. </param>
        /// <param name="manifestHash"> The Base16-encoded MD5 hash of the manifest file on the disk. </param>
        /// <param name="bitLockerKey"> BitLocker key used to encrypt the disk. </param>
        /// <param name="backupManifestCloudPath"> Path to backed up manifest, only returned if enableManifestBackup is true. </param>
        internal ImportDiskDetails(string manifestFile, string manifestHash, string bitLockerKey, string backupManifestCloudPath)
        {
            ManifestFile = manifestFile;
            ManifestHash = manifestHash;
            BitLockerKey = bitLockerKey;
            BackupManifestCloudPath = backupManifestCloudPath;
        }

        /// <summary> The relative path of the manifest file on the disk. </summary>
        public string ManifestFile { get; set; }
        /// <summary> The Base16-encoded MD5 hash of the manifest file on the disk. </summary>
        public string ManifestHash { get; set; }
        /// <summary> BitLocker key used to encrypt the disk. </summary>
        public string BitLockerKey { get; set; }
        /// <summary> Path to backed up manifest, only returned if enableManifestBackup is true. </summary>
        public string BackupManifestCloudPath { get; }
    }
}