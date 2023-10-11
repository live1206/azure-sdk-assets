// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing the SphereCertificate data model.
    /// An certificate resource belonging to a catalog resource.
    /// Serialized Name: Certificate
    /// </summary>
    public partial class SphereCertificateData : ResourceData
    {
        /// <summary> Initializes a new instance of SphereCertificateData. </summary>
        public SphereCertificateData()
        {
        }

        /// <summary> Initializes a new instance of SphereCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="certificate">
        /// The certificate as a UTF-8 encoded base 64 string.
        /// Serialized Name: Certificate.properties.certificate
        /// </param>
        /// <param name="status">
        /// The certificate status.
        /// Serialized Name: Certificate.properties.status
        /// </param>
        /// <param name="subject">
        /// The certificate subject.
        /// Serialized Name: Certificate.properties.subject
        /// </param>
        /// <param name="thumbprint">
        /// The certificate thumbprint.
        /// Serialized Name: Certificate.properties.thumbprint
        /// </param>
        /// <param name="expiryUtc">
        /// The certificate expiry date.
        /// Serialized Name: Certificate.properties.expiryUtc
        /// </param>
        /// <param name="notBeforeUtc">
        /// The certificate not before date.
        /// Serialized Name: Certificate.properties.notBeforeUtc
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: Certificate.properties.provisioningState
        /// </param>
        internal SphereCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string certificate, SphereCertificateStatus? status, string subject, string thumbprint, DateTimeOffset? expiryUtc, DateTimeOffset? notBeforeUtc, SphereProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Certificate = certificate;
            Status = status;
            Subject = subject;
            Thumbprint = thumbprint;
            ExpiryUtc = expiryUtc;
            NotBeforeUtc = notBeforeUtc;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// The certificate as a UTF-8 encoded base 64 string.
        /// Serialized Name: Certificate.properties.certificate
        /// </summary>
        public string Certificate { get; }
        /// <summary>
        /// The certificate status.
        /// Serialized Name: Certificate.properties.status
        /// </summary>
        public SphereCertificateStatus? Status { get; }
        /// <summary>
        /// The certificate subject.
        /// Serialized Name: Certificate.properties.subject
        /// </summary>
        public string Subject { get; }
        /// <summary>
        /// The certificate thumbprint.
        /// Serialized Name: Certificate.properties.thumbprint
        /// </summary>
        public string Thumbprint { get; }
        /// <summary>
        /// The certificate expiry date.
        /// Serialized Name: Certificate.properties.expiryUtc
        /// </summary>
        public DateTimeOffset? ExpiryUtc { get; }
        /// <summary>
        /// The certificate not before date.
        /// Serialized Name: Certificate.properties.notBeforeUtc
        /// </summary>
        public DateTimeOffset? NotBeforeUtc { get; }
        /// <summary>
        /// The status of the last operation.
        /// Serialized Name: Certificate.properties.provisioningState
        /// </summary>
        public SphereProvisioningState? ProvisioningState { get; }
    }
}