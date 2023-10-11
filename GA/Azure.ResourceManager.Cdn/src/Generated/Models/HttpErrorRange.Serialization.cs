// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class HttpErrorRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Begin))
            {
                writer.WritePropertyName("begin"u8);
                writer.WriteNumberValue(Begin.Value);
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end"u8);
                writer.WriteNumberValue(End.Value);
            }
            writer.WriteEndObject();
        }

        internal static HttpErrorRange DeserializeHttpErrorRange(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> begin = default;
            Optional<int> end = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("begin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    begin = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    end = property.Value.GetInt32();
                    continue;
                }
            }
            return new HttpErrorRange(Optional.ToNullable(begin), Optional.ToNullable(end));
        }
    }
}
