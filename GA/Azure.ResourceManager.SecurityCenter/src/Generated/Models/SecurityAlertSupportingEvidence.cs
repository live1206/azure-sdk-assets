// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Changing set of properties depending on the supportingEvidence type. </summary>
    public partial class SecurityAlertSupportingEvidence
    {
        /// <summary> Initializes a new instance of SecurityAlertSupportingEvidence. </summary>
        public SecurityAlertSupportingEvidence()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of SecurityAlertSupportingEvidence. </summary>
        /// <param name="securityAlertSupportingEvidenceType"> Type of the supportingEvidence. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SecurityAlertSupportingEvidence(string securityAlertSupportingEvidenceType, IDictionary<string, BinaryData> additionalProperties)
        {
            SecurityAlertSupportingEvidenceType = securityAlertSupportingEvidenceType;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Type of the supportingEvidence. </summary>
        public string SecurityAlertSupportingEvidenceType { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}