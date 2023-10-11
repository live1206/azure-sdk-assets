// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RecommendedActionErrorInfo
    {
        internal static RecommendedActionErrorInfo DeserializeRecommendedActionErrorInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> errorCode = default;
            Optional<ActionRetryableState> isRetryable = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isRetryable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRetryable = property.Value.GetString().ToActionRetryableState();
                    continue;
                }
            }
            return new RecommendedActionErrorInfo(errorCode.Value, Optional.ToNullable(isRetryable));
        }
    }
}