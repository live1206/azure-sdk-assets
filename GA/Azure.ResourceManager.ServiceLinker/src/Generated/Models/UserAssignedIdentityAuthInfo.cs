// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The authentication info when authType is userAssignedIdentity. </summary>
    public partial class UserAssignedIdentityAuthInfo : AuthBaseInfo
    {
        /// <summary> Initializes a new instance of UserAssignedIdentityAuthInfo. </summary>
        public UserAssignedIdentityAuthInfo()
        {
            AuthType = LinkerAuthType.UserAssignedIdentity;
        }

        /// <summary> Initializes a new instance of UserAssignedIdentityAuthInfo. </summary>
        /// <param name="authType"> The authentication type. </param>
        /// <param name="clientId"> Client Id for userAssignedIdentity. </param>
        /// <param name="subscriptionId"> Subscription id for userAssignedIdentity. </param>
        internal UserAssignedIdentityAuthInfo(LinkerAuthType authType, string clientId, string subscriptionId) : base(authType)
        {
            ClientId = clientId;
            SubscriptionId = subscriptionId;
            AuthType = authType;
        }

        /// <summary> Client Id for userAssignedIdentity. </summary>
        public string ClientId { get; set; }
        /// <summary> Subscription id for userAssignedIdentity. </summary>
        public string SubscriptionId { get; set; }
    }
}