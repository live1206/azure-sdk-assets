// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterJobProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType.ToString());
            writer.WriteEndObject();
        }

        internal static ClusterJobProperties DeserializeClusterJobProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FlinkJob": return FlinkJobProperties.DeserializeFlinkJobProperties(element);
                }
            }
            return UnknownClusterJobProperties.DeserializeUnknownClusterJobProperties(element);
        }
    }
}