// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of a request to list private endpoint connections for a container registry. </summary>
    internal partial class ContainerRegistryPrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of ContainerRegistryPrivateEndpointConnectionListResult. </summary>
        internal ContainerRegistryPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<ContainerRegistryPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryPrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> The list of private endpoint connections. Since this list may be incomplete, the nextLink field should be used to request the next list of private endpoint connections. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of private endpoint connections. </param>
        internal ContainerRegistryPrivateEndpointConnectionListResult(IReadOnlyList<ContainerRegistryPrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of private endpoint connections. Since this list may be incomplete, the nextLink field should be used to request the next list of private endpoint connections. </summary>
        public IReadOnlyList<ContainerRegistryPrivateEndpointConnectionData> Value { get; }
        /// <summary> The URI that can be used to request the next list of private endpoint connections. </summary>
        public string NextLink { get; }
    }
}