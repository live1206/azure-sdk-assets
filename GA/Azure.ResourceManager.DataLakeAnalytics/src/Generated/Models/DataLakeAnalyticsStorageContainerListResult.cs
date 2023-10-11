// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataLakeAnalytics;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The list of blob containers associated with the storage account attached to the Data Lake Analytics account.
    /// Serialized Name: StorageContainerListResult
    /// </summary>
    internal partial class DataLakeAnalyticsStorageContainerListResult
    {
        /// <summary> Initializes a new instance of DataLakeAnalyticsStorageContainerListResult. </summary>
        internal DataLakeAnalyticsStorageContainerListResult()
        {
            Value = new ChangeTrackingList<DataLakeAnalyticsStorageContainerData>();
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsStorageContainerListResult. </summary>
        /// <param name="value">
        /// The results of the list operation.
        /// Serialized Name: StorageContainerListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The link (url) to the next page of results.
        /// Serialized Name: StorageContainerListResult.nextLink
        /// </param>
        internal DataLakeAnalyticsStorageContainerListResult(IReadOnlyList<DataLakeAnalyticsStorageContainerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The results of the list operation.
        /// Serialized Name: StorageContainerListResult.value
        /// </summary>
        public IReadOnlyList<DataLakeAnalyticsStorageContainerData> Value { get; }
        /// <summary>
        /// The link (url) to the next page of results.
        /// Serialized Name: StorageContainerListResult.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
