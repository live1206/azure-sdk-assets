// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class PermissionBindingsListResult
    {
        internal static PermissionBindingsListResult DeserializePermissionBindingsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<EventGridNamespacePermissionBindingData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventGridNamespacePermissionBindingData> array = new List<EventGridNamespacePermissionBindingData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventGridNamespacePermissionBindingData.DeserializeEventGridNamespacePermissionBindingData(item));
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
            return new PermissionBindingsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}