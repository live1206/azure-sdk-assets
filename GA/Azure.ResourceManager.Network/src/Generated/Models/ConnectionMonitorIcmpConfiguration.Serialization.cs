// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ConnectionMonitorIcmpConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisableTraceRoute))
            {
                writer.WritePropertyName("disableTraceRoute"u8);
                writer.WriteBooleanValue(DisableTraceRoute.Value);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorIcmpConfiguration DeserializeConnectionMonitorIcmpConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> disableTraceRoute = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("disableTraceRoute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableTraceRoute = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ConnectionMonitorIcmpConfiguration(Optional.ToNullable(disableTraceRoute));
        }
    }
}
