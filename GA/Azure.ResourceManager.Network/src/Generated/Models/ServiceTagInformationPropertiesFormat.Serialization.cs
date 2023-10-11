// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ServiceTagInformationPropertiesFormat
    {
        internal static ServiceTagInformationPropertiesFormat DeserializeServiceTagInformationPropertiesFormat(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> changeNumber = default;
            Optional<string> region = default;
            Optional<string> systemService = default;
            Optional<IReadOnlyList<string>> addressPrefixes = default;
            Optional<string> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("changeNumber"u8))
                {
                    changeNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemService"u8))
                {
                    systemService = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceTagInformationPropertiesFormat(changeNumber.Value, region.Value, systemService.Value, Optional.ToList(addressPrefixes), state.Value);
        }
    }
}
