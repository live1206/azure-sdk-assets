// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataCenterAccessSecurityCode
    {
        internal static DataCenterAccessSecurityCode DeserializeDataCenterAccessSecurityCode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> reverseDCAccessCode = default;
            Optional<string> forwardDCAccessCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reverseDCAccessCode"u8))
                {
                    reverseDCAccessCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("forwardDCAccessCode"u8))
                {
                    forwardDCAccessCode = property.Value.GetString();
                    continue;
                }
            }
            return new DataCenterAccessSecurityCode(reverseDCAccessCode.Value, forwardDCAccessCode.Value);
        }
    }
}