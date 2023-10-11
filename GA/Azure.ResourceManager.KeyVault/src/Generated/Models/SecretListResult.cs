// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> List of secrets. </summary>
    internal partial class SecretListResult
    {
        /// <summary> Initializes a new instance of SecretListResult. </summary>
        internal SecretListResult()
        {
            Value = new ChangeTrackingList<KeyVaultSecretData>();
        }

        /// <summary> Initializes a new instance of SecretListResult. </summary>
        /// <param name="value"> The list of secrets. </param>
        /// <param name="nextLink"> The URL to get the next set of secrets. </param>
        internal SecretListResult(IReadOnlyList<KeyVaultSecretData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of secrets. </summary>
        public IReadOnlyList<KeyVaultSecretData> Value { get; }
        /// <summary> The URL to get the next set of secrets. </summary>
        public string NextLink { get; }
    }
}