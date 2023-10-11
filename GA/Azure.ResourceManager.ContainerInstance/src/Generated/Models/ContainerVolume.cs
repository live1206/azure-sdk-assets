// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The properties of the volume. </summary>
    public partial class ContainerVolume
    {
        /// <summary> Initializes a new instance of ContainerVolume. </summary>
        /// <param name="name"> The name of the volume. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ContainerVolume(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Secret = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ContainerVolume. </summary>
        /// <param name="name"> The name of the volume. </param>
        /// <param name="azureFile"> The Azure File volume. </param>
        /// <param name="emptyDir"> The empty directory volume. </param>
        /// <param name="secret"> The secret volume. </param>
        /// <param name="gitRepo"> The git repo volume. </param>
        internal ContainerVolume(string name, ContainerInstanceAzureFileVolume azureFile, BinaryData emptyDir, IDictionary<string, string> secret, ContainerInstanceGitRepoVolume gitRepo)
        {
            Name = name;
            AzureFile = azureFile;
            EmptyDir = emptyDir;
            Secret = secret;
            GitRepo = gitRepo;
        }

        /// <summary> The name of the volume. </summary>
        public string Name { get; set; }
        /// <summary> The Azure File volume. </summary>
        public ContainerInstanceAzureFileVolume AzureFile { get; set; }
        /// <summary>
        /// The empty directory volume.
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
        public BinaryData EmptyDir { get; set; }
        /// <summary> The secret volume. </summary>
        public IDictionary<string, string> Secret { get; }
        /// <summary> The git repo volume. </summary>
        public ContainerInstanceGitRepoVolume GitRepo { get; set; }
    }
}