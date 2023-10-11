// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> A grouping of information about the connection to the remote resource. </summary>
    public partial class StreamAnalyticsPrivateLinkServiceConnection
    {
        /// <summary> Initializes a new instance of StreamAnalyticsPrivateLinkServiceConnection. </summary>
        public StreamAnalyticsPrivateLinkServiceConnection()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of StreamAnalyticsPrivateLinkServiceConnection. </summary>
        /// <param name="privateLinkServiceId"> The resource id of the private link service. Required on PUT (CreateOrUpdate) requests. </param>
        /// <param name="groupIds"> The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to. Required on PUT (CreateOrUpdate) requests. </param>
        /// <param name="requestMessage"> A message passed to the owner of the remote resource with this connection request. Restricted to 140 chars. </param>
        /// <param name="privateLinkServiceConnectionState"> A collection of read-only information about the state of the connection to the private remote resource. </param>
        internal StreamAnalyticsPrivateLinkServiceConnection(ResourceIdentifier privateLinkServiceId, IList<string> groupIds, string requestMessage, StreamAnalyticsPrivateLinkConnectionState privateLinkServiceConnectionState)
        {
            PrivateLinkServiceId = privateLinkServiceId;
            GroupIds = groupIds;
            RequestMessage = requestMessage;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        }

        /// <summary> The resource id of the private link service. Required on PUT (CreateOrUpdate) requests. </summary>
        public ResourceIdentifier PrivateLinkServiceId { get; set; }
        /// <summary> The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to. Required on PUT (CreateOrUpdate) requests. </summary>
        public IList<string> GroupIds { get; }
        /// <summary> A message passed to the owner of the remote resource with this connection request. Restricted to 140 chars. </summary>
        public string RequestMessage { get; }
        /// <summary> A collection of read-only information about the state of the connection to the private remote resource. </summary>
        public StreamAnalyticsPrivateLinkConnectionState PrivateLinkServiceConnectionState { get; set; }
    }
}