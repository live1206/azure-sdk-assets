// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterVersionDetails
    {
        internal static ClusterVersionDetails DeserializeClusterVersionDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> codeVersion = default;
            Optional<DateTimeOffset> supportExpiryUtc = default;
            Optional<ClusterEnvironment> environment = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeVersion"u8))
                {
                    codeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportExpiryUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportExpiryUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("environment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    environment = new ClusterEnvironment(property.Value.GetString());
                    continue;
                }
            }
            return new ClusterVersionDetails(codeVersion.Value, Optional.ToNullable(supportExpiryUtc), Optional.ToNullable(environment));
        }
    }
}