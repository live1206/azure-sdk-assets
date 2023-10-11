// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing the IntegrationAccountPartner data model.
    /// The integration account partner.
    /// </summary>
    public partial class IntegrationAccountPartnerData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IntegrationAccountPartnerData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="partnerType"> The partner type. </param>
        /// <param name="content"> The partner content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public IntegrationAccountPartnerData(AzureLocation location, IntegrationAccountPartnerType partnerType, IntegrationAccountPartnerContent content) : base(location)
        {
            Argument.AssertNotNull(content, nameof(content));

            PartnerType = partnerType;
            Content = content;
        }

        /// <summary> Initializes a new instance of IntegrationAccountPartnerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="partnerType"> The partner type. </param>
        /// <param name="createdOn"> The created time. </param>
        /// <param name="changedOn"> The changed time. </param>
        /// <param name="metadata"> The metadata. </param>
        /// <param name="content"> The partner content. </param>
        internal IntegrationAccountPartnerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IntegrationAccountPartnerType partnerType, DateTimeOffset? createdOn, DateTimeOffset? changedOn, BinaryData metadata, IntegrationAccountPartnerContent content) : base(id, name, resourceType, systemData, tags, location)
        {
            PartnerType = partnerType;
            CreatedOn = createdOn;
            ChangedOn = changedOn;
            Metadata = metadata;
            Content = content;
        }

        /// <summary> The partner type. </summary>
        public IntegrationAccountPartnerType PartnerType { get; set; }
        /// <summary> The created time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The changed time. </summary>
        public DateTimeOffset? ChangedOn { get; }
        /// <summary>
        /// The metadata.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Metadata { get; set; }
        /// <summary> The partner content. </summary>
        internal IntegrationAccountPartnerContent Content { get; set; }
        /// <summary> The list of partner business identities. </summary>
        public IList<IntegrationAccountBusinessIdentity> B2BBusinessIdentities
        {
            get
            {
                if (Content is null)
                    Content = new IntegrationAccountPartnerContent();
                return Content.B2BBusinessIdentities;
            }
        }
    }
}