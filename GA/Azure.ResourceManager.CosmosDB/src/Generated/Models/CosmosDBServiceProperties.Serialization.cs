// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBServiceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InstanceSize))
            {
                writer.WritePropertyName("instanceSize"u8);
                writer.WriteStringValue(InstanceSize.Value.ToString());
            }
            if (Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount"u8);
                writer.WriteNumberValue(InstanceCount.Value);
            }
            writer.WritePropertyName("serviceType"u8);
            writer.WriteStringValue(ServiceType.ToString());
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBServiceProperties DeserializeCosmosDBServiceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("serviceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DataTransfer": return DataTransferServiceProperties.DeserializeDataTransferServiceProperties(element);
                    case "GraphAPICompute": return GraphApiComputeServiceProperties.DeserializeGraphApiComputeServiceProperties(element);
                    case "MaterializedViewsBuilder": return MaterializedViewsBuilderServiceProperties.DeserializeMaterializedViewsBuilderServiceProperties(element);
                    case "SqlDedicatedGateway": return SqlDedicatedGatewayServiceProperties.DeserializeSqlDedicatedGatewayServiceProperties(element);
                }
            }
            return UnknownServiceResourceProperties.DeserializeUnknownServiceResourceProperties(element);
        }
    }
}