// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Event model properties. </summary>
    public partial class DataReplicationEventProperties
    {
        /// <summary> Initializes a new instance of DataReplicationEventProperties. </summary>
        /// <param name="customProperties">
        /// Event model custom properties.
        /// Please note <see cref="EventModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciEventModelCustomProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customProperties"/> is null. </exception>
        internal DataReplicationEventProperties(EventModelCustomProperties customProperties)
        {
            Argument.AssertNotNull(customProperties, nameof(customProperties));

            HealthErrors = new ChangeTrackingList<DataReplicationHealthErrorInfo>();
            CustomProperties = customProperties;
        }

        /// <summary> Initializes a new instance of DataReplicationEventProperties. </summary>
        /// <param name="resourceType"> Gets or sets the resource type. </param>
        /// <param name="resourceName"> Gets or sets the resource name. </param>
        /// <param name="eventType"> Gets or sets the event type. </param>
        /// <param name="eventName"> Gets or sets the event name. </param>
        /// <param name="occurredOn"> Gets or sets the time at which the event occurred at source. </param>
        /// <param name="severity"> Gets or sets the event severity. </param>
        /// <param name="description"> Gets or sets the event description. </param>
        /// <param name="correlationId"> Gets or sets the event correlation Id. </param>
        /// <param name="healthErrors"> Gets or sets the errors associated with this event. </param>
        /// <param name="customProperties">
        /// Event model custom properties.
        /// Please note <see cref="EventModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciEventModelCustomProperties"/>.
        /// </param>
        internal DataReplicationEventProperties(ResourceType? resourceType, string resourceName, string eventType, string eventName, DateTimeOffset? occurredOn, string severity, string description, string correlationId, IReadOnlyList<DataReplicationHealthErrorInfo> healthErrors, EventModelCustomProperties customProperties)
        {
            ResourceType = resourceType;
            ResourceName = resourceName;
            EventType = eventType;
            EventName = eventName;
            OccurredOn = occurredOn;
            Severity = severity;
            Description = description;
            CorrelationId = correlationId;
            HealthErrors = healthErrors;
            CustomProperties = customProperties;
        }

        /// <summary> Gets or sets the resource type. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> Gets or sets the resource name. </summary>
        public string ResourceName { get; }
        /// <summary> Gets or sets the event type. </summary>
        public string EventType { get; }
        /// <summary> Gets or sets the event name. </summary>
        public string EventName { get; }
        /// <summary> Gets or sets the time at which the event occurred at source. </summary>
        public DateTimeOffset? OccurredOn { get; }
        /// <summary> Gets or sets the event severity. </summary>
        public string Severity { get; }
        /// <summary> Gets or sets the event description. </summary>
        public string Description { get; }
        /// <summary> Gets or sets the event correlation Id. </summary>
        public string CorrelationId { get; }
        /// <summary> Gets or sets the errors associated with this event. </summary>
        public IReadOnlyList<DataReplicationHealthErrorInfo> HealthErrors { get; }
        /// <summary>
        /// Event model custom properties.
        /// Please note <see cref="EventModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciEventModelCustomProperties"/>.
        /// </summary>
        public EventModelCustomProperties CustomProperties { get; }
    }
}