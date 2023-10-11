// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class AppSeenInfoList
    {
        internal static AppSeenInfoList DeserializeAppSeenInfoList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int count = default;
            IReadOnlyList<AppSeenInfo> appSeenList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appSeenList"u8))
                {
                    List<AppSeenInfo> array = new List<AppSeenInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppSeenInfo.DeserializeAppSeenInfo(item));
                    }
                    appSeenList = array;
                    continue;
                }
            }
            return new AppSeenInfoList(count, appSeenList);
        }
    }
}