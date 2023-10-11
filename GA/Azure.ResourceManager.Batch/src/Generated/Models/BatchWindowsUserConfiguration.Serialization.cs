// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    internal partial class BatchWindowsUserConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LoginMode))
            {
                writer.WritePropertyName("loginMode"u8);
                writer.WriteStringValue(LoginMode.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static BatchWindowsUserConfiguration DeserializeBatchWindowsUserConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BatchWindowsLoginMode> loginMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loginMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loginMode = property.Value.GetString().ToBatchWindowsLoginMode();
                    continue;
                }
            }
            return new BatchWindowsUserConfiguration(Optional.ToNullable(loginMode));
        }
    }
}