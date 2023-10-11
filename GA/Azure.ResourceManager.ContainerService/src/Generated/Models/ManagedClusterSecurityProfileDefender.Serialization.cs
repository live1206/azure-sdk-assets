// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterSecurityProfileDefender : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LogAnalyticsWorkspaceResourceId))
            {
                writer.WritePropertyName("logAnalyticsWorkspaceResourceId"u8);
                writer.WriteStringValue(LogAnalyticsWorkspaceResourceId);
            }
            if (Optional.IsDefined(SecurityMonitoring))
            {
                writer.WritePropertyName("securityMonitoring"u8);
                writer.WriteObjectValue(SecurityMonitoring);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterSecurityProfileDefender DeserializeManagedClusterSecurityProfileDefender(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> logAnalyticsWorkspaceResourceId = default;
            Optional<ManagedClusterSecurityProfileDefenderSecurityMonitoring> securityMonitoring = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logAnalyticsWorkspaceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logAnalyticsWorkspaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("securityMonitoring"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityMonitoring = ManagedClusterSecurityProfileDefenderSecurityMonitoring.DeserializeManagedClusterSecurityProfileDefenderSecurityMonitoring(property.Value);
                    continue;
                }
            }
            return new ManagedClusterSecurityProfileDefender(logAnalyticsWorkspaceResourceId.Value, securityMonitoring.Value);
        }
    }
}