// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Storage information about the data disks present in the custom image. </summary>
    public partial class DevTestLabDataDiskStorageTypeInfo
    {
        /// <summary> Initializes a new instance of DevTestLabDataDiskStorageTypeInfo. </summary>
        public DevTestLabDataDiskStorageTypeInfo()
        {
        }

        /// <summary> Initializes a new instance of DevTestLabDataDiskStorageTypeInfo. </summary>
        /// <param name="lun"> Disk Lun. </param>
        /// <param name="storageType"> Disk Storage Type. </param>
        internal DevTestLabDataDiskStorageTypeInfo(string lun, DevTestLabStorageType? storageType)
        {
            Lun = lun;
            StorageType = storageType;
        }

        /// <summary> Disk Lun. </summary>
        public string Lun { get; set; }
        /// <summary> Disk Storage Type. </summary>
        public DevTestLabStorageType? StorageType { get; set; }
    }
}
