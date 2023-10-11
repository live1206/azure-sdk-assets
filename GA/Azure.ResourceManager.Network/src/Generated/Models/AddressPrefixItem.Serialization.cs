// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AddressPrefixItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsDefined(AddressPrefixType))
            {
                writer.WritePropertyName("addressPrefixType"u8);
                writer.WriteStringValue(AddressPrefixType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AddressPrefixItem DeserializeAddressPrefixItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> addressPrefix = default;
            Optional<AddressPrefixType> addressPrefixType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefix"u8))
                {
                    addressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressPrefixType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addressPrefixType = new AddressPrefixType(property.Value.GetString());
                    continue;
                }
            }
            return new AddressPrefixItem(addressPrefix.Value, Optional.ToNullable(addressPrefixType));
        }
    }
}