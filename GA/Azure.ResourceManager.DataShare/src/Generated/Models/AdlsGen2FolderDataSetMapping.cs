// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> An ADLS Gen2 folder data set mapping. </summary>
    public partial class AdlsGen2FolderDataSetMapping : ShareDataSetMappingData
    {
        /// <summary> Initializes a new instance of AdlsGen2FolderDataSetMapping. </summary>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="fileSystem"> File system to which the folder belongs. </param>
        /// <param name="folderPath"> Folder path within the file system. </param>
        /// <param name="resourceGroup"> Resource group of storage account. </param>
        /// <param name="storageAccountName"> Storage account name of the source data set. </param>
        /// <param name="subscriptionId"> Subscription id of storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystem"/>, <paramref name="folderPath"/>, <paramref name="resourceGroup"/>, <paramref name="storageAccountName"/> or <paramref name="subscriptionId"/> is null. </exception>
        public AdlsGen2FolderDataSetMapping(Guid dataSetId, string fileSystem, string folderPath, string resourceGroup, string storageAccountName, string subscriptionId)
        {
            Argument.AssertNotNull(fileSystem, nameof(fileSystem));
            Argument.AssertNotNull(folderPath, nameof(folderPath));
            Argument.AssertNotNull(resourceGroup, nameof(resourceGroup));
            Argument.AssertNotNull(storageAccountName, nameof(storageAccountName));
            Argument.AssertNotNull(subscriptionId, nameof(subscriptionId));

            DataSetId = dataSetId;
            FileSystem = fileSystem;
            FolderPath = folderPath;
            ResourceGroup = resourceGroup;
            StorageAccountName = storageAccountName;
            SubscriptionId = subscriptionId;
            Kind = DataSetMappingKind.AdlsGen2Folder;
        }

        /// <summary> Initializes a new instance of AdlsGen2FolderDataSetMapping. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set mapping. </param>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="dataSetMappingStatus"> Gets the status of the data set mapping. </param>
        /// <param name="fileSystem"> File system to which the folder belongs. </param>
        /// <param name="folderPath"> Folder path within the file system. </param>
        /// <param name="provisioningState"> Provisioning state of the data set mapping. </param>
        /// <param name="resourceGroup"> Resource group of storage account. </param>
        /// <param name="storageAccountName"> Storage account name of the source data set. </param>
        /// <param name="subscriptionId"> Subscription id of storage account. </param>
        internal AdlsGen2FolderDataSetMapping(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetMappingKind kind, Guid dataSetId, DataSetMappingStatus? dataSetMappingStatus, string fileSystem, string folderPath, DataShareProvisioningState? provisioningState, string resourceGroup, string storageAccountName, string subscriptionId) : base(id, name, resourceType, systemData, kind)
        {
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            FileSystem = fileSystem;
            FolderPath = folderPath;
            ProvisioningState = provisioningState;
            ResourceGroup = resourceGroup;
            StorageAccountName = storageAccountName;
            SubscriptionId = subscriptionId;
            Kind = kind;
        }

        /// <summary> The id of the source data set. </summary>
        public Guid DataSetId { get; set; }
        /// <summary> Gets the status of the data set mapping. </summary>
        public DataSetMappingStatus? DataSetMappingStatus { get; }
        /// <summary> File system to which the folder belongs. </summary>
        public string FileSystem { get; set; }
        /// <summary> Folder path within the file system. </summary>
        public string FolderPath { get; set; }
        /// <summary> Provisioning state of the data set mapping. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
        /// <summary> Resource group of storage account. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> Storage account name of the source data set. </summary>
        public string StorageAccountName { get; set; }
        /// <summary> Subscription id of storage account. </summary>
        public string SubscriptionId { get; set; }
    }
}
