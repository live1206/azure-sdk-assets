// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class WebTestGeolocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("Id"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WriteEndObject();
        }

        internal static WebTestGeolocation DeserializeWebTestGeolocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new AzureLocation(property.Value.GetString());
                    continue;
                }
            }
            return new WebTestGeolocation(Optional.ToNullable(id));
        }
    }
}