// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The NotificationRegistrationProperties. </summary>
    public partial class NotificationRegistrationProperties
    {
        /// <summary> Initializes a new instance of NotificationRegistrationProperties. </summary>
        public NotificationRegistrationProperties()
        {
            IncludedEvents = new ChangeTrackingList<string>();
            NotificationEndpoints = new ChangeTrackingList<NotificationEndpoint>();
        }

        /// <summary> Initializes a new instance of NotificationRegistrationProperties. </summary>
        /// <param name="notificationMode"></param>
        /// <param name="messageScope"></param>
        /// <param name="includedEvents"></param>
        /// <param name="notificationEndpoints"></param>
        /// <param name="provisioningState"></param>
        internal NotificationRegistrationProperties(NotificationMode? notificationMode, MessageScope? messageScope, IList<string> includedEvents, IList<NotificationEndpoint> notificationEndpoints, ProviderHubProvisioningState? provisioningState)
        {
            NotificationMode = notificationMode;
            MessageScope = messageScope;
            IncludedEvents = includedEvents;
            NotificationEndpoints = notificationEndpoints;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets or sets the notification mode. </summary>
        public NotificationMode? NotificationMode { get; set; }
        /// <summary> Gets or sets the message scope. </summary>
        public MessageScope? MessageScope { get; set; }
        /// <summary> Gets the included events. </summary>
        public IList<string> IncludedEvents { get; }
        /// <summary> Gets the notification endpoints. </summary>
        public IList<NotificationEndpoint> NotificationEndpoints { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public ProviderHubProvisioningState? ProvisioningState { get; set; }
    }
}