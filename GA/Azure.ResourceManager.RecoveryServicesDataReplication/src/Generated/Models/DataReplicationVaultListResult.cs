// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Vault model collection. </summary>
    internal partial class DataReplicationVaultListResult
    {
        /// <summary> Initializes a new instance of DataReplicationVaultListResult. </summary>
        internal DataReplicationVaultListResult()
        {
            Value = new ChangeTrackingList<DataReplicationVaultData>();
        }

        /// <summary> Initializes a new instance of DataReplicationVaultListResult. </summary>
        /// <param name="value"> Gets or sets the list of vaults. </param>
        /// <param name="nextLink"> Gets or sets the value of next link. </param>
        internal DataReplicationVaultListResult(IReadOnlyList<DataReplicationVaultData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets the list of vaults. </summary>
        public IReadOnlyList<DataReplicationVaultData> Value { get; }
        /// <summary> Gets or sets the value of next link. </summary>
        public string NextLink { get; }
    }
}