// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class InstanceFailoverGroupReadOnlyEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FailoverPolicy))
            {
                writer.WritePropertyName("failoverPolicy"u8);
                writer.WriteStringValue(FailoverPolicy.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static InstanceFailoverGroupReadOnlyEndpoint DeserializeInstanceFailoverGroupReadOnlyEndpoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReadOnlyEndpointFailoverPolicy> failoverPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failoverPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverPolicy = new ReadOnlyEndpointFailoverPolicy(property.Value.GetString());
                    continue;
                }
            }
            return new InstanceFailoverGroupReadOnlyEndpoint(Optional.ToNullable(failoverPolicy));
        }
    }
}