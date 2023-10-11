// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Customer Managed Key details of the resource. </summary>
    public partial class VaultPropertiesEncryption
    {
        /// <summary> Initializes a new instance of VaultPropertiesEncryption. </summary>
        public VaultPropertiesEncryption()
        {
        }

        /// <summary> Initializes a new instance of VaultPropertiesEncryption. </summary>
        /// <param name="keyVaultProperties"> The properties of the Key Vault which hosts CMK. </param>
        /// <param name="kekIdentity"> The details of the identity used for CMK. </param>
        /// <param name="infrastructureEncryption"> Enabling/Disabling the Double Encryption state. </param>
        internal VaultPropertiesEncryption(CmkKeyVaultProperties keyVaultProperties, CmkKekIdentity kekIdentity, InfrastructureEncryptionState? infrastructureEncryption)
        {
            KeyVaultProperties = keyVaultProperties;
            KekIdentity = kekIdentity;
            InfrastructureEncryption = infrastructureEncryption;
        }

        /// <summary> The properties of the Key Vault which hosts CMK. </summary>
        internal CmkKeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> The key uri of the Customer Managed Key. </summary>
        public Uri KeyUri
        {
            get => KeyVaultProperties is null ? default : KeyVaultProperties.KeyUri;
            set
            {
                if (KeyVaultProperties is null)
                    KeyVaultProperties = new CmkKeyVaultProperties();
                KeyVaultProperties.KeyUri = value;
            }
        }

        /// <summary> The details of the identity used for CMK. </summary>
        public CmkKekIdentity KekIdentity { get; set; }
        /// <summary> Enabling/Disabling the Double Encryption state. </summary>
        public InfrastructureEncryptionState? InfrastructureEncryption { get; set; }
    }
}