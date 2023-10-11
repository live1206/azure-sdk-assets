// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The server AAD application secret. </summary>
    public partial class AADProfileSecret
    {
        /// <summary> Initializes a new instance of AADProfileSecret. </summary>
        public AADProfileSecret()
        {
        }

        /// <summary> Initializes a new instance of AADProfileSecret. </summary>
        /// <param name="serverAppSecret"> The server AAD application secret. </param>
        internal AADProfileSecret(string serverAppSecret)
        {
            ServerAppSecret = serverAppSecret;
        }

        /// <summary> The server AAD application secret. </summary>
        public string ServerAppSecret { get; set; }
    }
}