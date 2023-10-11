// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Advisor
{
    /// <summary>
    /// A class representing the SuppressionContract data model.
    /// The details of the snoozed or dismissed rule; for example, the duration, name, and GUID associated with the rule.
    /// </summary>
    public partial class SuppressionContractData : ResourceData
    {
        /// <summary> Initializes a new instance of SuppressionContractData. </summary>
        public SuppressionContractData()
        {
        }

        /// <summary> Initializes a new instance of SuppressionContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="suppressionId"> The GUID of the suppression. </param>
        /// <param name="ttl"> The duration for which the suppression is valid. </param>
        /// <param name="expirationTimeStamp"> Gets or sets the expiration time stamp. </param>
        internal SuppressionContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string suppressionId, string ttl, DateTimeOffset? expirationTimeStamp) : base(id, name, resourceType, systemData)
        {
            SuppressionId = suppressionId;
            Ttl = ttl;
            ExpirationTimeStamp = expirationTimeStamp;
        }

        /// <summary> The GUID of the suppression. </summary>
        public string SuppressionId { get; set; }
        /// <summary> The duration for which the suppression is valid. </summary>
        public string Ttl { get; set; }
        /// <summary> Gets or sets the expiration time stamp. </summary>
        public DateTimeOffset? ExpirationTimeStamp { get; }
    }
}