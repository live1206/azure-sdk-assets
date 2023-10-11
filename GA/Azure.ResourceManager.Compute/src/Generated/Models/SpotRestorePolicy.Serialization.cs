// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SpotRestorePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(RestoreTimeout))
            {
                writer.WritePropertyName("restoreTimeout"u8);
                writer.WriteStringValue(RestoreTimeout);
            }
            writer.WriteEndObject();
        }

        internal static SpotRestorePolicy DeserializeSpotRestorePolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> restoreTimeout = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("restoreTimeout"u8))
                {
                    restoreTimeout = property.Value.GetString();
                    continue;
                }
            }
            return new SpotRestorePolicy(Optional.ToNullable(enabled), restoreTimeout.Value);
        }
    }
}