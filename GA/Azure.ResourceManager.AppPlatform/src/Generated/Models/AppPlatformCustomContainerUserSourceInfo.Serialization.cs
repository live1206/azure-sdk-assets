// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformCustomContainerUserSourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomContainer))
            {
                writer.WritePropertyName("customContainer"u8);
                writer.WriteObjectValue(CustomContainer);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(UserSourceInfoType);
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformCustomContainerUserSourceInfo DeserializeAppPlatformCustomContainerUserSourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformCustomContainer> customContainer = default;
            string type = default;
            Optional<string> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customContainer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customContainer = AppPlatformCustomContainer.DeserializeAppPlatformCustomContainer(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new AppPlatformCustomContainerUserSourceInfo(type, version.Value, customContainer.Value);
        }
    }
}