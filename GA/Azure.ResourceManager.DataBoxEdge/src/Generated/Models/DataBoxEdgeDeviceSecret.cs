// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Holds device secret either as a KeyVault reference or as an encrypted value. </summary>
    public partial class DataBoxEdgeDeviceSecret
    {
        /// <summary> Initializes a new instance of DataBoxEdgeDeviceSecret. </summary>
        internal DataBoxEdgeDeviceSecret()
        {
        }

        /// <summary> Initializes a new instance of DataBoxEdgeDeviceSecret. </summary>
        /// <param name="encryptedSecret"> Encrypted (using device public key) secret value. </param>
        /// <param name="keyVaultId"> Id of the Key-Vault where secret is stored (ex: secrets/AuthClientSecret/82ef4346187a4033a10d629cde07d740). </param>
        internal DataBoxEdgeDeviceSecret(AsymmetricEncryptedSecret encryptedSecret, string keyVaultId)
        {
            EncryptedSecret = encryptedSecret;
            KeyVaultId = keyVaultId;
        }

        /// <summary> Encrypted (using device public key) secret value. </summary>
        public AsymmetricEncryptedSecret EncryptedSecret { get; }
        /// <summary> Id of the Key-Vault where secret is stored (ex: secrets/AuthClientSecret/82ef4346187a4033a10d629cde07d740). </summary>
        public string KeyVaultId { get; }
    }
}