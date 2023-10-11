// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class ClientCertificateAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ValidationScheme))
            {
                writer.WritePropertyName("validationScheme"u8);
                writer.WriteStringValue(ValidationScheme.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AllowedThumbprints))
            {
                writer.WritePropertyName("allowedThumbprints"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedThumbprints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ClientCertificateAuthentication DeserializeClientCertificateAuthentication(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ClientCertificateValidationScheme> validationScheme = default;
            Optional<IList<string>> allowedThumbprints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationScheme"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationScheme = new ClientCertificateValidationScheme(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedThumbprints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedThumbprints = array;
                    continue;
                }
            }
            return new ClientCertificateAuthentication(Optional.ToNullable(validationScheme), Optional.ToList(allowedThumbprints));
        }
    }
}
