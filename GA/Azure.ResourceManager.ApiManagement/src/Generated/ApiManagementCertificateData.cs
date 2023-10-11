// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementCertificate data model.
    /// Certificate details.
    /// </summary>
    public partial class ApiManagementCertificateData : ResourceData
    {
        /// <summary> Initializes a new instance of ApiManagementCertificateData. </summary>
        public ApiManagementCertificateData()
        {
        }

        /// <summary> Initializes a new instance of ApiManagementCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="subject"> Subject attribute of the certificate. </param>
        /// <param name="thumbprint"> Thumbprint of the certificate. </param>
        /// <param name="expireOn">
        /// Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="keyVaultDetails"> KeyVault location details of the certificate. </param>
        internal ApiManagementCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string subject, string thumbprint, DateTimeOffset? expireOn, KeyVaultContractProperties keyVaultDetails) : base(id, name, resourceType, systemData)
        {
            Subject = subject;
            Thumbprint = thumbprint;
            ExpireOn = expireOn;
            KeyVaultDetails = keyVaultDetails;
        }

        /// <summary> Subject attribute of the certificate. </summary>
        public string Subject { get; set; }
        /// <summary> Thumbprint of the certificate. </summary>
        public string Thumbprint { get; set; }
        /// <summary>
        /// Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> KeyVault location details of the certificate. </summary>
        public KeyVaultContractProperties KeyVaultDetails { get; set; }
    }
}