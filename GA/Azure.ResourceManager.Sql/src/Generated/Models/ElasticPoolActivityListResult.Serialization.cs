// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class ElasticPoolActivityListResult
    {
        internal static ElasticPoolActivityListResult DeserializeElasticPoolActivityListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ElasticPoolActivity> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ElasticPoolActivity> array = new List<ElasticPoolActivity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticPoolActivity.DeserializeElasticPoolActivity(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ElasticPoolActivityListResult(value);
        }
    }
}
