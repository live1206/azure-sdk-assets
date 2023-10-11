// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ValidateConfigurationResult
    {
        internal static ValidateConfigurationResult DeserializeValidateConfigurationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkFabricConfigurationState> configurationState = default;
            Optional<Uri> url = default;
            Optional<ResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationState = new NetworkFabricConfigurationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
            }
            return new ValidateConfigurationResult(error.Value, Optional.ToNullable(configurationState), url.Value);
        }
    }
}