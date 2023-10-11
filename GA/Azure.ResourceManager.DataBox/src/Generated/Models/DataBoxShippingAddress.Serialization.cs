// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxShippingAddress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("streetAddress1"u8);
            writer.WriteStringValue(StreetAddress1);
            if (Optional.IsDefined(StreetAddress2))
            {
                writer.WritePropertyName("streetAddress2"u8);
                writer.WriteStringValue(StreetAddress2);
            }
            if (Optional.IsDefined(StreetAddress3))
            {
                writer.WritePropertyName("streetAddress3"u8);
                writer.WriteStringValue(StreetAddress3);
            }
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(StateOrProvince))
            {
                writer.WritePropertyName("stateOrProvince"u8);
                writer.WriteStringValue(StateOrProvince);
            }
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
            writer.WritePropertyName("postalCode"u8);
            writer.WriteStringValue(PostalCode);
            if (Optional.IsDefined(ZipExtendedCode))
            {
                writer.WritePropertyName("zipExtendedCode"u8);
                writer.WriteStringValue(ZipExtendedCode);
            }
            if (Optional.IsDefined(CompanyName))
            {
                writer.WritePropertyName("companyName"u8);
                writer.WriteStringValue(CompanyName);
            }
            if (Optional.IsDefined(AddressType))
            {
                writer.WritePropertyName("addressType"u8);
                writer.WriteStringValue(AddressType.Value.ToSerialString());
            }
            if (Optional.IsDefined(SkipAddressValidation))
            {
                writer.WritePropertyName("skipAddressValidation"u8);
                writer.WriteBooleanValue(SkipAddressValidation.Value);
            }
            if (Optional.IsDefined(TaxIdentificationNumber))
            {
                writer.WritePropertyName("taxIdentificationNumber"u8);
                writer.WriteStringValue(TaxIdentificationNumber);
            }
            writer.WriteEndObject();
        }

        internal static DataBoxShippingAddress DeserializeDataBoxShippingAddress(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string streetAddress1 = default;
            Optional<string> streetAddress2 = default;
            Optional<string> streetAddress3 = default;
            Optional<string> city = default;
            Optional<string> stateOrProvince = default;
            string country = default;
            string postalCode = default;
            Optional<string> zipExtendedCode = default;
            Optional<string> companyName = default;
            Optional<DataBoxShippingAddressType> addressType = default;
            Optional<bool> skipAddressValidation = default;
            Optional<string> taxIdentificationNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streetAddress1"u8))
                {
                    streetAddress1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress2"u8))
                {
                    streetAddress2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress3"u8))
                {
                    streetAddress3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateOrProvince"u8))
                {
                    stateOrProvince = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zipExtendedCode"u8))
                {
                    zipExtendedCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyName"u8))
                {
                    companyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addressType = property.Value.GetString().ToDataBoxShippingAddressType();
                    continue;
                }
                if (property.NameEquals("skipAddressValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipAddressValidation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("taxIdentificationNumber"u8))
                {
                    taxIdentificationNumber = property.Value.GetString();
                    continue;
                }
            }
            return new DataBoxShippingAddress(streetAddress1, streetAddress2.Value, streetAddress3.Value, city.Value, stateOrProvince.Value, country, postalCode, zipExtendedCode.Value, companyName.Value, Optional.ToNullable(addressType), Optional.ToNullable(skipAddressValidation), taxIdentificationNumber.Value);
        }
    }
}
