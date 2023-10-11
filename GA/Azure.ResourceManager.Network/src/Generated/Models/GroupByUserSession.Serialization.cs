// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class GroupByUserSession : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("groupByVariables"u8);
            writer.WriteStartArray();
            foreach (var item in GroupByVariables)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static GroupByUserSession DeserializeGroupByUserSession(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<GroupByVariable> groupByVariables = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupByVariables"u8))
                {
                    List<GroupByVariable> array = new List<GroupByVariable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GroupByVariable.DeserializeGroupByVariable(item));
                    }
                    groupByVariables = array;
                    continue;
                }
            }
            return new GroupByUserSession(groupByVariables);
        }
    }
}