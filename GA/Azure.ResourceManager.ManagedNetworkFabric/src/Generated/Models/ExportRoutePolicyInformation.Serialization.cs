// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ExportRoutePolicyInformation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExportIPv4RoutePolicyId))
            {
                writer.WritePropertyName("exportIpv4RoutePolicyId"u8);
                writer.WriteStringValue(ExportIPv4RoutePolicyId);
            }
            if (Optional.IsDefined(ExportIPv6RoutePolicyId))
            {
                writer.WritePropertyName("exportIpv6RoutePolicyId"u8);
                writer.WriteStringValue(ExportIPv6RoutePolicyId);
            }
            writer.WriteEndObject();
        }

        internal static ExportRoutePolicyInformation DeserializeExportRoutePolicyInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> exportIPv4RoutePolicyId = default;
            Optional<ResourceIdentifier> exportIPv6RoutePolicyId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exportIpv4RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportIPv4RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exportIpv6RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportIPv6RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new ExportRoutePolicyInformation(exportIPv4RoutePolicyId.Value, exportIPv6RoutePolicyId.Value);
        }
    }
}