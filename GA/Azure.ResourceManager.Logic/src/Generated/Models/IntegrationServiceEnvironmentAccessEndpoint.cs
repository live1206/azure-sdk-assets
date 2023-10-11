// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration service environment access endpoint. </summary>
    internal partial class IntegrationServiceEnvironmentAccessEndpoint
    {
        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentAccessEndpoint. </summary>
        public IntegrationServiceEnvironmentAccessEndpoint()
        {
        }

        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentAccessEndpoint. </summary>
        /// <param name="endpointType"> The access endpoint type. </param>
        internal IntegrationServiceEnvironmentAccessEndpoint(IntegrationServiceEnvironmentAccessEndpointType? endpointType)
        {
            EndpointType = endpointType;
        }

        /// <summary> The access endpoint type. </summary>
        public IntegrationServiceEnvironmentAccessEndpointType? EndpointType { get; set; }
    }
}