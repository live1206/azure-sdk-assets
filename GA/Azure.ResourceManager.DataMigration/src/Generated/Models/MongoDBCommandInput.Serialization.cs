// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBCommandInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ObjectName))
            {
                writer.WritePropertyName("objectName"u8);
                writer.WriteStringValue(ObjectName);
            }
            writer.WriteEndObject();
        }

        internal static MongoDBCommandInput DeserializeMongoDBCommandInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> objectName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectName"u8))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
            }
            return new MongoDBCommandInput(objectName.Value);
        }
    }
}