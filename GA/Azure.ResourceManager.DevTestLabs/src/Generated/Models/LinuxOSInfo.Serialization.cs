// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class LinuxOSInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinuxOSState))
            {
                writer.WritePropertyName("linuxOsState"u8);
                writer.WriteStringValue(LinuxOSState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static LinuxOSInfo DeserializeLinuxOSInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DevTestLabLinuxOSState> linuxOSState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linuxOsState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxOSState = new DevTestLabLinuxOSState(property.Value.GetString());
                    continue;
                }
            }
            return new LinuxOSInfo(Optional.ToNullable(linuxOSState));
        }
    }
}