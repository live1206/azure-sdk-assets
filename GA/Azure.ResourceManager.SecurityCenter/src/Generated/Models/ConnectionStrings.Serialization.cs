// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class ConnectionStrings
    {
        internal static ConnectionStrings DeserializeConnectionStrings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IngestionConnectionString> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<IngestionConnectionString> array = new List<IngestionConnectionString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IngestionConnectionString.DeserializeIngestionConnectionString(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ConnectionStrings(value);
        }
    }
}
