// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsPrivateCloudAddonProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("addonType"u8);
            writer.WriteStringValue(AddonType.ToString());
            writer.WriteEndObject();
        }

        internal static AvsPrivateCloudAddonProperties DeserializeAvsPrivateCloudAddonProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("addonType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Arc": return AddonArcProperties.DeserializeAddonArcProperties(element);
                    case "HCX": return AddonHcxProperties.DeserializeAddonHcxProperties(element);
                    case "SRM": return AddonSrmProperties.DeserializeAddonSrmProperties(element);
                    case "VR": return AddonVrProperties.DeserializeAddonVrProperties(element);
                }
            }
            return UnknownAddonProperties.DeserializeUnknownAddonProperties(element);
        }
    }
}
