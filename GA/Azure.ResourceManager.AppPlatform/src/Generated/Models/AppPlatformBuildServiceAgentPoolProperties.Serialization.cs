// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformBuildServiceAgentPoolProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PoolSize))
            {
                writer.WritePropertyName("poolSize"u8);
                writer.WriteObjectValue(PoolSize);
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformBuildServiceAgentPoolProperties DeserializeAppPlatformBuildServiceAgentPoolProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> provisioningState = default;
            Optional<BuildServiceAgentPoolSizeProperties> poolSize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("poolSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    poolSize = BuildServiceAgentPoolSizeProperties.DeserializeBuildServiceAgentPoolSizeProperties(property.Value);
                    continue;
                }
            }
            return new AppPlatformBuildServiceAgentPoolProperties(provisioningState.Value, poolSize.Value);
        }
    }
}