// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a process entity. </summary>
    public partial class SecurityInsightsProcessEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of SecurityInsightsProcessEntity. </summary>
        public SecurityInsightsProcessEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = SecurityInsightsEntityKind.Process;
        }

        /// <summary> Initializes a new instance of SecurityInsightsProcessEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="accountEntityId"> The account entity id running the processes. </param>
        /// <param name="commandLine"> The command line used to create the process. </param>
        /// <param name="createdOn"> The time when the process started to run. </param>
        /// <param name="elevationToken"> The elevation token associated with the process. </param>
        /// <param name="hostEntityId"> The host entity id on which the process was running. </param>
        /// <param name="hostLogonSessionEntityId"> The session entity id in which the process was running. </param>
        /// <param name="imageFileEntityId"> Image file entity id. </param>
        /// <param name="parentProcessEntityId"> The parent process entity id. </param>
        /// <param name="processId"> The process ID. </param>
        internal SecurityInsightsProcessEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, string accountEntityId, string commandLine, DateTimeOffset? createdOn, SecurityInsightsProcessElevationToken? elevationToken, string hostEntityId, string hostLogonSessionEntityId, string imageFileEntityId, string parentProcessEntityId, string processId) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            AccountEntityId = accountEntityId;
            CommandLine = commandLine;
            CreatedOn = createdOn;
            ElevationToken = elevationToken;
            HostEntityId = hostEntityId;
            HostLogonSessionEntityId = hostLogonSessionEntityId;
            ImageFileEntityId = imageFileEntityId;
            ParentProcessEntityId = parentProcessEntityId;
            ProcessId = processId;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The account entity id running the processes. </summary>
        public string AccountEntityId { get; }
        /// <summary> The command line used to create the process. </summary>
        public string CommandLine { get; }
        /// <summary> The time when the process started to run. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The elevation token associated with the process. </summary>
        public SecurityInsightsProcessElevationToken? ElevationToken { get; set; }
        /// <summary> The host entity id on which the process was running. </summary>
        public string HostEntityId { get; }
        /// <summary> The session entity id in which the process was running. </summary>
        public string HostLogonSessionEntityId { get; }
        /// <summary> Image file entity id. </summary>
        public string ImageFileEntityId { get; }
        /// <summary> The parent process entity id. </summary>
        public string ParentProcessEntityId { get; }
        /// <summary> The process ID. </summary>
        public string ProcessId { get; }
    }
}
