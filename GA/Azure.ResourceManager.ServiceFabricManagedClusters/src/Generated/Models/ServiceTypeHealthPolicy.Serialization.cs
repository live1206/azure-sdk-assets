// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServiceTypeHealthPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("maxPercentUnhealthyServices"u8);
            writer.WriteNumberValue(MaxPercentUnhealthyServices);
            writer.WritePropertyName("maxPercentUnhealthyPartitionsPerService"u8);
            writer.WriteNumberValue(MaxPercentUnhealthyPartitionsPerService);
            writer.WritePropertyName("maxPercentUnhealthyReplicasPerPartition"u8);
            writer.WriteNumberValue(MaxPercentUnhealthyReplicasPerPartition);
            writer.WriteEndObject();
        }

        internal static ServiceTypeHealthPolicy DeserializeServiceTypeHealthPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int maxPercentUnhealthyServices = default;
            int maxPercentUnhealthyPartitionsPerService = default;
            int maxPercentUnhealthyReplicasPerPartition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentUnhealthyServices"u8))
                {
                    maxPercentUnhealthyServices = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyPartitionsPerService"u8))
                {
                    maxPercentUnhealthyPartitionsPerService = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyReplicasPerPartition"u8))
                {
                    maxPercentUnhealthyReplicasPerPartition = property.Value.GetInt32();
                    continue;
                }
            }
            return new ServiceTypeHealthPolicy(maxPercentUnhealthyServices, maxPercentUnhealthyPartitionsPerService, maxPercentUnhealthyReplicasPerPartition);
        }
    }
}