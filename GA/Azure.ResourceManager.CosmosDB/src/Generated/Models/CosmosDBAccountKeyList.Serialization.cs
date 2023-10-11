// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountKeyList
    {
        internal static CosmosDBAccountKeyList DeserializeCosmosDBAccountKeyList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryMasterKey = default;
            Optional<string> secondaryMasterKey = default;
            Optional<string> primaryReadonlyMasterKey = default;
            Optional<string> secondaryReadonlyMasterKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMasterKey"u8))
                {
                    primaryMasterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryMasterKey"u8))
                {
                    secondaryMasterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryReadonlyMasterKey"u8))
                {
                    primaryReadonlyMasterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryReadonlyMasterKey"u8))
                {
                    secondaryReadonlyMasterKey = property.Value.GetString();
                    continue;
                }
            }
            return new CosmosDBAccountKeyList(primaryReadonlyMasterKey.Value, secondaryReadonlyMasterKey.Value, primaryMasterKey.Value, secondaryMasterKey.Value);
        }
    }
}