// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Ingress configuration payload for Azure Spring Apps resource. </summary>
    internal partial class IngressConfig
    {
        /// <summary> Initializes a new instance of IngressConfig. </summary>
        public IngressConfig()
        {
        }

        /// <summary> Initializes a new instance of IngressConfig. </summary>
        /// <param name="readTimeoutInSeconds"> Ingress read time out in seconds. </param>
        internal IngressConfig(int? readTimeoutInSeconds)
        {
            ReadTimeoutInSeconds = readTimeoutInSeconds;
        }

        /// <summary> Ingress read time out in seconds. </summary>
        public int? ReadTimeoutInSeconds { get; set; }
    }
}
