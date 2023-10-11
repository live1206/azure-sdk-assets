// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged Gateway certificate authority list representation. </summary>
    internal partial class GatewayCertificateAuthorityListResult
    {
        /// <summary> Initializes a new instance of GatewayCertificateAuthorityListResult. </summary>
        internal GatewayCertificateAuthorityListResult()
        {
            Value = new ChangeTrackingList<ApiManagementGatewayCertificateAuthorityData>();
        }

        /// <summary> Initializes a new instance of GatewayCertificateAuthorityListResult. </summary>
        /// <param name="value"> Page values. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal GatewayCertificateAuthorityListResult(IReadOnlyList<ApiManagementGatewayCertificateAuthorityData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Page values. </summary>
        public IReadOnlyList<ApiManagementGatewayCertificateAuthorityData> Value { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}