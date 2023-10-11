// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class NfsAccessPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("accessRules"u8);
            writer.WriteStartArray();
            foreach (var item in AccessRules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static NfsAccessPolicy DeserializeNfsAccessPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<NfsAccessRule> accessRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessRules"u8))
                {
                    List<NfsAccessRule> array = new List<NfsAccessRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NfsAccessRule.DeserializeNfsAccessRule(item));
                    }
                    accessRules = array;
                    continue;
                }
            }
            return new NfsAccessPolicy(name, accessRules);
        }
    }
}