// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ExportDeliveryDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            writer.WritePropertyName("container"u8);
            writer.WriteStringValue(Container);
            if (Optional.IsDefined(RootFolderPath))
            {
                writer.WritePropertyName("rootFolderPath"u8);
                writer.WriteStringValue(RootFolderPath);
            }
            if (Optional.IsDefined(SasToken))
            {
                writer.WritePropertyName("sasToken"u8);
                writer.WriteStringValue(SasToken);
            }
            if (Optional.IsDefined(StorageAccount))
            {
                writer.WritePropertyName("storageAccount"u8);
                writer.WriteStringValue(StorageAccount);
            }
            writer.WriteEndObject();
        }

        internal static ExportDeliveryDestination DeserializeExportDeliveryDestination(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            string container = default;
            Optional<string> rootFolderPath = default;
            Optional<string> sasToken = default;
            Optional<string> storageAccount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("container"u8))
                {
                    container = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootFolderPath"u8))
                {
                    rootFolderPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasToken"u8))
                {
                    sasToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccount"u8))
                {
                    storageAccount = property.Value.GetString();
                    continue;
                }
            }
            return new ExportDeliveryDestination(resourceId.Value, container, rootFolderPath.Value, sasToken.Value, storageAccount.Value);
        }
    }
}