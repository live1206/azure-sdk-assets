// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The response containing list of capabilities. </summary>
    internal partial class ContainerCapabilitiesListResult
    {
        /// <summary> Initializes a new instance of ContainerCapabilitiesListResult. </summary>
        internal ContainerCapabilitiesListResult()
        {
            Value = new ChangeTrackingList<ContainerCapabilities>();
        }

        /// <summary> Initializes a new instance of ContainerCapabilitiesListResult. </summary>
        /// <param name="value"> The list of capabilities. </param>
        /// <param name="nextLink"> The URI to fetch the next page of capabilities. </param>
        internal ContainerCapabilitiesListResult(IReadOnlyList<ContainerCapabilities> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of capabilities. </summary>
        public IReadOnlyList<ContainerCapabilities> Value { get; }
        /// <summary> The URI to fetch the next page of capabilities. </summary>
        public string NextLink { get; }
    }
}