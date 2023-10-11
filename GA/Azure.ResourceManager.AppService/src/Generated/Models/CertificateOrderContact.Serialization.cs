// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CertificateOrderContact
    {
        internal static CertificateOrderContact DeserializeCertificateOrderContact(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> email = default;
            Optional<string> nameFirst = default;
            Optional<string> nameLast = default;
            Optional<string> phone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameFirst"u8))
                {
                    nameFirst = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameLast"u8))
                {
                    nameLast = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
            }
            return new CertificateOrderContact(email.Value, nameFirst.Value, nameLast.Value, phone.Value);
        }
    }
}