// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Communication;

namespace Azure.ResourceManager.Communication.Models
{
    internal partial class DomainResourceList
    {
        internal static DomainResourceList DeserializeDomainResourceList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CommunicationDomainResourceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommunicationDomainResourceData> array = new List<CommunicationDomainResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationDomainResourceData.DeserializeCommunicationDomainResourceData(item));
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
            return new DomainResourceList(Optional.ToList(value), nextLink.Value);
        }
    }
}