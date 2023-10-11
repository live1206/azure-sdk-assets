// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class ItemLevelRestoreTargetInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("restoreCriteria"u8);
            writer.WriteStartArray();
            foreach (var item in RestoreCriteria)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("datasourceInfo"u8);
            writer.WriteObjectValue(DatasourceInfo);
            if (Optional.IsDefined(DatasourceSetInfo))
            {
                writer.WritePropertyName("datasourceSetInfo"u8);
                writer.WriteObjectValue(DatasourceSetInfo);
            }
            if (Optional.IsDefined(DatasourceAuthCredentials))
            {
                writer.WritePropertyName("datasourceAuthCredentials"u8);
                writer.WriteObjectValue(DatasourceAuthCredentials);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("recoveryOption"u8);
            writer.WriteStringValue(RecoverySetting.ToString());
            if (Optional.IsDefined(RestoreLocation))
            {
                writer.WritePropertyName("restoreLocation"u8);
                writer.WriteStringValue(RestoreLocation.Value);
            }
            writer.WriteEndObject();
        }
    }
}