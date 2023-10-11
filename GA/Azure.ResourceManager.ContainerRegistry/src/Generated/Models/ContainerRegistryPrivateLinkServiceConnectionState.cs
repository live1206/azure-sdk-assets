// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The state of a private link service connection. </summary>
    public partial class ContainerRegistryPrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of ContainerRegistryPrivateLinkServiceConnectionState. </summary>
        public ContainerRegistryPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryPrivateLinkServiceConnectionState. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The description for connection status. For example if connection is rejected it can indicate reason for rejection. </param>
        /// <param name="actionsRequired"> A message indicating if changes on the service provider require any updates on the consumer. </param>
        internal ContainerRegistryPrivateLinkServiceConnectionState(ContainerRegistryPrivateLinkServiceConnectionStatus? status, string description, ActionsRequiredForPrivateLinkServiceConsumer? actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The private link service connection status. </summary>
        public ContainerRegistryPrivateLinkServiceConnectionStatus? Status { get; set; }
        /// <summary> The description for connection status. For example if connection is rejected it can indicate reason for rejection. </summary>
        public string Description { get; set; }
        /// <summary> A message indicating if changes on the service provider require any updates on the consumer. </summary>
        public ActionsRequiredForPrivateLinkServiceConsumer? ActionsRequired { get; set; }
    }
}