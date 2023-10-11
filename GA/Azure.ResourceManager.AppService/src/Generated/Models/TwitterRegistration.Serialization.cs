// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class TwitterRegistration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConsumerKey))
            {
                writer.WritePropertyName("consumerKey"u8);
                writer.WriteStringValue(ConsumerKey);
            }
            if (Optional.IsDefined(ConsumerSecretSettingName))
            {
                writer.WritePropertyName("consumerSecretSettingName"u8);
                writer.WriteStringValue(ConsumerSecretSettingName);
            }
            writer.WriteEndObject();
        }

        internal static TwitterRegistration DeserializeTwitterRegistration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> consumerKey = default;
            Optional<string> consumerSecretSettingName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("consumerKey"u8))
                {
                    consumerKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consumerSecretSettingName"u8))
                {
                    consumerSecretSettingName = property.Value.GetString();
                    continue;
                }
            }
            return new TwitterRegistration(consumerKey.Value, consumerSecretSettingName.Value);
        }
    }
}