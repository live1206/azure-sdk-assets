// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class ElasticCloudDeployment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static ElasticCloudDeployment DeserializeElasticCloudDeployment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> deploymentId = default;
            Optional<string> azureSubscriptionId = default;
            Optional<string> elasticsearchRegion = default;
            Optional<Uri> elasticsearchServiceUrl = default;
            Optional<Uri> kibanaServiceUrl = default;
            Optional<Uri> kibanaSsoUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentId"u8))
                {
                    deploymentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureSubscriptionId"u8))
                {
                    azureSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticsearchRegion"u8))
                {
                    elasticsearchRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticsearchServiceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elasticsearchServiceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kibanaServiceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kibanaServiceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kibanaSsoUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kibanaSsoUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ElasticCloudDeployment(name.Value, deploymentId.Value, azureSubscriptionId.Value, elasticsearchRegion.Value, elasticsearchServiceUrl.Value, kibanaServiceUrl.Value, kibanaSsoUrl.Value);
        }
    }
}