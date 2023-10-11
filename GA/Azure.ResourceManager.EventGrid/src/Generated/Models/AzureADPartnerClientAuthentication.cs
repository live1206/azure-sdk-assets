// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Azure Active Directory Partner Client Authentication. </summary>
    public partial class AzureADPartnerClientAuthentication : PartnerClientAuthentication
    {
        /// <summary> Initializes a new instance of AzureADPartnerClientAuthentication. </summary>
        public AzureADPartnerClientAuthentication()
        {
            ClientAuthenticationType = PartnerClientAuthenticationType.AzureAD;
        }

        /// <summary> Initializes a new instance of AzureADPartnerClientAuthentication. </summary>
        /// <param name="clientAuthenticationType"> Type of client authentication. </param>
        /// <param name="azureActiveDirectoryTenantId"> The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests. </param>
        /// <param name="azureActiveDirectoryApplicationIdOrUri"> The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests. </param>
        internal AzureADPartnerClientAuthentication(PartnerClientAuthenticationType clientAuthenticationType, string azureActiveDirectoryTenantId, Uri azureActiveDirectoryApplicationIdOrUri) : base(clientAuthenticationType)
        {
            AzureActiveDirectoryTenantId = azureActiveDirectoryTenantId;
            AzureActiveDirectoryApplicationIdOrUri = azureActiveDirectoryApplicationIdOrUri;
            ClientAuthenticationType = clientAuthenticationType;
        }

        /// <summary> The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests. </summary>
        public string AzureActiveDirectoryTenantId { get; set; }
        /// <summary> The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests. </summary>
        public Uri AzureActiveDirectoryApplicationIdOrUri { get; set; }
    }
}