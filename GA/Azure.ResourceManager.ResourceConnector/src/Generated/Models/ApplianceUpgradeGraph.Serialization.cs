// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    public partial class ApplianceUpgradeGraph
    {
        internal static ApplianceUpgradeGraph DeserializeApplianceUpgradeGraph(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<ApplianceUpgradeGraphProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ApplianceUpgradeGraphProperties.DeserializeApplianceUpgradeGraphProperties(property.Value);
                    continue;
                }
            }
            return new ApplianceUpgradeGraph(id.Value, name.Value, properties.Value);
        }
    }
}