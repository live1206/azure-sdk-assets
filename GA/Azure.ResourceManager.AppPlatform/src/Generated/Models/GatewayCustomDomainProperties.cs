// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The properties of custom domain for Spring Cloud Gateway. </summary>
    internal partial class GatewayCustomDomainProperties
    {
        /// <summary> Initializes a new instance of GatewayCustomDomainProperties. </summary>
        public GatewayCustomDomainProperties()
        {
        }

        /// <summary> Initializes a new instance of GatewayCustomDomainProperties. </summary>
        /// <param name="thumbprint"> The thumbprint of bound certificate. </param>
        internal GatewayCustomDomainProperties(string thumbprint)
        {
            Thumbprint = thumbprint;
        }

        /// <summary> The thumbprint of bound certificate. </summary>
        public string Thumbprint { get; set; }
    }
}