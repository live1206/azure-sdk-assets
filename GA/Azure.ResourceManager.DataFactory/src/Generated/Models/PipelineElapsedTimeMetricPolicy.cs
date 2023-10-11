// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Pipeline ElapsedTime Metric Policy. </summary>
    internal partial class PipelineElapsedTimeMetricPolicy
    {
        /// <summary> Initializes a new instance of PipelineElapsedTimeMetricPolicy. </summary>
        public PipelineElapsedTimeMetricPolicy()
        {
        }

        /// <summary> Initializes a new instance of PipelineElapsedTimeMetricPolicy. </summary>
        /// <param name="duration"> TimeSpan value, after which an Azure Monitoring Metric is fired. </param>
        internal PipelineElapsedTimeMetricPolicy(BinaryData duration)
        {
            Duration = duration;
        }

        /// <summary>
        /// TimeSpan value, after which an Azure Monitoring Metric is fired.
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
        public BinaryData Duration { get; set; }
    }
}
