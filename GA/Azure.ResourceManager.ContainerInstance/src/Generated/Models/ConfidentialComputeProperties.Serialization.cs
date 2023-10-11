// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    internal partial class ConfidentialComputeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CcePolicy))
            {
                writer.WritePropertyName("ccePolicy"u8);
                writer.WriteStringValue(CcePolicy);
            }
            writer.WriteEndObject();
        }

        internal static ConfidentialComputeProperties DeserializeConfidentialComputeProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ccePolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ccePolicy"u8))
                {
                    ccePolicy = property.Value.GetString();
                    continue;
                }
            }
            return new ConfidentialComputeProperties(ccePolicy.Value);
        }
    }
}