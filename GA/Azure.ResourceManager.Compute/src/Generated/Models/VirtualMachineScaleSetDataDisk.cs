// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set data disk. </summary>
    public partial class VirtualMachineScaleSetDataDisk
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetDataDisk. </summary>
        /// <param name="lun"> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </param>
        /// <param name="createOption"> The create option. </param>
        public VirtualMachineScaleSetDataDisk(int lun, DiskCreateOptionType createOption)
        {
            Lun = lun;
            CreateOption = createOption;
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetDataDisk. </summary>
        /// <param name="name"> The disk name. </param>
        /// <param name="lun"> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </param>
        /// <param name="caching"> Specifies the caching requirements. Possible values are: **None,** **ReadOnly,** **ReadWrite.** The default values are: **None for Standard storage. ReadOnly for Premium storage.**. </param>
        /// <param name="writeAcceleratorEnabled"> Specifies whether writeAccelerator should be enabled or disabled on the disk. </param>
        /// <param name="createOption"> The create option. </param>
        /// <param name="diskSizeGB"> Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. The property diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be larger than 1023. </param>
        /// <param name="managedDisk"> The managed disk parameters. </param>
        /// <param name="diskIopsReadWrite"> Specifies the Read-Write IOPS for the managed disk. Should be used only when StorageAccountType is UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB. </param>
        /// <param name="diskMBpsReadWrite"> Specifies the bandwidth in MB per second for the managed disk. Should be used only when StorageAccountType is UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB. </param>
        /// <param name="deleteOption"> Specifies whether data disk should be deleted or detached upon VMSS Flex deletion (This feature is available for VMSS with Flexible OrchestrationMode only).&lt;br&gt;&lt;br&gt; Possible values: &lt;br&gt;&lt;br&gt; **Delete** If this value is used, the data disk is deleted when the VMSS Flex VM is deleted.&lt;br&gt;&lt;br&gt; **Detach** If this value is used, the data disk is retained after VMSS Flex VM is deleted.&lt;br&gt;&lt;br&gt; The default value is set to **Delete**. </param>
        internal VirtualMachineScaleSetDataDisk(string name, int lun, CachingType? caching, bool? writeAcceleratorEnabled, DiskCreateOptionType createOption, int? diskSizeGB, VirtualMachineScaleSetManagedDisk managedDisk, long? diskIopsReadWrite, long? diskMBpsReadWrite, DiskDeleteOptionType? deleteOption)
        {
            Name = name;
            Lun = lun;
            Caching = caching;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
            CreateOption = createOption;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
            DiskIopsReadWrite = diskIopsReadWrite;
            DiskMBpsReadWrite = diskMBpsReadWrite;
            DeleteOption = deleteOption;
        }

        /// <summary> The disk name. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </summary>
        public int Lun { get; set; }
        /// <summary> Specifies the caching requirements. Possible values are: **None,** **ReadOnly,** **ReadWrite.** The default values are: **None for Standard storage. ReadOnly for Premium storage.**. </summary>
        public CachingType? Caching { get; set; }
        /// <summary> Specifies whether writeAccelerator should be enabled or disabled on the disk. </summary>
        public bool? WriteAcceleratorEnabled { get; set; }
        /// <summary> The create option. </summary>
        public DiskCreateOptionType CreateOption { get; set; }
        /// <summary> Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. The property diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be larger than 1023. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> The managed disk parameters. </summary>
        public VirtualMachineScaleSetManagedDisk ManagedDisk { get; set; }
        /// <summary> Specifies the Read-Write IOPS for the managed disk. Should be used only when StorageAccountType is UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB. </summary>
        public long? DiskIopsReadWrite { get; set; }
        /// <summary> Specifies the bandwidth in MB per second for the managed disk. Should be used only when StorageAccountType is UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB. </summary>
        public long? DiskMBpsReadWrite { get; set; }
        /// <summary> Specifies whether data disk should be deleted or detached upon VMSS Flex deletion (This feature is available for VMSS with Flexible OrchestrationMode only).&lt;br&gt;&lt;br&gt; Possible values: &lt;br&gt;&lt;br&gt; **Delete** If this value is used, the data disk is deleted when the VMSS Flex VM is deleted.&lt;br&gt;&lt;br&gt; **Detach** If this value is used, the data disk is retained after VMSS Flex VM is deleted.&lt;br&gt;&lt;br&gt; The default value is set to **Delete**. </summary>
        public DiskDeleteOptionType? DeleteOption { get; set; }
    }
}