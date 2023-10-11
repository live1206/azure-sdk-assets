// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Identity provider input. </summary>
    public partial class IdentityProviderContent
    {
        /// <summary> Initializes a new instance of IdentityProviderContent. </summary>
        /// <param name="tenantId"> The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="applicationId"> The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="objectId"> The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="audience"> The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="aadAuthority"> The base authority for Azure Active Directory authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/>, <paramref name="objectId"/>, <paramref name="audience"/> or <paramref name="aadAuthority"/> is null. </exception>
        public IdentityProviderContent(Guid tenantId, string applicationId, string objectId, string audience, string aadAuthority)
        {
            Argument.AssertNotNull(applicationId, nameof(applicationId));
            Argument.AssertNotNull(objectId, nameof(objectId));
            Argument.AssertNotNull(audience, nameof(audience));
            Argument.AssertNotNull(aadAuthority, nameof(aadAuthority));

            TenantId = tenantId;
            ApplicationId = applicationId;
            ObjectId = objectId;
            Audience = audience;
            AadAuthority = aadAuthority;
        }

        /// <summary> The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public Guid TenantId { get; }
        /// <summary> The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public string ApplicationId { get; }
        /// <summary> The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public string ObjectId { get; }
        /// <summary> The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public string Audience { get; }
        /// <summary> The base authority for Azure Active Directory authentication. </summary>
        public string AadAuthority { get; }
    }
}