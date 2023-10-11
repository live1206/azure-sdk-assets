// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The tracking event. </summary>
    public partial class IntegrationAccountTrackingEvent
    {
        /// <summary> Initializes a new instance of IntegrationAccountTrackingEvent. </summary>
        /// <param name="eventLevel"> The event level. </param>
        /// <param name="eventOn"> The event time. </param>
        /// <param name="recordType"> The record type. </param>
        public IntegrationAccountTrackingEvent(IntegrationAccountEventLevel eventLevel, DateTimeOffset eventOn, IntegrationAccountTrackingRecordType recordType)
        {
            EventLevel = eventLevel;
            EventOn = eventOn;
            RecordType = recordType;
        }

        /// <summary> The event level. </summary>
        public IntegrationAccountEventLevel EventLevel { get; }
        /// <summary> The event time. </summary>
        public DateTimeOffset EventOn { get; }
        /// <summary> The record type. </summary>
        public IntegrationAccountTrackingRecordType RecordType { get; }
        /// <summary>
        /// The record.
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
        public BinaryData Record { get; set; }
        /// <summary> The error. </summary>
        public IntegrationAccountTrackingEventErrorInfo Error { get; set; }
    }
}