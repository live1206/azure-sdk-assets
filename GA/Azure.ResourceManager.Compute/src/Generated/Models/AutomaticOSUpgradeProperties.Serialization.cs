// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class AutomaticOSUpgradeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("automaticOSUpgradeSupported"u8);
            writer.WriteBooleanValue(AutomaticOSUpgradeSupported);
            writer.WriteEndObject();
        }

        internal static AutomaticOSUpgradeProperties DeserializeAutomaticOSUpgradeProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool automaticOSUpgradeSupported = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("automaticOSUpgradeSupported"u8))
                {
                    automaticOSUpgradeSupported = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AutomaticOSUpgradeProperties(automaticOSUpgradeSupported);
        }
    }
}
