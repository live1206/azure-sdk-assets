// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ArmServiceTypeHealthPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxPercentUnhealthyServices))
            {
                writer.WritePropertyName("maxPercentUnhealthyServices"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyServices.Value);
            }
            if (Optional.IsDefined(MaxPercentUnhealthyPartitionsPerService))
            {
                writer.WritePropertyName("maxPercentUnhealthyPartitionsPerService"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyPartitionsPerService.Value);
            }
            if (Optional.IsDefined(MaxPercentUnhealthyReplicasPerPartition))
            {
                writer.WritePropertyName("maxPercentUnhealthyReplicasPerPartition"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyReplicasPerPartition.Value);
            }
            writer.WriteEndObject();
        }

        internal static ArmServiceTypeHealthPolicy DeserializeArmServiceTypeHealthPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxPercentUnhealthyServices = default;
            Optional<int> maxPercentUnhealthyPartitionsPerService = default;
            Optional<int> maxPercentUnhealthyReplicasPerPartition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentUnhealthyServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyServices = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyPartitionsPerService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyPartitionsPerService = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyReplicasPerPartition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyReplicasPerPartition = property.Value.GetInt32();
                    continue;
                }
            }
            return new ArmServiceTypeHealthPolicy(Optional.ToNullable(maxPercentUnhealthyServices), Optional.ToNullable(maxPercentUnhealthyPartitionsPerService), Optional.ToNullable(maxPercentUnhealthyReplicasPerPartition));
        }
    }
}