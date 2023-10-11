// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ScalingHostPoolReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(HostPoolId))
            {
                writer.WritePropertyName("hostPoolArmPath"u8);
                writer.WriteStringValue(HostPoolId);
            }
            if (Optional.IsDefined(IsScalingPlanEnabled))
            {
                writer.WritePropertyName("scalingPlanEnabled"u8);
                writer.WriteBooleanValue(IsScalingPlanEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static ScalingHostPoolReference DeserializeScalingHostPoolReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> hostPoolArmPath = default;
            Optional<bool> scalingPlanEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostPoolArmPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostPoolArmPath = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scalingPlanEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scalingPlanEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ScalingHostPoolReference(hostPoolArmPath.Value, Optional.ToNullable(scalingPlanEnabled));
        }
    }
}