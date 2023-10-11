// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> An error response from the pod identity provisioning. </summary>
    internal partial class ManagedClusterPodIdentityProvisioningError
    {
        /// <summary> Initializes a new instance of ManagedClusterPodIdentityProvisioningError. </summary>
        internal ManagedClusterPodIdentityProvisioningError()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterPodIdentityProvisioningError. </summary>
        /// <param name="errorDetail"> Details about the error. </param>
        internal ManagedClusterPodIdentityProvisioningError(ResponseError errorDetail)
        {
            ErrorDetail = errorDetail;
        }

        /// <summary> Details about the error. </summary>
        public ResponseError ErrorDetail { get; }
    }
}