// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class AllSavingsBenefitDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static AllSavingsBenefitDetails DeserializeAllSavingsBenefitDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<decimal> overageCost = default;
            Optional<decimal> benefitCost = default;
            Optional<decimal> totalCost = default;
            Optional<decimal> savingsAmount = default;
            Optional<decimal> savingsPercentage = default;
            Optional<decimal> coveragePercentage = default;
            Optional<decimal> commitmentAmount = default;
            Optional<decimal> averageUtilizationPercentage = default;
            Optional<decimal> wastageCost = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("overageCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overageCost = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("benefitCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    benefitCost = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("totalCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCost = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("savingsAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    savingsAmount = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("savingsPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    savingsPercentage = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("coveragePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coveragePercentage = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("commitmentAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitmentAmount = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("averageUtilizationPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    averageUtilizationPercentage = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("wastageCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wastageCost = property.Value.GetDecimal();
                    continue;
                }
            }
            return new AllSavingsBenefitDetails(Optional.ToNullable(overageCost), Optional.ToNullable(benefitCost), Optional.ToNullable(totalCost), Optional.ToNullable(savingsAmount), Optional.ToNullable(savingsPercentage), Optional.ToNullable(coveragePercentage), Optional.ToNullable(commitmentAmount), Optional.ToNullable(averageUtilizationPercentage), Optional.ToNullable(wastageCost));
        }
    }
}