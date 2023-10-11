// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDBTaskOutputTableLevel
    {
        internal static MigrateSqlServerSqlDBTaskOutputTableLevel DeserializeMigrateSqlServerSqlDBTaskOutputTableLevel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> objectName = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<MigrationState> state = default;
            Optional<string> statusMessage = default;
            Optional<long> itemsCount = default;
            Optional<long> itemsCompletedCount = default;
            Optional<string> errorPrefix = default;
            Optional<string> resultPrefix = default;
            Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectName"u8))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new MigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    itemsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("itemsCompletedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    itemsCompletedCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("errorPrefix"u8))
                {
                    errorPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultPrefix"u8))
                {
                    resultPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateSqlServerSqlDBTaskOutputTableLevel(id.Value, resultType, objectName.Value, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), Optional.ToNullable(state), statusMessage.Value, Optional.ToNullable(itemsCount), Optional.ToNullable(itemsCompletedCount), errorPrefix.Value, resultPrefix.Value);
        }
    }
}