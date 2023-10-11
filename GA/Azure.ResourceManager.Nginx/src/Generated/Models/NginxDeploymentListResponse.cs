// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Nginx;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxDeploymentListResponse. </summary>
    internal partial class NginxDeploymentListResponse
    {
        /// <summary> Initializes a new instance of NginxDeploymentListResponse. </summary>
        internal NginxDeploymentListResponse()
        {
            Value = new ChangeTrackingList<NginxDeploymentData>();
        }

        /// <summary> Initializes a new instance of NginxDeploymentListResponse. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal NginxDeploymentListResponse(IReadOnlyList<NginxDeploymentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<NginxDeploymentData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}