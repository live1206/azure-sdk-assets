// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Information about the update of the WebHook of the partner destination. </summary>
    public partial class WebhookUpdatePartnerDestinationInfo : PartnerUpdateDestinationInfo
    {
        /// <summary> Initializes a new instance of WebhookUpdatePartnerDestinationInfo. </summary>
        public WebhookUpdatePartnerDestinationInfo()
        {
            EndpointType = PartnerEndpointType.WebHook;
        }

        /// <summary> The URL that represents the endpoint of the partner destination. </summary>
        public Uri EndpointUri { get; set; }
        /// <summary> The base URL that represents the endpoint of the partner destination. </summary>
        public Uri EndpointBaseUri { get; set; }
        /// <summary>
        /// Partner client authentication
        /// Please note <see cref="PartnerClientAuthentication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureADPartnerClientAuthentication"/>.
        /// </summary>
        public PartnerClientAuthentication ClientAuthentication { get; set; }
    }
}