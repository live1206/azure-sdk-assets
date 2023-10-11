// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> VaultCritical Operation protected by a resource guard. </summary>
    public partial class ResourceGuardOperationDetail
    {
        /// <summary> Initializes a new instance of ResourceGuardOperationDetail. </summary>
        public ResourceGuardOperationDetail()
        {
        }

        /// <summary> Initializes a new instance of ResourceGuardOperationDetail. </summary>
        /// <param name="vaultCriticalOperation"></param>
        /// <param name="defaultResourceRequest"></param>
        internal ResourceGuardOperationDetail(string vaultCriticalOperation, string defaultResourceRequest)
        {
            VaultCriticalOperation = vaultCriticalOperation;
            DefaultResourceRequest = defaultResourceRequest;
        }

        /// <summary> Gets or sets the vault critical operation. </summary>
        public string VaultCriticalOperation { get; set; }
        /// <summary> Gets or sets the default resource request. </summary>
        public string DefaultResourceRequest { get; set; }
    }
}