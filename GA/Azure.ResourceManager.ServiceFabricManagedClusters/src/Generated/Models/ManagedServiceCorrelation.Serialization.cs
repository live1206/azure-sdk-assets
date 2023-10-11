// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedServiceCorrelation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("scheme"u8);
            writer.WriteStringValue(Scheme.ToString());
            writer.WritePropertyName("serviceName"u8);
            writer.WriteStringValue(ServiceName);
            writer.WriteEndObject();
        }

        internal static ManagedServiceCorrelation DeserializeManagedServiceCorrelation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceCorrelationScheme scheme = default;
            string serviceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheme"u8))
                {
                    scheme = new ManagedServiceCorrelationScheme(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceName"u8))
                {
                    serviceName = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedServiceCorrelation(scheme, serviceName);
        }
    }
}