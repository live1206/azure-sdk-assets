// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the CaCertificate data model.
    /// The CA Certificate resource.
    /// </summary>
    public partial class CaCertificateData : ResourceData
    {
        /// <summary> Initializes a new instance of CaCertificateData. </summary>
        public CaCertificateData()
        {
        }

        /// <summary> Initializes a new instance of CaCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description for the CA Certificate resource. </param>
        /// <param name="encodedCertificate"> Base64 encoded PEM (Privacy Enhanced Mail) format certificate data. </param>
        /// <param name="issueTimeInUtc"> Certificate issue time in UTC. This is a read-only field. </param>
        /// <param name="expiryTimeInUtc"> Certificate expiry time in UTC. This is a read-only field. </param>
        /// <param name="provisioningState"> Provisioning state of the CA Certificate resource. </param>
        internal CaCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string encodedCertificate, DateTimeOffset? issueTimeInUtc, DateTimeOffset? expiryTimeInUtc, CaCertificateProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Description = description;
            EncodedCertificate = encodedCertificate;
            IssueTimeInUtc = issueTimeInUtc;
            ExpiryTimeInUtc = expiryTimeInUtc;
            ProvisioningState = provisioningState;
        }

        /// <summary> Description for the CA Certificate resource. </summary>
        public string Description { get; set; }
        /// <summary> Base64 encoded PEM (Privacy Enhanced Mail) format certificate data. </summary>
        public string EncodedCertificate { get; set; }
        /// <summary> Certificate issue time in UTC. This is a read-only field. </summary>
        public DateTimeOffset? IssueTimeInUtc { get; }
        /// <summary> Certificate expiry time in UTC. This is a read-only field. </summary>
        public DateTimeOffset? ExpiryTimeInUtc { get; }
        /// <summary> Provisioning state of the CA Certificate resource. </summary>
        public CaCertificateProvisioningState? ProvisioningState { get; }
    }
}