// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSchemaSqlServerSqlDBTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("selectedDatabases"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(EncryptedKeyForSecureFields))
            {
                writer.WritePropertyName("encryptedKeyForSecureFields"u8);
                writer.WriteStringValue(EncryptedKeyForSecureFields);
            }
            if (Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn);
            }
            writer.WritePropertyName("sourceConnectionInfo"u8);
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WritePropertyName("targetConnectionInfo"u8);
            writer.WriteObjectValue(TargetConnectionInfo);
            writer.WriteEndObject();
        }

        internal static MigrateSchemaSqlServerSqlDBTaskInput DeserializeMigrateSchemaSqlServerSqlDBTaskInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MigrateSchemaSqlServerSqlDBDatabaseInput> selectedDatabases = default;
            Optional<string> encryptedKeyForSecureFields = default;
            Optional<string> startedOn = default;
            SqlConnectionInfo sourceConnectionInfo = default;
            SqlConnectionInfo targetConnectionInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSchemaSqlServerSqlDBDatabaseInput> array = new List<MigrateSchemaSqlServerSqlDBDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSchemaSqlServerSqlDBDatabaseInput.DeserializeMigrateSchemaSqlServerSqlDBDatabaseInput(item));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("encryptedKeyForSecureFields"u8))
                {
                    encryptedKeyForSecureFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    startedOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
            }
            return new MigrateSchemaSqlServerSqlDBTaskInput(sourceConnectionInfo, targetConnectionInfo, selectedDatabases, encryptedKeyForSecureFields.Value, startedOn.Value);
        }
    }
}