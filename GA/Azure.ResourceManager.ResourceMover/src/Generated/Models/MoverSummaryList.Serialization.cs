// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class MoverSummaryList
    {
        internal static MoverSummaryList DeserializeMoverSummaryList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fieldName = default;
            Optional<IReadOnlyList<MoverSummaryItemInfo>> summary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fieldName"u8))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MoverSummaryItemInfo> array = new List<MoverSummaryItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverSummaryItemInfo.DeserializeMoverSummaryItemInfo(item));
                    }
                    summary = array;
                    continue;
                }
            }
            return new MoverSummaryList(fieldName.Value, Optional.ToList(summary));
        }
    }
}