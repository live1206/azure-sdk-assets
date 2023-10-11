// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the session cookie's expiration. </summary>
    public partial class ContainerAppCookieExpiration
    {
        /// <summary> Initializes a new instance of ContainerAppCookieExpiration. </summary>
        public ContainerAppCookieExpiration()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppCookieExpiration. </summary>
        /// <param name="convention"> The convention used when determining the session cookie's expiration. </param>
        /// <param name="timeToExpiration"> The time after the request is made when the session cookie should expire. </param>
        internal ContainerAppCookieExpiration(ContainerAppCookieExpirationConvention? convention, string timeToExpiration)
        {
            Convention = convention;
            TimeToExpiration = timeToExpiration;
        }

        /// <summary> The convention used when determining the session cookie's expiration. </summary>
        public ContainerAppCookieExpirationConvention? Convention { get; set; }
        /// <summary> The time after the request is made when the session cookie should expire. </summary>
        public string TimeToExpiration { get; set; }
    }
}