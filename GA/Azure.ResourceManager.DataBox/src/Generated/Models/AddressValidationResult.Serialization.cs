// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class AddressValidationResult
    {
        internal static AddressValidationResult DeserializeAddressValidationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AddressValidationStatus> validationStatus = default;
            Optional<IReadOnlyList<DataBoxShippingAddress>> alternateAddresses = default;
            DataBoxValidationInputDiscriminator validationType = default;
            Optional<ResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationStatus = property.Value.GetString().ToAddressValidationStatus();
                    continue;
                }
                if (property.NameEquals("alternateAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxShippingAddress> array = new List<DataBoxShippingAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxShippingAddress.DeserializeDataBoxShippingAddress(item));
                    }
                    alternateAddresses = array;
                    continue;
                }
                if (property.NameEquals("validationType"u8))
                {
                    validationType = property.Value.GetString().ToDataBoxValidationInputDiscriminator();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
            }
            return new AddressValidationResult(validationType, error.Value, Optional.ToNullable(validationStatus), Optional.ToList(alternateAddresses));
        }
    }
}