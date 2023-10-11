// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    internal partial class MigrateMISyncCompleteCommandInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceDatabaseName"u8);
            writer.WriteStringValue(SourceDatabaseName);
            writer.WriteEndObject();
        }

        internal static MigrateMISyncCompleteCommandInput DeserializeMigrateMISyncCompleteCommandInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceDatabaseName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceDatabaseName"u8))
                {
                    sourceDatabaseName = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateMISyncCompleteCommandInput(sourceDatabaseName);
        }
    }
}