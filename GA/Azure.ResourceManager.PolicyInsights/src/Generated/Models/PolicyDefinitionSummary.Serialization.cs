// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyDefinitionSummary
    {
        internal static PolicyDefinitionSummary DeserializePolicyDefinitionSummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> policyDefinitionId = default;
            Optional<string> policyDefinitionReferenceId = default;
            Optional<IReadOnlyList<string>> policyDefinitionGroupNames = default;
            Optional<string> effect = default;
            Optional<PolicySummaryResults> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionGroupNames"u8))
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
                    policyDefinitionGroupNames = array;
                    continue;
                }
                if (property.NameEquals("effect"u8))
                {
                    effect = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = PolicySummaryResults.DeserializePolicySummaryResults(property.Value);
                    continue;
                }
            }
            return new PolicyDefinitionSummary(policyDefinitionId.Value, policyDefinitionReferenceId.Value, Optional.ToList(policyDefinitionGroupNames), effect.Value, results.Value);
        }
    }
}