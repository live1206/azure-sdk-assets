// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class DestinationAddressInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Cidrs))
            {
                writer.WritePropertyName("cidrs"u8);
                writer.WriteStartArray();
                foreach (var item in Cidrs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Countries))
            {
                writer.WritePropertyName("countries"u8);
                writer.WriteStartArray();
                foreach (var item in Countries)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Feeds))
            {
                writer.WritePropertyName("feeds"u8);
                writer.WriteStartArray();
                foreach (var item in Feeds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrefixLists))
            {
                writer.WritePropertyName("prefixLists"u8);
                writer.WriteStartArray();
                foreach (var item in PrefixLists)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FqdnLists))
            {
                writer.WritePropertyName("fqdnLists"u8);
                writer.WriteStartArray();
                foreach (var item in FqdnLists)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DestinationAddressInfo DeserializeDestinationAddressInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> cidrs = default;
            Optional<IList<string>> countries = default;
            Optional<IList<string>> feeds = default;
            Optional<IList<string>> prefixLists = default;
            Optional<IList<string>> fqdnLists = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cidrs"u8))
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
                    cidrs = array;
                    continue;
                }
                if (property.NameEquals("countries"u8))
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
                    countries = array;
                    continue;
                }
                if (property.NameEquals("feeds"u8))
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
                    feeds = array;
                    continue;
                }
                if (property.NameEquals("prefixLists"u8))
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
                    prefixLists = array;
                    continue;
                }
                if (property.NameEquals("fqdnLists"u8))
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
                    fqdnLists = array;
                    continue;
                }
            }
            return new DestinationAddressInfo(Optional.ToList(cidrs), Optional.ToList(countries), Optional.ToList(feeds), Optional.ToList(prefixLists), Optional.ToList(fqdnLists));
        }
    }
}