// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Blueprint.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Blueprint
{
    public partial class AssignmentOperationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BlueprintVersion))
            {
                writer.WritePropertyName("blueprintVersion"u8);
                writer.WriteStringValue(BlueprintVersion);
            }
            if (Optional.IsDefined(AssignmentState))
            {
                writer.WritePropertyName("assignmentState"u8);
                writer.WriteStringValue(AssignmentState);
            }
            if (Optional.IsDefined(TimeCreated))
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(TimeCreated);
            }
            if (Optional.IsDefined(TimeStarted))
            {
                writer.WritePropertyName("timeStarted"u8);
                writer.WriteStringValue(TimeStarted);
            }
            if (Optional.IsDefined(TimeFinished))
            {
                writer.WritePropertyName("timeFinished"u8);
                writer.WriteStringValue(TimeFinished);
            }
            if (Optional.IsCollectionDefined(Deployments))
            {
                writer.WritePropertyName("deployments"u8);
                writer.WriteStartArray();
                foreach (var item in Deployments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AssignmentOperationData DeserializeAssignmentOperationData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> blueprintVersion = default;
            Optional<string> assignmentState = default;
            Optional<string> timeCreated = default;
            Optional<string> timeStarted = default;
            Optional<string> timeFinished = default;
            Optional<IList<AssignmentDeploymentJob>> deployments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("blueprintVersion"u8))
                        {
                            blueprintVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("assignmentState"u8))
                        {
                            assignmentState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeCreated"u8))
                        {
                            timeCreated = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeStarted"u8))
                        {
                            timeStarted = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeFinished"u8))
                        {
                            timeFinished = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deployments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AssignmentDeploymentJob> array = new List<AssignmentDeploymentJob>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AssignmentDeploymentJob.DeserializeAssignmentDeploymentJob(item));
                            }
                            deployments = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AssignmentOperationData(id, name, type, systemData.Value, blueprintVersion.Value, assignmentState.Value, timeCreated.Value, timeStarted.Value, timeFinished.Value, Optional.ToList(deployments));
        }
    }
}