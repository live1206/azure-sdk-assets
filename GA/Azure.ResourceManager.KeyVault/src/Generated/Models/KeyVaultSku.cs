// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> SKU details. </summary>
    public partial class KeyVaultSku
    {
        /// <summary> Initializes a new instance of KeyVaultSku. </summary>
        /// <param name="family"> SKU family name. </param>
        /// <param name="name"> SKU name to specify whether the key vault is a standard vault or a premium vault. </param>
        public KeyVaultSku(KeyVaultSkuFamily family, KeyVaultSkuName name)
        {
            Family = family;
            Name = name;
        }

        /// <summary> SKU family name. </summary>
        public KeyVaultSkuFamily Family { get; set; }
        /// <summary> SKU name to specify whether the key vault is a standard vault or a premium vault. </summary>
        public KeyVaultSkuName Name { get; set; }
    }
}