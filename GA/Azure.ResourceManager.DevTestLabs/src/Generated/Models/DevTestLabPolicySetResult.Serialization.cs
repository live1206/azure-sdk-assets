// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabPolicySetResult
    {
        internal static DevTestLabPolicySetResult DeserializeDevTestLabPolicySetResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> hasError = default;
            Optional<IReadOnlyList<DevTestLabPolicyViolation>> policyViolations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hasError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyViolations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabPolicyViolation> array = new List<DevTestLabPolicyViolation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabPolicyViolation.DeserializeDevTestLabPolicyViolation(item));
                    }
                    policyViolations = array;
                    continue;
                }
            }
            return new DevTestLabPolicySetResult(Optional.ToNullable(hasError), Optional.ToList(policyViolations));
        }
    }
}