// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class FlinkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storage"u8);
            writer.WriteObjectValue(Storage);
            if (Optional.IsDefined(NumReplicas))
            {
                writer.WritePropertyName("numReplicas"u8);
                writer.WriteNumberValue(NumReplicas.Value);
            }
            writer.WritePropertyName("jobManager"u8);
            writer.WriteObjectValue(JobManager);
            if (Optional.IsDefined(HistoryServer))
            {
                writer.WritePropertyName("historyServer"u8);
                writer.WriteObjectValue(HistoryServer);
            }
            writer.WritePropertyName("taskManager"u8);
            writer.WriteObjectValue(TaskManager);
            if (Optional.IsDefined(CatalogOptions))
            {
                writer.WritePropertyName("catalogOptions"u8);
                writer.WriteObjectValue(CatalogOptions);
            }
            writer.WriteEndObject();
        }

        internal static FlinkProfile DeserializeFlinkProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FlinkStorageProfile storage = default;
            Optional<int> numReplicas = default;
            ComputeResourceRequirement jobManager = default;
            Optional<ComputeResourceRequirement> historyServer = default;
            ComputeResourceRequirement taskManager = default;
            Optional<FlinkCatalogOptions> catalogOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storage"u8))
                {
                    storage = FlinkStorageProfile.DeserializeFlinkStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("numReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("jobManager"u8))
                {
                    jobManager = ComputeResourceRequirement.DeserializeComputeResourceRequirement(property.Value);
                    continue;
                }
                if (property.NameEquals("historyServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    historyServer = ComputeResourceRequirement.DeserializeComputeResourceRequirement(property.Value);
                    continue;
                }
                if (property.NameEquals("taskManager"u8))
                {
                    taskManager = ComputeResourceRequirement.DeserializeComputeResourceRequirement(property.Value);
                    continue;
                }
                if (property.NameEquals("catalogOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogOptions = FlinkCatalogOptions.DeserializeFlinkCatalogOptions(property.Value);
                    continue;
                }
            }
            return new FlinkProfile(storage, Optional.ToNullable(numReplicas), jobManager, historyServer.Value, taskManager, catalogOptions.Value);
        }
    }
}