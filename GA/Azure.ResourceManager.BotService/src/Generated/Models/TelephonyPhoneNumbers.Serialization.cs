// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class TelephonyPhoneNumbers : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(PhoneNumber))
            {
                writer.WritePropertyName("phoneNumber"u8);
                writer.WriteStringValue(PhoneNumber);
            }
            if (Optional.IsDefined(AcsEndpoint))
            {
                if (AcsEndpoint != null)
                {
                    writer.WritePropertyName("acsEndpoint"u8);
                    writer.WriteStringValue(AcsEndpoint);
                }
                else
                {
                    writer.WriteNull("acsEndpoint");
                }
            }
            if (Optional.IsDefined(AcsSecret))
            {
                if (AcsSecret != null)
                {
                    writer.WritePropertyName("acsSecret"u8);
                    writer.WriteStringValue(AcsSecret);
                }
                else
                {
                    writer.WriteNull("acsSecret");
                }
            }
            if (Optional.IsDefined(AcsResourceId))
            {
                if (AcsResourceId != null)
                {
                    writer.WritePropertyName("acsResourceId"u8);
                    writer.WriteStringValue(AcsResourceId);
                }
                else
                {
                    writer.WriteNull("acsResourceId");
                }
            }
            if (Optional.IsDefined(CognitiveServiceSubscriptionKey))
            {
                if (CognitiveServiceSubscriptionKey != null)
                {
                    writer.WritePropertyName("cognitiveServiceSubscriptionKey"u8);
                    writer.WriteStringValue(CognitiveServiceSubscriptionKey);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceSubscriptionKey");
                }
            }
            if (Optional.IsDefined(CognitiveServiceRegion))
            {
                if (CognitiveServiceRegion != null)
                {
                    writer.WritePropertyName("cognitiveServiceRegion"u8);
                    writer.WriteStringValue(CognitiveServiceRegion);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceRegion");
                }
            }
            if (Optional.IsDefined(CognitiveServiceResourceId))
            {
                if (CognitiveServiceResourceId != null)
                {
                    writer.WritePropertyName("cognitiveServiceResourceId"u8);
                    writer.WriteStringValue(CognitiveServiceResourceId);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceResourceId");
                }
            }
            if (Optional.IsDefined(DefaultLocale))
            {
                if (DefaultLocale != null)
                {
                    writer.WritePropertyName("defaultLocale"u8);
                    writer.WriteStringValue(DefaultLocale);
                }
                else
                {
                    writer.WriteNull("defaultLocale");
                }
            }
            if (Optional.IsDefined(OfferType))
            {
                if (OfferType != null)
                {
                    writer.WritePropertyName("offerType"u8);
                    writer.WriteStringValue(OfferType);
                }
                else
                {
                    writer.WriteNull("offerType");
                }
            }
            writer.WriteEndObject();
        }

        internal static TelephonyPhoneNumbers DeserializeTelephonyPhoneNumbers(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> phoneNumber = default;
            Optional<string> acsEndpoint = default;
            Optional<string> acsSecret = default;
            Optional<ResourceIdentifier> acsResourceId = default;
            Optional<string> cognitiveServiceSubscriptionKey = default;
            Optional<string> cognitiveServiceRegion = default;
            Optional<ResourceIdentifier> cognitiveServiceResourceId = default;
            Optional<string> defaultLocale = default;
            Optional<string> offerType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acsEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acsEndpoint = null;
                        continue;
                    }
                    acsEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acsSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acsSecret = null;
                        continue;
                    }
                    acsSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acsResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acsResourceId = null;
                        continue;
                    }
                    acsResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cognitiveServiceSubscriptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceSubscriptionKey = null;
                        continue;
                    }
                    cognitiveServiceSubscriptionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceRegion = null;
                        continue;
                    }
                    cognitiveServiceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceResourceId = null;
                        continue;
                    }
                    cognitiveServiceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultLocale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultLocale = null;
                        continue;
                    }
                    defaultLocale = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        offerType = null;
                        continue;
                    }
                    offerType = property.Value.GetString();
                    continue;
                }
            }
            return new TelephonyPhoneNumbers(id.Value, phoneNumber.Value, acsEndpoint.Value, acsSecret.Value, acsResourceId.Value, cognitiveServiceSubscriptionKey.Value, cognitiveServiceRegion.Value, cognitiveServiceResourceId.Value, defaultLocale.Value, offerType.Value);
        }
    }
}