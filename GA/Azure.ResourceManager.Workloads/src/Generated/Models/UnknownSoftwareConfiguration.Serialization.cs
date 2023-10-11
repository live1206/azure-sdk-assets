// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class UnknownSoftwareConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("softwareInstallationType"u8);
            writer.WriteStringValue(SoftwareInstallationType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownSoftwareConfiguration DeserializeUnknownSoftwareConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SapSoftwareInstallationType softwareInstallationType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("softwareInstallationType"u8))
                {
                    softwareInstallationType = new SapSoftwareInstallationType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownSoftwareConfiguration(softwareInstallationType);
        }
    }
}
