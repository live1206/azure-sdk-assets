// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayHeaderConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(HeaderName))
            {
                writer.WritePropertyName("headerName"u8);
                writer.WriteStringValue(HeaderName);
            }
            if (Optional.IsDefined(HeaderValue))
            {
                writer.WritePropertyName("headerValue"u8);
                writer.WriteStringValue(HeaderValue);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayHeaderConfiguration DeserializeApplicationGatewayHeaderConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> headerName = default;
            Optional<string> headerValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headerName"u8))
                {
                    headerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("headerValue"u8))
                {
                    headerValue = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationGatewayHeaderConfiguration(headerName.Value, headerValue.Value);
        }
    }
}