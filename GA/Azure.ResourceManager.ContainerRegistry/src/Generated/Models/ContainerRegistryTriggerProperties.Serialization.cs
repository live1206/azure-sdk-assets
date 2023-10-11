// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryTriggerProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TimerTriggers))
            {
                writer.WritePropertyName("timerTriggers"u8);
                writer.WriteStartArray();
                foreach (var item in TimerTriggers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceTriggers))
            {
                writer.WritePropertyName("sourceTriggers"u8);
                writer.WriteStartArray();
                foreach (var item in SourceTriggers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BaseImageTrigger))
            {
                writer.WritePropertyName("baseImageTrigger"u8);
                writer.WriteObjectValue(BaseImageTrigger);
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistryTriggerProperties DeserializeContainerRegistryTriggerProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ContainerRegistryTimerTrigger>> timerTriggers = default;
            Optional<IList<ContainerRegistrySourceTrigger>> sourceTriggers = default;
            Optional<ContainerRegistryBaseImageTrigger> baseImageTrigger = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timerTriggers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTimerTrigger> array = new List<ContainerRegistryTimerTrigger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTimerTrigger.DeserializeContainerRegistryTimerTrigger(item));
                    }
                    timerTriggers = array;
                    continue;
                }
                if (property.NameEquals("sourceTriggers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistrySourceTrigger> array = new List<ContainerRegistrySourceTrigger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistrySourceTrigger.DeserializeContainerRegistrySourceTrigger(item));
                    }
                    sourceTriggers = array;
                    continue;
                }
                if (property.NameEquals("baseImageTrigger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    baseImageTrigger = ContainerRegistryBaseImageTrigger.DeserializeContainerRegistryBaseImageTrigger(property.Value);
                    continue;
                }
            }
            return new ContainerRegistryTriggerProperties(Optional.ToList(timerTriggers), Optional.ToList(sourceTriggers), baseImageTrigger.Value);
        }
    }
}