// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The JSON-serialized array of Certificate objects. </summary>
    internal partial class CertificateListDescription
    {
        /// <summary> Initializes a new instance of CertificateListDescription. </summary>
        internal CertificateListDescription()
        {
            Value = new ChangeTrackingList<DeviceProvisioningServicesCertificateData>();
        }

        /// <summary> Initializes a new instance of CertificateListDescription. </summary>
        /// <param name="value"> The array of Certificate objects. </param>
        internal CertificateListDescription(IReadOnlyList<DeviceProvisioningServicesCertificateData> value)
        {
            Value = value;
        }

        /// <summary> The array of Certificate objects. </summary>
        public IReadOnlyList<DeviceProvisioningServicesCertificateData> Value { get; }
    }
}