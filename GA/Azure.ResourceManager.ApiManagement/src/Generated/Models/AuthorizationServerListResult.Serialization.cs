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
    internal partial class AuthorizationServerListResult
    {
        internal static AuthorizationServerListResult DeserializeAuthorizationServerListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ApiManagementAuthorizationServerData>> value = default;
            Optional<long> count = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiManagementAuthorizationServerData> array = new List<ApiManagementAuthorizationServerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementAuthorizationServerData.DeserializeApiManagementAuthorizationServerData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AuthorizationServerListResult(Optional.ToList(value), Optional.ToNullable(count), nextLink.Value);
        }
    }
}
