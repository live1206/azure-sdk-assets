// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class QosPortRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start"u8);
                writer.WriteNumberValue(Start.Value);
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end"u8);
                writer.WriteNumberValue(End.Value);
            }
            writer.WriteEndObject();
        }

        internal static QosPortRange DeserializeQosPortRange(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> start = default;
            Optional<int> end = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("start"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    start = property.Value.GetInt32();
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
            return new QosPortRange(Optional.ToNullable(start), Optional.ToNullable(end));
        }
    }
}