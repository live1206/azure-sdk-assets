// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementResourceSkuCapacity
    {
        internal static ApiManagementResourceSkuCapacity DeserializeApiManagementResourceSkuCapacity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> minimum = default;
            Optional<int> maximum = default;
            Optional<int> @default = default;
            Optional<ApiManagementResourceSkuCapacityScaleType> scaleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleType = new ApiManagementResourceSkuCapacityScaleType(property.Value.GetString());
                    continue;
                }
            }
            return new ApiManagementResourceSkuCapacity(Optional.ToNullable(minimum), Optional.ToNullable(maximum), Optional.ToNullable(@default), Optional.ToNullable(scaleType));
        }
    }
}