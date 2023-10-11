// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class ServerCommunicationLinkListResult
    {
        internal static ServerCommunicationLinkListResult DeserializeServerCommunicationLinkListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SqlServerCommunicationLinkData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlServerCommunicationLinkData> array = new List<SqlServerCommunicationLinkData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlServerCommunicationLinkData.DeserializeSqlServerCommunicationLinkData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ServerCommunicationLinkListResult(Optional.ToList(value));
        }
    }
}