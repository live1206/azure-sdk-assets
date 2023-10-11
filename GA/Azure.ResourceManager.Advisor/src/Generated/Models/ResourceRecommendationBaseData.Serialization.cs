// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Advisor.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Advisor
{
    public partial class ResourceRecommendationBaseData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(Impact))
            {
                writer.WritePropertyName("impact"u8);
                writer.WriteStringValue(Impact.Value.ToString());
            }
            if (Optional.IsDefined(ImpactedField))
            {
                writer.WritePropertyName("impactedField"u8);
                writer.WriteStringValue(ImpactedField);
            }
            if (Optional.IsDefined(ImpactedValue))
            {
                writer.WritePropertyName("impactedValue"u8);
                writer.WriteStringValue(ImpactedValue);
            }
            if (Optional.IsDefined(LastUpdated))
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdated.Value, "O");
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(RecommendationTypeId))
            {
                writer.WritePropertyName("recommendationTypeId"u8);
                writer.WriteStringValue(RecommendationTypeId);
            }
            if (Optional.IsDefined(Risk))
            {
                writer.WritePropertyName("risk"u8);
                writer.WriteStringValue(Risk.Value.ToString());
            }
            if (Optional.IsDefined(ShortDescription))
            {
                writer.WritePropertyName("shortDescription"u8);
                writer.WriteObjectValue(ShortDescription);
            }
            if (Optional.IsCollectionDefined(SuppressionIds))
            {
                writer.WritePropertyName("suppressionIds"u8);
                writer.WriteStartArray();
                foreach (var item in SuppressionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExtendedProperties))
            {
                writer.WritePropertyName("extendedProperties"u8);
                writer.WriteStartObject();
                foreach (var item in ExtendedProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ResourceMetadata))
            {
                writer.WritePropertyName("resourceMetadata"u8);
                writer.WriteObjectValue(ResourceMetadata);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (Optional.IsDefined(LearnMoreLink))
            {
                writer.WritePropertyName("learnMoreLink"u8);
                writer.WriteStringValue(LearnMoreLink);
            }
            if (Optional.IsDefined(PotentialBenefits))
            {
                writer.WritePropertyName("potentialBenefits"u8);
                writer.WriteStringValue(PotentialBenefits);
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item)
                    {
                        writer.WritePropertyName(item0.Key);
                        if (item0.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item0.Value);
#else
                        JsonSerializer.Serialize(writer, JsonDocument.Parse(item0.Value.ToString()).RootElement);
#endif
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Remediation))
            {
                writer.WritePropertyName("remediation"u8);
                writer.WriteStartObject();
                foreach (var item in Remediation)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ExposedMetadataProperties))
            {
                writer.WritePropertyName("exposedMetadataProperties"u8);
                writer.WriteStartObject();
                foreach (var item in ExposedMetadataProperties)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ResourceRecommendationBaseData DeserializeResourceRecommendationBaseData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Category> category = default;
            Optional<Impact> impact = default;
            Optional<string> impactedField = default;
            Optional<string> impactedValue = default;
            Optional<DateTimeOffset> lastUpdated = default;
            Optional<IDictionary<string, BinaryData>> metadata = default;
            Optional<string> recommendationTypeId = default;
            Optional<Risk> risk = default;
            Optional<ShortDescription> shortDescription = default;
            Optional<IList<Guid>> suppressionIds = default;
            Optional<IDictionary<string, string>> extendedProperties = default;
            Optional<ResourceMetadata> resourceMetadata = default;
            Optional<string> description = default;
            Optional<string> label = default;
            Optional<string> learnMoreLink = default;
            Optional<string> potentialBenefits = default;
            Optional<IList<IDictionary<string, BinaryData>>> actions = default;
            Optional<IDictionary<string, BinaryData>> remediation = default;
            Optional<IDictionary<string, BinaryData>> exposedMetadataProperties = default;
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
                        if (property0.NameEquals("category"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            category = new Category(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("impact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            impact = new Impact(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("impactedField"u8))
                        {
                            impactedField = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("impactedValue"u8))
                        {
                            impactedValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastUpdated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            metadata = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("recommendationTypeId"u8))
                        {
                            recommendationTypeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("risk"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            risk = new Risk(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("shortDescription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shortDescription = ShortDescription.DeserializeShortDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("suppressionIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Guid> array = new List<Guid>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetGuid());
                            }
                            suppressionIds = array;
                            continue;
                        }
                        if (property0.NameEquals("extendedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            extendedProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("resourceMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceMetadata = ResourceMetadata.DeserializeResourceMetadata(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("label"u8))
                        {
                            label = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("learnMoreLink"u8))
                        {
                            learnMoreLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("potentialBenefits"u8))
                        {
                            potentialBenefits = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("actions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IDictionary<string, BinaryData>> array = new List<IDictionary<string, BinaryData>>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                                    foreach (var property1 in item.EnumerateObject())
                                    {
                                        if (property1.Value.ValueKind == JsonValueKind.Null)
                                        {
                                            dictionary.Add(property1.Name, null);
                                        }
                                        else
                                        {
                                            dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                        }
                                    }
                                    array.Add(dictionary);
                                }
                            }
                            actions = array;
                            continue;
                        }
                        if (property0.NameEquals("remediation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            remediation = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("exposedMetadataProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            exposedMetadataProperties = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ResourceRecommendationBaseData(id, name, type, systemData.Value, Optional.ToNullable(category), Optional.ToNullable(impact), impactedField.Value, impactedValue.Value, Optional.ToNullable(lastUpdated), Optional.ToDictionary(metadata), recommendationTypeId.Value, Optional.ToNullable(risk), shortDescription.Value, Optional.ToList(suppressionIds), Optional.ToDictionary(extendedProperties), resourceMetadata.Value, description.Value, label.Value, learnMoreLink.Value, potentialBenefits.Value, Optional.ToList(actions), Optional.ToDictionary(remediation), Optional.ToDictionary(exposedMetadataProperties));
        }
    }
}