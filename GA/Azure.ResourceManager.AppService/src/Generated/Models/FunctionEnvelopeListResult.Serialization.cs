// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class FunctionEnvelopeListResult
    {
        internal static FunctionEnvelopeListResult DeserializeFunctionEnvelopeListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FunctionEnvelopeData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<FunctionEnvelopeData> array = new List<FunctionEnvelopeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FunctionEnvelopeData.DeserializeFunctionEnvelopeData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new FunctionEnvelopeListResult(value, nextLink.Value);
        }
    }
}