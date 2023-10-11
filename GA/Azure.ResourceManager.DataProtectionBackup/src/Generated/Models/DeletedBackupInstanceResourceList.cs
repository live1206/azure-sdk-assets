// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> List of DeletedBackupInstance resources. </summary>
    internal partial class DeletedBackupInstanceResourceList : DppResourceList
    {
        /// <summary> Initializes a new instance of DeletedBackupInstanceResourceList. </summary>
        internal DeletedBackupInstanceResourceList()
        {
            Value = new ChangeTrackingList<DeletedDataProtectionBackupInstanceData>();
        }

        /// <summary> Initializes a new instance of DeletedBackupInstanceResourceList. </summary>
        /// <param name="nextLink"> The uri to fetch the next page of resources. Call ListNext() fetches next page of resources. </param>
        /// <param name="value"> List of resources. </param>
        internal DeletedBackupInstanceResourceList(string nextLink, IReadOnlyList<DeletedDataProtectionBackupInstanceData> value) : base(nextLink)
        {
            Value = value;
        }

        /// <summary> List of resources. </summary>
        public IReadOnlyList<DeletedDataProtectionBackupInstanceData> Value { get; }
    }
}