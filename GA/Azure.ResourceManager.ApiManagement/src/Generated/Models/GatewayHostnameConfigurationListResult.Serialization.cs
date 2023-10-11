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
    internal partial class GatewayHostnameConfigurationListResult
    {
        internal static GatewayHostnameConfigurationListResult DeserializeGatewayHostnameConfigurationListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ApiManagementGatewayHostnameConfigurationData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiManagementGatewayHostnameConfigurationData> array = new List<ApiManagementGatewayHostnameConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementGatewayHostnameConfigurationData.DeserializeApiManagementGatewayHostnameConfigurationData(item));
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
            return new GatewayHostnameConfigurationListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
