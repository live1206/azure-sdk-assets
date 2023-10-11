// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Properties that define a Azure Arc PrivateLinkScope resource. </summary>
    public partial class HybridComputePrivateLinkScopeProperties
    {
        /// <summary> Initializes a new instance of HybridComputePrivateLinkScopeProperties. </summary>
        public HybridComputePrivateLinkScopeProperties()
        {
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionDataModel>();
        }

        /// <summary> Initializes a new instance of HybridComputePrivateLinkScopeProperties. </summary>
        /// <param name="publicNetworkAccess"> Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints. </param>
        /// <param name="provisioningState"> Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and Failed. </param>
        /// <param name="privateLinkScopeId"> The Guid id of the private link scope. </param>
        /// <param name="privateEndpointConnections"> The collection of associated Private Endpoint Connections. </param>
        internal HybridComputePrivateLinkScopeProperties(PublicNetworkAccessType? publicNetworkAccess, string provisioningState, string privateLinkScopeId, IReadOnlyList<PrivateEndpointConnectionDataModel> privateEndpointConnections)
        {
            PublicNetworkAccess = publicNetworkAccess;
            ProvisioningState = provisioningState;
            PrivateLinkScopeId = privateLinkScopeId;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary> Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints. </summary>
        public PublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary> Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and Failed. </summary>
        public string ProvisioningState { get; }
        /// <summary> The Guid id of the private link scope. </summary>
        public string PrivateLinkScopeId { get; }
        /// <summary> The collection of associated Private Endpoint Connections. </summary>
        public IReadOnlyList<PrivateEndpointConnectionDataModel> PrivateEndpointConnections { get; }
    }
}