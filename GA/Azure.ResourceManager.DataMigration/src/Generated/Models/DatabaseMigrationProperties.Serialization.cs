// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseMigrationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(SourceSqlConnection))
            {
                writer.WritePropertyName("sourceSqlConnection"u8);
                writer.WriteObjectValue(SourceSqlConnection);
            }
            if (Optional.IsDefined(SourceDatabaseName))
            {
                writer.WritePropertyName("sourceDatabaseName"u8);
                writer.WriteStringValue(SourceDatabaseName);
            }
            if (Optional.IsDefined(MigrationService))
            {
                writer.WritePropertyName("migrationService"u8);
                writer.WriteStringValue(MigrationService);
            }
            if (Optional.IsDefined(MigrationOperationId))
            {
                writer.WritePropertyName("migrationOperationId"u8);
                writer.WriteStringValue(MigrationOperationId);
            }
            if (Optional.IsDefined(TargetDatabaseCollation))
            {
                writer.WritePropertyName("targetDatabaseCollation"u8);
                writer.WriteStringValue(TargetDatabaseCollation);
            }
            if (Optional.IsDefined(ProvisioningError))
            {
                writer.WritePropertyName("provisioningError"u8);
                writer.WriteStringValue(ProvisioningError);
            }
            writer.WriteEndObject();
        }

        internal static DatabaseMigrationProperties DeserializeDatabaseMigrationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SqlDb": return DatabaseMigrationSqlDBProperties.DeserializeDatabaseMigrationSqlDBProperties(element);
                    case "SqlVm": return DatabaseMigrationSqlVmProperties.DeserializeDatabaseMigrationSqlVmProperties(element);
                    case "SqlMi": return DatabaseMigrationSqlMIProperties.DeserializeDatabaseMigrationSqlMIProperties(element);
                }
            }
            return UnknownDatabaseMigrationProperties.DeserializeUnknownDatabaseMigrationProperties(element);
        }
    }
}
