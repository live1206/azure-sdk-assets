// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Client or app secret used in IdentityProviders, Aad, OpenID or OAuth. </summary>
    public partial class ClientSecretContract
    {
        /// <summary> Initializes a new instance of ClientSecretContract. </summary>
        internal ClientSecretContract()
        {
        }

        /// <summary> Initializes a new instance of ClientSecretContract. </summary>
        /// <param name="clientSecret"> Client or app secret used in IdentityProviders, Aad, OpenID or OAuth. </param>
        internal ClientSecretContract(string clientSecret)
        {
            ClientSecret = clientSecret;
        }

        /// <summary> Client or app secret used in IdentityProviders, Aad, OpenID or OAuth. </summary>
        public string ClientSecret { get; }
    }
}