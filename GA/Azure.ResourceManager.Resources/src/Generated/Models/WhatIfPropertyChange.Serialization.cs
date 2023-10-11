// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class WhatIfPropertyChange
    {
        internal static WhatIfPropertyChange DeserializeWhatIfPropertyChange(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string path = default;
            WhatIfPropertyChangeType propertyChangeType = default;
            Optional<BinaryData> before = default;
            Optional<BinaryData> after = default;
            Optional<IReadOnlyList<WhatIfPropertyChange>> children = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("propertyChangeType"u8))
                {
                    propertyChangeType = property.Value.GetString().ToWhatIfPropertyChangeType();
                    continue;
                }
                if (property.NameEquals("before"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    before = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("after"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    after = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("children"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WhatIfPropertyChange> array = new List<WhatIfPropertyChange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeWhatIfPropertyChange(item));
                    }
                    children = array;
                    continue;
                }
            }
            return new WhatIfPropertyChange(path, propertyChangeType, before.Value, after.Value, Optional.ToList(children));
        }
    }
}