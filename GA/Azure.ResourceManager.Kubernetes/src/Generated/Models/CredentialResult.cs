// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Kubernetes.Models
{
    /// <summary> The credential result response. </summary>
    public partial class CredentialResult
    {
        /// <summary> Initializes a new instance of CredentialResult. </summary>
        internal CredentialResult()
        {
        }

        /// <summary> Initializes a new instance of CredentialResult. </summary>
        /// <param name="name"> The name of the credential. </param>
        /// <param name="value"> Base64-encoded Kubernetes configuration file. </param>
        internal CredentialResult(string name, byte[] value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of the credential. </summary>
        public string Name { get; }
        /// <summary> Base64-encoded Kubernetes configuration file. </summary>
        public byte[] Value { get; }
    }
}