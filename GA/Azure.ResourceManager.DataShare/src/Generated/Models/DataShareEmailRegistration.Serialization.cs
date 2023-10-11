// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class DataShareEmailRegistration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActivationCode))
            {
                writer.WritePropertyName("activationCode"u8);
                writer.WriteStringValue(ActivationCode);
            }
            writer.WriteEndObject();
        }

        internal static DataShareEmailRegistration DeserializeDataShareEmailRegistration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> activationCode = default;
            Optional<DateTimeOffset> activationExpirationDate = default;
            Optional<string> email = default;
            Optional<DataShareEmailRegistrationStatus> registrationStatus = default;
            Optional<Guid> tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activationCode"u8))
                {
                    activationCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activationExpirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activationExpirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registrationStatus = new DataShareEmailRegistrationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
            }
            return new DataShareEmailRegistration(activationCode.Value, Optional.ToNullable(activationExpirationDate), email.Value, Optional.ToNullable(registrationStatus), Optional.ToNullable(tenantId));
        }
    }
}