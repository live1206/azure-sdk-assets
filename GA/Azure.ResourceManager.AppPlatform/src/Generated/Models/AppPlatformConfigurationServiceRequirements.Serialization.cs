// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformConfigurationServiceRequirements
    {
        internal static AppPlatformConfigurationServiceRequirements DeserializeAppPlatformConfigurationServiceRequirements(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cpu = default;
            Optional<string> memory = default;
            Optional<int> instanceCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"u8))
                {
                    cpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    memory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new AppPlatformConfigurationServiceRequirements(cpu.Value, memory.Value, Optional.ToNullable(instanceCount));
        }
    }
}