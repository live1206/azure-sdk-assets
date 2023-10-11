// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class TermsOfServiceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
            }
            if (Optional.IsDefined(IsDisplayEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsDisplayEnabled.Value);
            }
            if (Optional.IsDefined(IsConsentRequired))
            {
                writer.WritePropertyName("consentRequired"u8);
                writer.WriteBooleanValue(IsConsentRequired.Value);
            }
            writer.WriteEndObject();
        }

        internal static TermsOfServiceProperties DeserializeTermsOfServiceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> text = default;
            Optional<bool> enabled = default;
            Optional<bool> consentRequired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("consentRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    consentRequired = property.Value.GetBoolean();
                    continue;
                }
            }
            return new TermsOfServiceProperties(text.Value, Optional.ToNullable(enabled), Optional.ToNullable(consentRequired));
        }
    }
}
