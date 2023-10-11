// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDBTaskOutput
    {
        internal static MigrateSqlServerSqlDBTaskOutput DeserializeMigrateSqlServerSqlDBTaskOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelOutput": return MigrateSqlServerSqlDBTaskOutputDatabaseLevel.DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigrateSqlServerSqlDBTaskOutputError.DeserializeMigrateSqlServerSqlDBTaskOutputError(element);
                    case "MigrationDatabaseLevelValidationOutput": return MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult.DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(element);
                    case "MigrationLevelOutput": return MigrateSqlServerSqlDBTaskOutputMigrationLevel.DeserializeMigrateSqlServerSqlDBTaskOutputMigrationLevel(element);
                    case "MigrationValidationOutput": return MigrateSqlServerSqlDBTaskOutputValidationResult.DeserializeMigrateSqlServerSqlDBTaskOutputValidationResult(element);
                    case "TableLevelOutput": return MigrateSqlServerSqlDBTaskOutputTableLevel.DeserializeMigrateSqlServerSqlDBTaskOutputTableLevel(element);
                }
            }
            return UnknownMigrateSqlServerSqlDBTaskOutput.DeserializeUnknownMigrateSqlServerSqlDBTaskOutput(element);
        }
    }
}