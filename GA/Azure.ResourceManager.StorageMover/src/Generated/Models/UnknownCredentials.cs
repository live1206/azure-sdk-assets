// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The UnknownCredentials. </summary>
    internal partial class UnknownCredentials : StorageMoverCredentials
    {
        /// <summary> Initializes a new instance of UnknownCredentials. </summary>
        /// <param name="credentialType"> The Credentials type. </param>
        internal UnknownCredentials(CredentialType credentialType) : base(credentialType)
        {
            CredentialType = credentialType;
        }
    }
}