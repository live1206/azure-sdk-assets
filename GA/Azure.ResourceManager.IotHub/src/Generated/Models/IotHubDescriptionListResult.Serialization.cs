// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubDescriptionListResult
    {
        internal static IotHubDescriptionListResult DeserializeIotHubDescriptionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<IotHubDescriptionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubDescriptionData> array = new List<IotHubDescriptionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubDescriptionData.DeserializeIotHubDescriptionData(item));
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
            return new IotHubDescriptionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}