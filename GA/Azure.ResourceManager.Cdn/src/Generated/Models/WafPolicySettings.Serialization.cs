// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class WafPolicySettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(DefaultRedirectUri))
            {
                writer.WritePropertyName("defaultRedirectUrl"u8);
                writer.WriteStringValue(DefaultRedirectUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DefaultCustomBlockResponseStatusCode))
            {
                if (DefaultCustomBlockResponseStatusCode != null)
                {
                    writer.WritePropertyName("defaultCustomBlockResponseStatusCode"u8);
                    writer.WriteNumberValue(DefaultCustomBlockResponseStatusCode.Value.ToSerialInt32());
                }
                else
                {
                    writer.WriteNull("defaultCustomBlockResponseStatusCode");
                }
            }
            if (Optional.IsDefined(DefaultCustomBlockResponseBody))
            {
                if (DefaultCustomBlockResponseBody != null)
                {
                    writer.WritePropertyName("defaultCustomBlockResponseBody"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DefaultCustomBlockResponseBody);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(DefaultCustomBlockResponseBody.ToString()).RootElement);
#endif
                }
                else
                {
                    writer.WriteNull("defaultCustomBlockResponseBody");
                }
            }
            writer.WriteEndObject();
        }

        internal static WafPolicySettings DeserializeWafPolicySettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PolicyEnabledState> enabledState = default;
            Optional<PolicyMode> mode = default;
            Optional<Uri> defaultRedirectUri = default;
            Optional<PolicySettingsDefaultCustomBlockResponseStatusCode?> defaultCustomBlockResponseStatusCode = default;
            Optional<BinaryData> defaultCustomBlockResponseBody = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabledState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledState = new PolicyEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new PolicyMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultRedirectUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultRedirectUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultCustomBlockResponseStatusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultCustomBlockResponseStatusCode = null;
                        continue;
                    }
                    defaultCustomBlockResponseStatusCode = new PolicySettingsDefaultCustomBlockResponseStatusCode(property.Value.GetInt32());
                    continue;
                }
                if (property.NameEquals("defaultCustomBlockResponseBody"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultCustomBlockResponseBody = null;
                        continue;
                    }
                    defaultCustomBlockResponseBody = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new WafPolicySettings(Optional.ToNullable(enabledState), Optional.ToNullable(mode), defaultRedirectUri.Value, Optional.ToNullable(defaultCustomBlockResponseStatusCode), defaultCustomBlockResponseBody.Value);
        }
    }
}