// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class ApiManagementServiceListResult
    {
        internal static ApiManagementServiceListResult DeserializeApiManagementServiceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ApiManagementServiceData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ApiManagementServiceData> array = new List<ApiManagementServiceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementServiceData.DeserializeApiManagementServiceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementServiceListResult(value, nextLink.Value);
        }
    }
}