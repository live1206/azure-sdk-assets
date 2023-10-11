// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterWorkloadAutoScalerProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Keda))
            {
                writer.WritePropertyName("keda"u8);
                writer.WriteObjectValue(Keda);
            }
            if (Optional.IsDefined(VerticalPodAutoscaler))
            {
                writer.WritePropertyName("verticalPodAutoscaler"u8);
                writer.WriteObjectValue(VerticalPodAutoscaler);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterWorkloadAutoScalerProfile DeserializeManagedClusterWorkloadAutoScalerProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedClusterWorkloadAutoScalerProfileKeda> keda = default;
            Optional<ManagedClusterVerticalPodAutoscaler> verticalPodAutoscaler = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keda"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keda = ManagedClusterWorkloadAutoScalerProfileKeda.DeserializeManagedClusterWorkloadAutoScalerProfileKeda(property.Value);
                    continue;
                }
                if (property.NameEquals("verticalPodAutoscaler"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    verticalPodAutoscaler = ManagedClusterVerticalPodAutoscaler.DeserializeManagedClusterVerticalPodAutoscaler(property.Value);
                    continue;
                }
            }
            return new ManagedClusterWorkloadAutoScalerProfile(keda.Value, verticalPodAutoscaler.Value);
        }
    }
}