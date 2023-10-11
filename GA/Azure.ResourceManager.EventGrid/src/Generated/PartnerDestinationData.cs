// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the PartnerDestination data model.
    /// Event Grid Partner Destination.
    /// </summary>
    public partial class PartnerDestinationData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of PartnerDestinationData. </summary>
        /// <param name="location"> The location. </param>
        public PartnerDestinationData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of PartnerDestinationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="partnerRegistrationImmutableId"> The immutable Id of the corresponding partner registration. </param>
        /// <param name="endpointServiceContext"> Endpoint context associated with this partner destination. </param>
        /// <param name="expirationTimeIfNotActivatedUtc">
        /// Expiration time of the partner destination. If this timer expires and the partner destination was never activated,
        /// the partner destination and corresponding channel are deleted.
        /// </param>
        /// <param name="provisioningState"> Provisioning state of the partner destination. </param>
        /// <param name="activationState"> Activation state of the partner destination. </param>
        /// <param name="endpointBaseUri"> Endpoint Base URL of the partner destination. </param>
        /// <param name="messageForActivation"> Context or helpful message that can be used during the approval process. </param>
        internal PartnerDestinationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Guid? partnerRegistrationImmutableId, string endpointServiceContext, DateTimeOffset? expirationTimeIfNotActivatedUtc, PartnerDestinationProvisioningState? provisioningState, PartnerDestinationActivationState? activationState, Uri endpointBaseUri, string messageForActivation) : base(id, name, resourceType, systemData, tags, location)
        {
            PartnerRegistrationImmutableId = partnerRegistrationImmutableId;
            EndpointServiceContext = endpointServiceContext;
            ExpirationTimeIfNotActivatedUtc = expirationTimeIfNotActivatedUtc;
            ProvisioningState = provisioningState;
            ActivationState = activationState;
            EndpointBaseUri = endpointBaseUri;
            MessageForActivation = messageForActivation;
        }

        /// <summary> The immutable Id of the corresponding partner registration. </summary>
        public Guid? PartnerRegistrationImmutableId { get; set; }
        /// <summary> Endpoint context associated with this partner destination. </summary>
        public string EndpointServiceContext { get; set; }
        /// <summary>
        /// Expiration time of the partner destination. If this timer expires and the partner destination was never activated,
        /// the partner destination and corresponding channel are deleted.
        /// </summary>
        public DateTimeOffset? ExpirationTimeIfNotActivatedUtc { get; set; }
        /// <summary> Provisioning state of the partner destination. </summary>
        public PartnerDestinationProvisioningState? ProvisioningState { get; }
        /// <summary> Activation state of the partner destination. </summary>
        public PartnerDestinationActivationState? ActivationState { get; set; }
        /// <summary> Endpoint Base URL of the partner destination. </summary>
        public Uri EndpointBaseUri { get; set; }
        /// <summary> Context or helpful message that can be used during the approval process. </summary>
        public string MessageForActivation { get; set; }
    }
}