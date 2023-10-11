// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Result of the list of all private endpoint connections operation. </summary>
    internal partial class ServiceBusPrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of ServiceBusPrivateEndpointConnectionListResult. </summary>
        internal ServiceBusPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<ServiceBusPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of ServiceBusPrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> A collection of private endpoint connection resources. </param>
        /// <param name="nextLink"> A link for the next page of private endpoint connection resources. </param>
        internal ServiceBusPrivateEndpointConnectionListResult(IReadOnlyList<ServiceBusPrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of private endpoint connection resources. </summary>
        public IReadOnlyList<ServiceBusPrivateEndpointConnectionData> Value { get; }
        /// <summary> A link for the next page of private endpoint connection resources. </summary>
        public string NextLink { get; }
    }
}