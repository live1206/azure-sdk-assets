// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Global configuration for services in the cluster. </summary>
    public partial class GlobalServiceConfiguration
    {
        /// <summary> Initializes a new instance of GlobalServiceConfiguration. </summary>
        public GlobalServiceConfiguration()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of GlobalServiceConfiguration. </summary>
        /// <param name="etag"> The configuration ETag for updates. </param>
        /// <param name="ssl"> The SSL configuration properties. </param>
        /// <param name="serviceAuth"> Optional global authorization keys for all user services deployed in cluster. These are used if the service does not have auth keys. </param>
        /// <param name="autoScale"> The auto-scale configuration. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal GlobalServiceConfiguration(ETag? etag, SslConfiguration ssl, ServiceAuthConfiguration serviceAuth, AutoScaleConfiguration autoScale, IDictionary<string, BinaryData> additionalProperties)
        {
            ETag = etag;
            Ssl = ssl;
            ServiceAuth = serviceAuth;
            AutoScale = autoScale;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The configuration ETag for updates. </summary>
        public ETag? ETag { get; set; }
        /// <summary> The SSL configuration properties. </summary>
        public SslConfiguration Ssl { get; set; }
        /// <summary> Optional global authorization keys for all user services deployed in cluster. These are used if the service does not have auth keys. </summary>
        public ServiceAuthConfiguration ServiceAuth { get; set; }
        /// <summary> The auto-scale configuration. </summary>
        public AutoScaleConfiguration AutoScale { get; set; }
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