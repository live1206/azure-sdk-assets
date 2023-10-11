// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class WindowsProfileResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AdminUsername))
            {
                writer.WritePropertyName("adminUsername"u8);
                writer.WriteStringValue(AdminUsername);
            }
            if (Optional.IsDefined(EnableCsiProxy))
            {
                writer.WritePropertyName("enableCsiProxy"u8);
                writer.WriteBooleanValue(EnableCsiProxy.Value);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static WindowsProfileResponse DeserializeWindowsProfileResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> adminUsername = default;
            Optional<bool> enableCsiProxy = default;
            Optional<LicenseType> licenseType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableCsiProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCsiProxy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new LicenseType(property.Value.GetString());
                    continue;
                }
            }
            return new WindowsProfileResponse(adminUsername.Value, Optional.ToNullable(enableCsiProxy), Optional.ToNullable(licenseType));
        }
    }
}
