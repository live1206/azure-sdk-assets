// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class IoTHubStreamInputDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StreamInputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IotHubNamespace))
            {
                writer.WritePropertyName("iotHubNamespace"u8);
                writer.WriteStringValue(IotHubNamespace);
            }
            if (Optional.IsDefined(SharedAccessPolicyName))
            {
                writer.WritePropertyName("sharedAccessPolicyName"u8);
                writer.WriteStringValue(SharedAccessPolicyName);
            }
            if (Optional.IsDefined(SharedAccessPolicyKey))
            {
                writer.WritePropertyName("sharedAccessPolicyKey"u8);
                writer.WriteStringValue(SharedAccessPolicyKey);
            }
            if (Optional.IsDefined(ConsumerGroupName))
            {
                writer.WritePropertyName("consumerGroupName"u8);
                writer.WriteStringValue(ConsumerGroupName);
            }
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IoTHubStreamInputDataSource DeserializeIoTHubStreamInputDataSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> iotHubNamespace = default;
            Optional<string> sharedAccessPolicyName = default;
            Optional<string> sharedAccessPolicyKey = default;
            Optional<string> consumerGroupName = default;
            Optional<string> endpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("iotHubNamespace"u8))
                        {
                            iotHubNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyName"u8))
                        {
                            sharedAccessPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyKey"u8))
                        {
                            sharedAccessPolicyKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consumerGroupName"u8))
                        {
                            consumerGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpoint"u8))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IoTHubStreamInputDataSource(type, iotHubNamespace.Value, sharedAccessPolicyName.Value, sharedAccessPolicyKey.Value, consumerGroupName.Value, endpoint.Value);
        }
    }
}