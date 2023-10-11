// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    internal partial class VolumeQuotaRulesList
    {
        internal static VolumeQuotaRulesList DeserializeVolumeQuotaRulesList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<NetAppVolumeQuotaRuleData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetAppVolumeQuotaRuleData> array = new List<NetAppVolumeQuotaRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetAppVolumeQuotaRuleData.DeserializeNetAppVolumeQuotaRuleData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new VolumeQuotaRulesList(Optional.ToList(value));
        }
    }
}