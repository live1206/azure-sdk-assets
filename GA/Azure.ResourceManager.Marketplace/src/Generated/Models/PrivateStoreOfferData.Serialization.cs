// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    public partial class PrivateStoreOfferData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SpecificPlanIdsLimitation))
            {
                writer.WritePropertyName("specificPlanIdsLimitation"u8);
                writer.WriteStartArray();
                foreach (var item in SpecificPlanIdsLimitation)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsUpdateSuppressedDueToIdempotence))
            {
                writer.WritePropertyName("updateSuppressedDueIdempotence"u8);
                writer.WriteBooleanValue(IsUpdateSuppressedDueToIdempotence.Value);
            }
            if (Optional.IsCollectionDefined(IconFileUris))
            {
                writer.WritePropertyName("iconFileUris"u8);
                writer.WriteStartObject();
                foreach (var item in IconFileUris)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.Value.AbsoluteUri);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Plans))
            {
                writer.WritePropertyName("plans"u8);
                writer.WriteStartArray();
                foreach (var item in Plans)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PrivateStoreOfferData DeserializePrivateStoreOfferData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> uniqueOfferId = default;
            Optional<string> offerDisplayName = default;
            Optional<string> publisherDisplayName = default;
            Optional<ETag> eTag = default;
            Optional<Guid> privateStoreId = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> modifiedAt = default;
            Optional<IList<string>> specificPlanIdsLimitation = default;
            Optional<bool> updateSuppressedDueIdempotence = default;
            Optional<IDictionary<string, Uri>> iconFileUris = default;
            Optional<IList<PrivateStorePlan>> plans = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("uniqueOfferId"u8))
                        {
                            uniqueOfferId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offerDisplayName"u8))
                        {
                            offerDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherDisplayName"u8))
                        {
                            publisherDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eTag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eTag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateStoreId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateStoreId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modifiedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modifiedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("specificPlanIdsLimitation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            specificPlanIdsLimitation = array;
                            continue;
                        }
                        if (property0.NameEquals("updateSuppressedDueIdempotence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateSuppressedDueIdempotence = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("iconFileUris"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, Uri> dictionary = new Dictionary<string, Uri>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, new Uri(property1.Value.GetString()));
                                }
                            }
                            iconFileUris = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("plans"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrivateStorePlan> array = new List<PrivateStorePlan>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateStorePlan.DeserializePrivateStorePlan(item));
                            }
                            plans = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PrivateStoreOfferData(id, name, type, systemData.Value, uniqueOfferId.Value, offerDisplayName.Value, publisherDisplayName.Value, Optional.ToNullable(eTag), Optional.ToNullable(privateStoreId), Optional.ToNullable(createdAt), Optional.ToNullable(modifiedAt), Optional.ToList(specificPlanIdsLimitation), Optional.ToNullable(updateSuppressedDueIdempotence), Optional.ToDictionary(iconFileUris), Optional.ToList(plans));
        }
    }
}