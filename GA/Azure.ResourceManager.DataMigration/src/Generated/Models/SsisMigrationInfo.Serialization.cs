// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SsisMigrationInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SsisStoreType))
            {
                writer.WritePropertyName("ssisStoreType"u8);
                writer.WriteStringValue(SsisStoreType.Value.ToString());
            }
            if (Optional.IsDefined(ProjectOverwriteOption))
            {
                writer.WritePropertyName("projectOverwriteOption"u8);
                writer.WriteStringValue(ProjectOverwriteOption.Value.ToString());
            }
            if (Optional.IsDefined(EnvironmentOverwriteOption))
            {
                writer.WritePropertyName("environmentOverwriteOption"u8);
                writer.WriteStringValue(EnvironmentOverwriteOption.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SsisMigrationInfo DeserializeSsisMigrationInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SsisStoreType> ssisStoreType = default;
            Optional<SsisMigrationOverwriteOption> projectOverwriteOption = default;
            Optional<SsisMigrationOverwriteOption> environmentOverwriteOption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ssisStoreType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssisStoreType = new SsisStoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("projectOverwriteOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    projectOverwriteOption = new SsisMigrationOverwriteOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("environmentOverwriteOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    environmentOverwriteOption = new SsisMigrationOverwriteOption(property.Value.GetString());
                    continue;
                }
            }
            return new SsisMigrationInfo(Optional.ToNullable(ssisStoreType), Optional.ToNullable(projectOverwriteOption), Optional.ToNullable(environmentOverwriteOption));
        }
    }
}