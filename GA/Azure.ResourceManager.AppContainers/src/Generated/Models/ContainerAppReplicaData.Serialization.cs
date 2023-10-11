// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppReplicaData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Containers))
            {
                writer.WritePropertyName("containers"u8);
                writer.WriteStartArray();
                foreach (var item in Containers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(InitContainers))
            {
                writer.WritePropertyName("initContainers"u8);
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerAppReplicaData DeserializeContainerAppReplicaData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<ContainerAppReplicaRunningState> runningState = default;
            Optional<string> runningStateDetails = default;
            Optional<IList<ContainerAppReplicaContainer>> containers = default;
            Optional<IList<ContainerAppReplicaContainer>> initContainers = default;
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
                        if (property0.NameEquals("createdTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("runningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runningState = new ContainerAppReplicaRunningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("runningStateDetails"u8))
                        {
                            runningStateDetails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerAppReplicaContainer> array = new List<ContainerAppReplicaContainer>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerAppReplicaContainer.DeserializeContainerAppReplicaContainer(item));
                            }
                            containers = array;
                            continue;
                        }
                        if (property0.NameEquals("initContainers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerAppReplicaContainer> array = new List<ContainerAppReplicaContainer>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerAppReplicaContainer.DeserializeContainerAppReplicaContainer(item));
                            }
                            initContainers = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerAppReplicaData(id, name, type, systemData.Value, Optional.ToNullable(createdTime), Optional.ToNullable(runningState), runningStateDetails.Value, Optional.ToList(containers), Optional.ToList(initContainers));
        }
    }
}