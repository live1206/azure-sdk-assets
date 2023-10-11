// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciSkuMappings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CatalogPlanId))
            {
                writer.WritePropertyName("catalogPlanId"u8);
                writer.WriteStringValue(CatalogPlanId);
            }
            if (Optional.IsDefined(MarketplaceSkuId))
            {
                writer.WritePropertyName("marketplaceSkuId"u8);
                writer.WriteStringValue(MarketplaceSkuId);
            }
            if (Optional.IsCollectionDefined(MarketplaceSkuVersions))
            {
                writer.WritePropertyName("marketplaceSkuVersions"u8);
                writer.WriteStartArray();
                foreach (var item in MarketplaceSkuVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static HciSkuMappings DeserializeHciSkuMappings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> catalogPlanId = default;
            Optional<string> marketplaceSkuId = default;
            Optional<IList<string>> marketplaceSkuVersions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogPlanId"u8))
                {
                    catalogPlanId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marketplaceSkuId"u8))
                {
                    marketplaceSkuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marketplaceSkuVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    marketplaceSkuVersions = array;
                    continue;
                }
            }
            return new HciSkuMappings(catalogPlanId.Value, marketplaceSkuId.Value, Optional.ToList(marketplaceSkuVersions));
        }
    }
}