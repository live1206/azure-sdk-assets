// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Result of the request to list frontend endpoints. It contains a list of Frontend endpoint objects and a URL link to get the next set of results. </summary>
    internal partial class FrontendEndpointsListResult
    {
        /// <summary> Initializes a new instance of FrontendEndpointsListResult. </summary>
        internal FrontendEndpointsListResult()
        {
            Value = new ChangeTrackingList<FrontendEndpointData>();
        }

        /// <summary> Initializes a new instance of FrontendEndpointsListResult. </summary>
        /// <param name="value"> List of Frontend endpoints within a Front Door. </param>
        /// <param name="nextLink"> URL to get the next set of frontend endpoints if there are any. </param>
        internal FrontendEndpointsListResult(IReadOnlyList<FrontendEndpointData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Frontend endpoints within a Front Door. </summary>
        public IReadOnlyList<FrontendEndpointData> Value { get; }
        /// <summary> URL to get the next set of frontend endpoints if there are any. </summary>
        public string NextLink { get; }
    }
}