// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    public partial class AppConfigurationPrivateLinkServiceConnectionState : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static AppConfigurationPrivateLinkServiceConnectionState DeserializeAppConfigurationPrivateLinkServiceConnectionState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppConfigurationPrivateLinkServiceConnectionStatus> status = default;
            Optional<string> description = default;
            Optional<AppConfigurationActionsRequired> actionsRequired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new AppConfigurationPrivateLinkServiceConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionsRequired = new AppConfigurationActionsRequired(property.Value.GetString());
                    continue;
                }
            }
            return new AppConfigurationPrivateLinkServiceConnectionState(Optional.ToNullable(status), description.Value, Optional.ToNullable(actionsRequired));
        }
    }
}