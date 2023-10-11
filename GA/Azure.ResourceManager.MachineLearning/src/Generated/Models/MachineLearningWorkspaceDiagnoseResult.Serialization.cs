// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningWorkspaceDiagnoseResult
    {
        internal static MachineLearningWorkspaceDiagnoseResult DeserializeMachineLearningWorkspaceDiagnoseResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningDiagnoseResultValue> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = MachineLearningDiagnoseResultValue.DeserializeMachineLearningDiagnoseResultValue(property.Value);
                    continue;
                }
            }
            return new MachineLearningWorkspaceDiagnoseResult(value.Value);
        }
    }
}
