// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Encryption key containing details about key to encrypt different keys. </summary>
    public partial class DataBoxKeyEncryptionKey
    {
        /// <summary> Initializes a new instance of DataBoxKeyEncryptionKey. </summary>
        /// <param name="kekType"> Type of encryption key used for key encryption. </param>
        public DataBoxKeyEncryptionKey(DataBoxKeyEncryptionKeyType kekType)
        {
            KekType = kekType;
        }

        /// <summary> Initializes a new instance of DataBoxKeyEncryptionKey. </summary>
        /// <param name="kekType"> Type of encryption key used for key encryption. </param>
        /// <param name="managedIdentity"> Managed identity properties used for key encryption. </param>
        /// <param name="kekUri"> Key encryption key. It is required in case of Customer managed KekType. </param>
        /// <param name="kekVaultResourceId"> Kek vault resource id. It is required in case of Customer managed KekType. </param>
        internal DataBoxKeyEncryptionKey(DataBoxKeyEncryptionKeyType kekType, DataBoxManagedIdentity managedIdentity, Uri kekUri, ResourceIdentifier kekVaultResourceId)
        {
            KekType = kekType;
            ManagedIdentity = managedIdentity;
            KekUri = kekUri;
            KekVaultResourceId = kekVaultResourceId;
        }

        /// <summary> Type of encryption key used for key encryption. </summary>
        public DataBoxKeyEncryptionKeyType KekType { get; set; }
        /// <summary> Managed identity properties used for key encryption. </summary>
        public DataBoxManagedIdentity ManagedIdentity { get; set; }
        /// <summary> Key encryption key. It is required in case of Customer managed KekType. </summary>
        public Uri KekUri { get; set; }
        /// <summary> Kek vault resource id. It is required in case of Customer managed KekType. </summary>
        public ResourceIdentifier KekVaultResourceId { get; set; }
    }
}