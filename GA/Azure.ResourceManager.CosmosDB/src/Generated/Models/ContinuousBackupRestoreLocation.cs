// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties of the regional restorable account. </summary>
    public partial class ContinuousBackupRestoreLocation
    {
        /// <summary> Initializes a new instance of ContinuousBackupRestoreLocation. </summary>
        public ContinuousBackupRestoreLocation()
        {
        }

        /// <summary> The name of the continuous backup restore location. </summary>
        public AzureLocation? Location { get; set; }
    }
}