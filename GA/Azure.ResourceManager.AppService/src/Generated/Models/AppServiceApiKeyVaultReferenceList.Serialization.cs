// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class AppServiceApiKeyVaultReferenceList
    {
        internal static AppServiceApiKeyVaultReferenceList DeserializeAppServiceApiKeyVaultReferenceList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ApiKeyVaultReferenceData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ApiKeyVaultReferenceData> array = new List<ApiKeyVaultReferenceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiKeyVaultReferenceData.DeserializeApiKeyVaultReferenceData(item));
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
            return new AppServiceApiKeyVaultReferenceList(value, nextLink.Value);
        }
    }
}
