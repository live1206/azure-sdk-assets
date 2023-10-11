// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryWebhookEventSource
    {
        internal static ContainerRegistryWebhookEventSource DeserializeContainerRegistryWebhookEventSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> addr = default;
            Optional<string> instanceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addr"u8))
                {
                    addr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceID"u8))
                {
                    instanceId = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerRegistryWebhookEventSource(addr.Value, instanceId.Value);
        }
    }
}