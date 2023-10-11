// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Details of the managed disks. </summary>
    public partial class ManagedDiskDetails : DataAccountDetails
    {
        /// <summary> Initializes a new instance of ManagedDiskDetails. </summary>
        /// <param name="resourceGroupId"> Resource Group Id of the compute disks. </param>
        /// <param name="stagingStorageAccountId"> Resource Id of the storage account that can be used to copy the vhd for staging. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupId"/> or <paramref name="stagingStorageAccountId"/> is null. </exception>
        public ManagedDiskDetails(ResourceIdentifier resourceGroupId, ResourceIdentifier stagingStorageAccountId)
        {
            Argument.AssertNotNull(resourceGroupId, nameof(resourceGroupId));
            Argument.AssertNotNull(stagingStorageAccountId, nameof(stagingStorageAccountId));

            ResourceGroupId = resourceGroupId;
            StagingStorageAccountId = stagingStorageAccountId;
            DataAccountType = DataAccountType.ManagedDisk;
        }

        /// <summary> Initializes a new instance of ManagedDiskDetails. </summary>
        /// <param name="dataAccountType"> Account Type of the data to be transferred. </param>
        /// <param name="sharePassword"> Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements :  Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets, numbers and these characters : @#\-$%^!+=;:_()]+. </param>
        /// <param name="resourceGroupId"> Resource Group Id of the compute disks. </param>
        /// <param name="stagingStorageAccountId"> Resource Id of the storage account that can be used to copy the vhd for staging. </param>
        internal ManagedDiskDetails(DataAccountType dataAccountType, string sharePassword, ResourceIdentifier resourceGroupId, ResourceIdentifier stagingStorageAccountId) : base(dataAccountType, sharePassword)
        {
            ResourceGroupId = resourceGroupId;
            StagingStorageAccountId = stagingStorageAccountId;
            DataAccountType = dataAccountType;
        }

        /// <summary> Resource Group Id of the compute disks. </summary>
        public ResourceIdentifier ResourceGroupId { get; set; }
        /// <summary> Resource Id of the storage account that can be used to copy the vhd for staging. </summary>
        public ResourceIdentifier StagingStorageAccountId { get; set; }
    }
}