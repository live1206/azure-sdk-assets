// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedServiceScalingTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static ManagedServiceScalingTrigger DeserializeManagedServiceScalingTrigger(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AveragePartitionLoadTrigger": return AveragePartitionLoadScalingTrigger.DeserializeAveragePartitionLoadScalingTrigger(element);
                    case "AverageServiceLoadTrigger": return AverageServiceLoadScalingTrigger.DeserializeAverageServiceLoadScalingTrigger(element);
                }
            }
            return UnknownScalingTrigger.DeserializeUnknownScalingTrigger(element);
        }
    }
}