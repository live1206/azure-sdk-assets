// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing the DevTestLabArtifact data model.
    /// An artifact.
    /// </summary>
    public partial class DevTestLabArtifactData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DevTestLabArtifactData. </summary>
        /// <param name="location"> The location. </param>
        public DevTestLabArtifactData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of DevTestLabArtifactData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="title"> The artifact's title. </param>
        /// <param name="description"> The artifact's description. </param>
        /// <param name="publisher"> The artifact's publisher. </param>
        /// <param name="filePath"> The file path to the artifact. </param>
        /// <param name="icon"> The URI to the artifact icon. </param>
        /// <param name="targetOSType"> The artifact's target OS. </param>
        /// <param name="parameters"> The artifact's parameters. </param>
        /// <param name="createdOn"> The artifact's creation date. </param>
        internal DevTestLabArtifactData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string title, string description, string publisher, string filePath, string icon, string targetOSType, BinaryData parameters, DateTimeOffset? createdOn) : base(id, name, resourceType, systemData, tags, location)
        {
            Title = title;
            Description = description;
            Publisher = publisher;
            FilePath = filePath;
            Icon = icon;
            TargetOSType = targetOSType;
            Parameters = parameters;
            CreatedOn = createdOn;
        }

        /// <summary> The artifact's title. </summary>
        public string Title { get; }
        /// <summary> The artifact's description. </summary>
        public string Description { get; }
        /// <summary> The artifact's publisher. </summary>
        public string Publisher { get; }
        /// <summary> The file path to the artifact. </summary>
        public string FilePath { get; }
        /// <summary> The URI to the artifact icon. </summary>
        public string Icon { get; }
        /// <summary> The artifact's target OS. </summary>
        public string TargetOSType { get; }
        /// <summary>
        /// The artifact's parameters.
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
        public BinaryData Parameters { get; }
        /// <summary> The artifact's creation date. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}