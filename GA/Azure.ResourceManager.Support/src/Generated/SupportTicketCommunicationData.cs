// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing the SupportTicketCommunication data model.
    /// Object that represents a Communication resource.
    /// </summary>
    public partial class SupportTicketCommunicationData : ResourceData
    {
        /// <summary> Initializes a new instance of SupportTicketCommunicationData. </summary>
        public SupportTicketCommunicationData()
        {
        }

        /// <summary> Initializes a new instance of SupportTicketCommunicationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="communicationType"> Communication type. </param>
        /// <param name="communicationDirection"> Direction of communication. </param>
        /// <param name="sender"> Email address of the sender. This property is required if called by a service principal. </param>
        /// <param name="subject"> Subject of the communication. </param>
        /// <param name="body"> Body of the communication. </param>
        /// <param name="createdOn"> Time in UTC (ISO 8601 format) when the communication was created. </param>
        internal SupportTicketCommunicationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SupportTicketCommunicationType? communicationType, SupportTicketCommunicationDirection? communicationDirection, string sender, string subject, string body, DateTimeOffset? createdOn) : base(id, name, resourceType, systemData)
        {
            CommunicationType = communicationType;
            CommunicationDirection = communicationDirection;
            Sender = sender;
            Subject = subject;
            Body = body;
            CreatedOn = createdOn;
        }

        /// <summary> Communication type. </summary>
        public SupportTicketCommunicationType? CommunicationType { get; }
        /// <summary> Direction of communication. </summary>
        public SupportTicketCommunicationDirection? CommunicationDirection { get; }
        /// <summary> Email address of the sender. This property is required if called by a service principal. </summary>
        public string Sender { get; set; }
        /// <summary> Subject of the communication. </summary>
        public string Subject { get; set; }
        /// <summary> Body of the communication. </summary>
        public string Body { get; set; }
        /// <summary> Time in UTC (ISO 8601 format) when the communication was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}