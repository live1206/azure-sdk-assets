// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MarketplaceOrdering
{
    public partial class MarketplaceAgreementTermData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteStringValue(Plan);
            }
            if (Optional.IsDefined(LicenseTextLink))
            {
                writer.WritePropertyName("licenseTextLink"u8);
                writer.WriteStringValue(LicenseTextLink.AbsoluteUri);
            }
            if (Optional.IsDefined(PrivacyPolicyLink))
            {
                writer.WritePropertyName("privacyPolicyLink"u8);
                writer.WriteStringValue(PrivacyPolicyLink.AbsoluteUri);
            }
            if (Optional.IsDefined(MarketplaceTermsLink))
            {
                writer.WritePropertyName("marketplaceTermsLink"u8);
                writer.WriteStringValue(MarketplaceTermsLink.AbsoluteUri);
            }
            if (Optional.IsDefined(RetrievedOn))
            {
                writer.WritePropertyName("retrieveDatetime"u8);
                writer.WriteStringValue(RetrievedOn.Value, "O");
            }
            if (Optional.IsDefined(Signature))
            {
                writer.WritePropertyName("signature"u8);
                writer.WriteStringValue(Signature);
            }
            if (Optional.IsDefined(IsAccepted))
            {
                writer.WritePropertyName("accepted"u8);
                writer.WriteBooleanValue(IsAccepted.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MarketplaceAgreementTermData DeserializeMarketplaceAgreementTermData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> publisher = default;
            Optional<string> product = default;
            Optional<string> plan = default;
            Optional<Uri> licenseTextLink = default;
            Optional<Uri> privacyPolicyLink = default;
            Optional<Uri> marketplaceTermsLink = default;
            Optional<DateTimeOffset> retrieveDatetime = default;
            Optional<string> signature = default;
            Optional<bool> accepted = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("plan"u8))
                        {
                            plan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseTextLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseTextLink = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privacyPolicyLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privacyPolicyLink = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplaceTermsLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketplaceTermsLink = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("retrieveDatetime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retrieveDatetime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("signature"u8))
                        {
                            signature = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accepted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accepted = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MarketplaceAgreementTermData(id, name, type, systemData.Value, publisher.Value, product.Value, plan.Value, licenseTextLink.Value, privacyPolicyLink.Value, marketplaceTermsLink.Value, Optional.ToNullable(retrieveDatetime), signature.Value, Optional.ToNullable(accepted));
        }
    }
}