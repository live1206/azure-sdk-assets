// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ArcAgentProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(AgentAutoUpgrade))
            {
                writer.WritePropertyName("agentAutoUpgrade"u8);
                writer.WriteStringValue(AgentAutoUpgrade.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ArcAgentProfile DeserializeArcAgentProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> agentVersion = default;
            Optional<AutoUpgradeOption> agentAutoUpgrade = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentAutoUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentAutoUpgrade = new AutoUpgradeOption(property.Value.GetString());
                    continue;
                }
            }
            return new ArcAgentProfile(agentVersion.Value, Optional.ToNullable(agentAutoUpgrade));
        }
    }
}