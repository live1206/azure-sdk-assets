// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DataShare;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> List response for get DataSets. </summary>
    internal partial class DataSetList
    {
        /// <summary> Initializes a new instance of DataSetList. </summary>
        /// <param name="value">
        /// Collection of items of type DataTransferObjects.
        /// Please note <see cref="ShareDataSetData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AdlsGen1FileDataSet"/>, <see cref="AdlsGen1FolderDataSet"/>, <see cref="AdlsGen2FileDataSet"/>, <see cref="AdlsGen2FileSystemDataSet"/>, <see cref="AdlsGen2FolderDataSet"/>, <see cref="BlobDataSet"/>, <see cref="BlobFolderDataSet"/>, <see cref="BlobContainerDataSet"/>, <see cref="KustoClusterDataSet"/>, <see cref="KustoDatabaseDataSet"/>, <see cref="KustoTableDataSet"/>, <see cref="SqlDBTableDataSet"/>, <see cref="SqlDWTableDataSet"/> and <see cref="SynapseWorkspaceSqlPoolTableDataSet"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataSetList(IEnumerable<ShareDataSetData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DataSetList. </summary>
        /// <param name="nextLink"> The Url of next result page. </param>
        /// <param name="value">
        /// Collection of items of type DataTransferObjects.
        /// Please note <see cref="ShareDataSetData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AdlsGen1FileDataSet"/>, <see cref="AdlsGen1FolderDataSet"/>, <see cref="AdlsGen2FileDataSet"/>, <see cref="AdlsGen2FileSystemDataSet"/>, <see cref="AdlsGen2FolderDataSet"/>, <see cref="BlobDataSet"/>, <see cref="BlobFolderDataSet"/>, <see cref="BlobContainerDataSet"/>, <see cref="KustoClusterDataSet"/>, <see cref="KustoDatabaseDataSet"/>, <see cref="KustoTableDataSet"/>, <see cref="SqlDBTableDataSet"/>, <see cref="SqlDWTableDataSet"/> and <see cref="SynapseWorkspaceSqlPoolTableDataSet"/>.
        /// </param>
        internal DataSetList(string nextLink, IReadOnlyList<ShareDataSetData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The Url of next result page. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Collection of items of type DataTransferObjects.
        /// Please note <see cref="ShareDataSetData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AdlsGen1FileDataSet"/>, <see cref="AdlsGen1FolderDataSet"/>, <see cref="AdlsGen2FileDataSet"/>, <see cref="AdlsGen2FileSystemDataSet"/>, <see cref="AdlsGen2FolderDataSet"/>, <see cref="BlobDataSet"/>, <see cref="BlobFolderDataSet"/>, <see cref="BlobContainerDataSet"/>, <see cref="KustoClusterDataSet"/>, <see cref="KustoDatabaseDataSet"/>, <see cref="KustoTableDataSet"/>, <see cref="SqlDBTableDataSet"/>, <see cref="SqlDWTableDataSet"/> and <see cref="SynapseWorkspaceSqlPoolTableDataSet"/>.
        /// </summary>
        public IReadOnlyList<ShareDataSetData> Value { get; }
    }
}