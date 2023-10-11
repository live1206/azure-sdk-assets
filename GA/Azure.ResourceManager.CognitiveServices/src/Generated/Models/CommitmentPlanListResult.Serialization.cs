// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal partial class CommitmentPlanListResult
    {
        internal static CommitmentPlanListResult DeserializeCommitmentPlanListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<CommitmentPlanData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommitmentPlanData> array = new List<CommitmentPlanData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommitmentPlanData.DeserializeCommitmentPlanData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CommitmentPlanListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}