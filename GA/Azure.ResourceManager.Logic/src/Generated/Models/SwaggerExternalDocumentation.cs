// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The swagger external documentation. </summary>
    public partial class SwaggerExternalDocumentation
    {
        /// <summary> Initializes a new instance of SwaggerExternalDocumentation. </summary>
        public SwaggerExternalDocumentation()
        {
            Extensions = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of SwaggerExternalDocumentation. </summary>
        /// <param name="description"> The document description. </param>
        /// <param name="uri"> The documentation Uri. </param>
        /// <param name="extensions"> The vendor extensions. </param>
        internal SwaggerExternalDocumentation(string description, Uri uri, IDictionary<string, BinaryData> extensions)
        {
            Description = description;
            Uri = uri;
            Extensions = extensions;
        }

        /// <summary> The document description. </summary>
        public string Description { get; set; }
        /// <summary> The documentation Uri. </summary>
        public Uri Uri { get; set; }
        /// <summary>
        /// The vendor extensions.
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
        public IDictionary<string, BinaryData> Extensions { get; }
    }
}