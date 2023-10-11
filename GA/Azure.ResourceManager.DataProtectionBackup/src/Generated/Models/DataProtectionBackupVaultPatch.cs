// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Patch Request content for Microsoft.DataProtection resources. </summary>
    public partial class DataProtectionBackupVaultPatch
    {
        /// <summary> Initializes a new instance of DataProtectionBackupVaultPatch. </summary>
        public DataProtectionBackupVaultPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Input Managed Identity Details. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource properties. </summary>
        public DataProtectionBackupVaultPatchProperties Properties { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}