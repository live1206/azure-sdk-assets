// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the LedgerDigestUpload data model.
    /// Azure SQL Database ledger digest upload settings.
    /// </summary>
    public partial class LedgerDigestUploadData : ResourceData
    {
        /// <summary> Initializes a new instance of LedgerDigestUploadData. </summary>
        public LedgerDigestUploadData()
        {
        }

        /// <summary> Initializes a new instance of LedgerDigestUploadData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="digestStorageEndpoint"> The digest storage endpoint, which must be either an Azure blob storage endpoint or an URI for Azure Confidential Ledger. </param>
        /// <param name="state"> Specifies the state of ledger digest upload. </param>
        internal LedgerDigestUploadData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string digestStorageEndpoint, LedgerDigestUploadsState? state) : base(id, name, resourceType, systemData)
        {
            DigestStorageEndpoint = digestStorageEndpoint;
            State = state;
        }

        /// <summary> The digest storage endpoint, which must be either an Azure blob storage endpoint or an URI for Azure Confidential Ledger. </summary>
        public string DigestStorageEndpoint { get; set; }
        /// <summary> Specifies the state of ledger digest upload. </summary>
        public LedgerDigestUploadsState? State { get; }
    }
}
