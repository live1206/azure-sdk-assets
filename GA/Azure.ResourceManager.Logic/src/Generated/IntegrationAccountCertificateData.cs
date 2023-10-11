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
    /// A class representing the IntegrationAccountCertificate data model.
    /// The integration account certificate.
    /// </summary>
    public partial class IntegrationAccountCertificateData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IntegrationAccountCertificateData. </summary>
        /// <param name="location"> The location. </param>
        public IntegrationAccountCertificateData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of IntegrationAccountCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="createdOn"> The created time. </param>
        /// <param name="changedOn"> The changed time. </param>
        /// <param name="metadata"> The metadata. </param>
        /// <param name="key"> The key details in the key vault. </param>
        /// <param name="publicCertificate"> The public certificate. </param>
        internal IntegrationAccountCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DateTimeOffset? createdOn, DateTimeOffset? changedOn, BinaryData metadata, IntegrationAccountKeyVaultKeyReference key, BinaryData publicCertificate) : base(id, name, resourceType, systemData, tags, location)
        {
            CreatedOn = createdOn;
            ChangedOn = changedOn;
            Metadata = metadata;
            Key = key;
            PublicCertificate = publicCertificate;
        }

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
        /// <summary> The key details in the key vault. </summary>
        public IntegrationAccountKeyVaultKeyReference Key { get; set; }
        /// <summary>
        /// The public certificate.
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
        public BinaryData PublicCertificate { get; set; }
    }
}