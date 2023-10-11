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
    public partial class AddressValidationOutput
    {
        internal static AddressValidationOutput DeserializeAddressValidationOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataBoxValidationInputDiscriminator> validationType = default;
            Optional<ResponseError> error = default;
            Optional<AddressValidationStatus> validationStatus = default;
            Optional<IReadOnlyList<DataBoxShippingAddress>> alternateAddresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("validationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationType = property0.Value.GetString().ToDataBoxValidationInputDiscriminator();
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("validationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationStatus = property0.Value.GetString().ToAddressValidationStatus();
                            continue;
                        }
                        if (property0.NameEquals("alternateAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxShippingAddress> array = new List<DataBoxShippingAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxShippingAddress.DeserializeDataBoxShippingAddress(item));
                            }
                            alternateAddresses = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AddressValidationOutput(Optional.ToNullable(validationType), error.Value, Optional.ToNullable(validationStatus), Optional.ToList(alternateAddresses));
        }
    }
}