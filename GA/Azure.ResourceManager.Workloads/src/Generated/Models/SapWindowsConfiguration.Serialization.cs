// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapWindowsConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToString());
            writer.WriteEndObject();
        }

        internal static SapWindowsConfiguration DeserializeSapWindowsConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SapOSType osType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"u8))
                {
                    osType = new SapOSType(property.Value.GetString());
                    continue;
                }
            }
            return new SapWindowsConfiguration(osType);
        }
    }
}
