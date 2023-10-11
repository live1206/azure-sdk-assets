// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAccountKeyDatastoreSecrets : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                if (Key != null)
                {
                    writer.WritePropertyName("key"u8);
                    writer.WriteStringValue(Key);
                }
                else
                {
                    writer.WriteNull("key");
                }
            }
            writer.WritePropertyName("secretsType"u8);
            writer.WriteStringValue(SecretsType.ToString());
            writer.WriteEndObject();
        }

        internal static MachineLearningAccountKeyDatastoreSecrets DeserializeMachineLearningAccountKeyDatastoreSecrets(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> key = default;
            SecretsType secretsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        key = null;
                        continue;
                    }
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretsType"u8))
                {
                    secretsType = new SecretsType(property.Value.GetString());
                    continue;
                }
            }
            return new MachineLearningAccountKeyDatastoreSecrets(secretsType, key.Value);
        }
    }
}