// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Azure Key Vault key management service settings for the security profile. </summary>
    public partial class ManagedClusterSecurityProfileKeyVaultKms
    {
        /// <summary> Initializes a new instance of ManagedClusterSecurityProfileKeyVaultKms. </summary>
        public ManagedClusterSecurityProfileKeyVaultKms()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterSecurityProfileKeyVaultKms. </summary>
        /// <param name="isEnabled"> Whether to enable Azure Key Vault key management service. The default is false. </param>
        /// <param name="keyId"> Identifier of Azure Key Vault key. See [key identifier format](https://docs.microsoft.com/en-us/azure/key-vault/general/about-keys-secrets-certificates#vault-name-and-object-name) for more details. When Azure Key Vault key management service is enabled, this field is required and must be a valid key identifier. When Azure Key Vault key management service is disabled, leave the field empty. </param>
        /// <param name="keyVaultNetworkAccess"> Network access of key vault. The possible values are `Public` and `Private`. `Public` means the key vault allows public access from all networks. `Private` means the key vault disables public access and enables private link. The default value is `Public`. </param>
        /// <param name="keyVaultResourceId"> Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and must be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty. </param>
        internal ManagedClusterSecurityProfileKeyVaultKms(bool? isEnabled, string keyId, ManagedClusterKeyVaultNetworkAccessType? keyVaultNetworkAccess, ResourceIdentifier keyVaultResourceId)
        {
            IsEnabled = isEnabled;
            KeyId = keyId;
            KeyVaultNetworkAccess = keyVaultNetworkAccess;
            KeyVaultResourceId = keyVaultResourceId;
        }

        /// <summary> Whether to enable Azure Key Vault key management service. The default is false. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Identifier of Azure Key Vault key. See [key identifier format](https://docs.microsoft.com/en-us/azure/key-vault/general/about-keys-secrets-certificates#vault-name-and-object-name) for more details. When Azure Key Vault key management service is enabled, this field is required and must be a valid key identifier. When Azure Key Vault key management service is disabled, leave the field empty. </summary>
        public string KeyId { get; set; }
        /// <summary> Network access of key vault. The possible values are `Public` and `Private`. `Public` means the key vault allows public access from all networks. `Private` means the key vault disables public access and enables private link. The default value is `Public`. </summary>
        public ManagedClusterKeyVaultNetworkAccessType? KeyVaultNetworkAccess { get; set; }
        /// <summary> Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and must be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty. </summary>
        public ResourceIdentifier KeyVaultResourceId { get; set; }
    }
}