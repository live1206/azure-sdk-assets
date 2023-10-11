// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Storage profile for the container service cluster. </summary>
    public partial class ManagedClusterStorageProfile
    {
        /// <summary> Initializes a new instance of ManagedClusterStorageProfile. </summary>
        public ManagedClusterStorageProfile()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterStorageProfile. </summary>
        /// <param name="diskCsiDriver"> AzureDisk CSI Driver settings for the storage profile. </param>
        /// <param name="fileCsiDriver"> AzureFile CSI Driver settings for the storage profile. </param>
        /// <param name="snapshotController"> Snapshot Controller settings for the storage profile. </param>
        /// <param name="blobCsiDriver"> AzureBlob CSI Driver settings for the storage profile. </param>
        internal ManagedClusterStorageProfile(ManagedClusterStorageProfileDiskCsiDriver diskCsiDriver, ManagedClusterStorageProfileFileCsiDriver fileCsiDriver, ManagedClusterStorageProfileSnapshotController snapshotController, ManagedClusterStorageProfileBlobCsiDriver blobCsiDriver)
        {
            DiskCsiDriver = diskCsiDriver;
            FileCsiDriver = fileCsiDriver;
            SnapshotController = snapshotController;
            BlobCsiDriver = blobCsiDriver;
        }

        /// <summary> AzureDisk CSI Driver settings for the storage profile. </summary>
        public ManagedClusterStorageProfileDiskCsiDriver DiskCsiDriver { get; set; }
        /// <summary> AzureFile CSI Driver settings for the storage profile. </summary>
        internal ManagedClusterStorageProfileFileCsiDriver FileCsiDriver { get; set; }

        /// <summary> Snapshot Controller settings for the storage profile. </summary>
        internal ManagedClusterStorageProfileSnapshotController SnapshotController { get; set; }

        /// <summary> AzureBlob CSI Driver settings for the storage profile. </summary>
        internal ManagedClusterStorageProfileBlobCsiDriver BlobCsiDriver { get; set; }
    }
}