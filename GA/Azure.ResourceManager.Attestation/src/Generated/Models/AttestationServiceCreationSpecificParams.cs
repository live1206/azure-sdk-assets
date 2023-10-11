// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> Client supplied parameters used to create a new attestation provider. </summary>
    public partial class AttestationServiceCreationSpecificParams
    {
        /// <summary> Initializes a new instance of AttestationServiceCreationSpecificParams. </summary>
        public AttestationServiceCreationSpecificParams()
        {
        }

        /// <summary> Controls whether traffic from the public network is allowed to access the Attestation Provider APIs. </summary>
        public PublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary> JSON Web Key Set defining a set of X.509 Certificates that will represent the parent certificate for the signing certificate used for policy operations. </summary>
        internal JsonWebKeySet PolicySigningCertificates { get; set; }
        /// <summary>
        /// The value of the "keys" parameter is an array of JWK values.  By
        /// default, the order of the JWK values within the array does not imply
        /// an order of preference among them, although applications of JWK Sets
        /// can choose to assign a meaning to the order for their purposes, if
        /// desired.
        /// </summary>
        public IList<JsonWebKey> PolicySigningCertificatesKeys
        {
            get
            {
                if (PolicySigningCertificates is null)
                    PolicySigningCertificates = new JsonWebKeySet();
                return PolicySigningCertificates.Keys;
            }
        }
    }
}