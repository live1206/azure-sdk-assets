// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class StepStatus
    {
        internal static StepStatus DeserializeStepStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> stepName = default;
            Optional<string> stepId = default;
            Optional<string> status = default;
            Optional<IReadOnlyList<BranchStatus>> branches = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stepName"u8))
                {
                    stepName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stepId"u8))
                {
                    stepId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("branches"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BranchStatus> array = new List<BranchStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BranchStatus.DeserializeBranchStatus(item));
                    }
                    branches = array;
                    continue;
                }
            }
            return new StepStatus(stepName.Value, stepId.Value, status.Value, Optional.ToList(branches));
        }
    }
}