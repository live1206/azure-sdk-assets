// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppMinorVersion
    {
        internal static WebAppMinorVersion DeserializeWebAppMinorVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayText = default;
            Optional<string> value = default;
            Optional<WebAppRuntimes> stackSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayText"u8))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stackSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stackSettings = WebAppRuntimes.DeserializeWebAppRuntimes(property.Value);
                    continue;
                }
            }
            return new WebAppMinorVersion(displayText.Value, value.Value, stackSettings.Value);
        }
    }
}