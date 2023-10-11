// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties of customer managed encryption key. </summary>
    public partial class CustomerManagedEncryption
    {
        /// <summary> Initializes a new instance of CustomerManagedEncryption. </summary>
        public CustomerManagedEncryption()
        {
        }

        /// <summary> Initializes a new instance of CustomerManagedEncryption. </summary>
        /// <param name="status"> Status of customer managed encryption key. </param>
        /// <param name="keyVaultProperties"> The key vault where the encryption key is stored. </param>
        internal CustomerManagedEncryption(AvsEncryptionState? status, AvsEncryptionKeyVaultProperties keyVaultProperties)
        {
            Status = status;
            KeyVaultProperties = keyVaultProperties;
        }

        /// <summary> Status of customer managed encryption key. </summary>
        public AvsEncryptionState? Status { get; set; }
        /// <summary> The key vault where the encryption key is stored. </summary>
        public AvsEncryptionKeyVaultProperties KeyVaultProperties { get; set; }
    }
}