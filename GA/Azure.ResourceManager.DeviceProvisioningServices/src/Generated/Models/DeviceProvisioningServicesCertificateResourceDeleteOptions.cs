// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The DeviceProvisioningServicesCertificateResourceDeleteOptions. </summary>
    public partial class DeviceProvisioningServicesCertificateResourceDeleteOptions
    {
        /// <summary> Initializes a new instance of DeviceProvisioningServicesCertificateResourceDeleteOptions. </summary>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public DeviceProvisioningServicesCertificateResourceDeleteOptions(string ifMatch)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            IfMatch = ifMatch;
        }

        /// <summary> ETag of the certificate. </summary>
        public string IfMatch { get; }
        /// <summary> This is optional, and it is the Common Name of the certificate. </summary>
        public string CertificateCommonName { get; set; }
        /// <summary> Raw data within the certificate. </summary>
        public byte[] CertificateRawBytes { get; set; }
        /// <summary> Indicates if certificate has been verified by owner of the private key. </summary>
        public bool? CertificateIsVerified { get; set; }
        /// <summary> A description that mentions the purpose of the certificate. </summary>
        public DeviceProvisioningServicesCertificatePurpose? CertificatePurpose { get; set; }
        /// <summary> Time the certificate is created. </summary>
        public DateTimeOffset? CertificateCreatedOn { get; set; }
        /// <summary> Time the certificate is last updated. </summary>
        public DateTimeOffset? CertificateLastUpdatedOn { get; set; }
        /// <summary> Indicates if the certificate contains a private key. </summary>
        public bool? CertificateHasPrivateKey { get; set; }
        /// <summary> Random number generated to indicate Proof of Possession. </summary>
        public string CertificateNonce { get; set; }
    }
}