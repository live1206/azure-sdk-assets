// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RecoveryPointDataStoreDetail : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointDataStoreId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(RecoveryPointDataStoreId.Value);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metaData"u8);
                writer.WriteStringValue(Metadata);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(RecoveryPointDataStoreType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RecoveryPointDataStoreType);
            }
            if (Optional.IsDefined(IsVisible))
            {
                writer.WritePropertyName("visible"u8);
                writer.WriteBooleanValue(IsVisible.Value);
            }
            writer.WriteEndObject();
        }

        internal static RecoveryPointDataStoreDetail DeserializeRecoveryPointDataStoreDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> expiryTime = default;
            Optional<Guid> id = default;
            Optional<string> metaData = default;
            Optional<string> state = default;
            Optional<string> type = default;
            Optional<bool> visible = default;
            Optional<DateTimeOffset> rehydrationExpiryTime = default;
            Optional<RecoveryPointDataStoreRehydrationStatus> rehydrationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("metaData"u8))
                {
                    metaData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("visible"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    visible = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rehydrationExpiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationExpiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("rehydrationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationStatus = new RecoveryPointDataStoreRehydrationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new RecoveryPointDataStoreDetail(Optional.ToNullable(creationTime), Optional.ToNullable(expiryTime), Optional.ToNullable(id), metaData.Value, state.Value, type.Value, Optional.ToNullable(visible), Optional.ToNullable(rehydrationExpiryTime), Optional.ToNullable(rehydrationStatus));
        }
    }
}