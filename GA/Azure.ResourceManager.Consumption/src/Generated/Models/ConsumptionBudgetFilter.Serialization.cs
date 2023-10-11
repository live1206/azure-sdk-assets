// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionBudgetFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(And))
            {
                writer.WritePropertyName("and"u8);
                writer.WriteStartArray();
                foreach (var item in And)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteObjectValue(Dimensions);
            }
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteObjectValue(Tags);
            }
            writer.WriteEndObject();
        }

        internal static ConsumptionBudgetFilter DeserializeConsumptionBudgetFilter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<BudgetFilterProperties>> and = default;
            Optional<BudgetComparisonExpression> dimensions = default;
            Optional<BudgetComparisonExpression> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("and"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BudgetFilterProperties> array = new List<BudgetFilterProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BudgetFilterProperties.DeserializeBudgetFilterProperties(item));
                    }
                    and = array;
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dimensions = BudgetComparisonExpression.DeserializeBudgetComparisonExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tags = BudgetComparisonExpression.DeserializeBudgetComparisonExpression(property.Value);
                    continue;
                }
            }
            return new ConsumptionBudgetFilter(Optional.ToList(and), dimensions.Value, tags.Value);
        }
    }
}