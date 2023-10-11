// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    internal partial class RequestHeaderOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OptInHeaders))
            {
                writer.WritePropertyName("optInHeaders"u8);
                writer.WriteStringValue(OptInHeaders.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static RequestHeaderOptions DeserializeRequestHeaderOptions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OptInHeaderType> optInHeaders = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("optInHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optInHeaders = new OptInHeaderType(property.Value.GetString());
                    continue;
                }
            }
            return new RequestHeaderOptions(Optional.ToNullable(optInHeaders));
        }
    }
}