// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppBackupPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DailyBackupsToKeep))
            {
                writer.WritePropertyName("dailyBackupsToKeep"u8);
                writer.WriteNumberValue(DailyBackupsToKeep.Value);
            }
            if (Optional.IsDefined(WeeklyBackupsToKeep))
            {
                writer.WritePropertyName("weeklyBackupsToKeep"u8);
                writer.WriteNumberValue(WeeklyBackupsToKeep.Value);
            }
            if (Optional.IsDefined(MonthlyBackupsToKeep))
            {
                writer.WritePropertyName("monthlyBackupsToKeep"u8);
                writer.WriteNumberValue(MonthlyBackupsToKeep.Value);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetAppBackupPolicyData DeserializeNetAppBackupPolicyData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> backupPolicyId = default;
            Optional<string> provisioningState = default;
            Optional<int> dailyBackupsToKeep = default;
            Optional<int> weeklyBackupsToKeep = default;
            Optional<int> monthlyBackupsToKeep = default;
            Optional<int> volumesAssigned = default;
            Optional<bool> enabled = default;
            Optional<IReadOnlyList<NetAppVolumeBackupDetail>> volumeBackups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("backupPolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupPolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dailyBackupsToKeep"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dailyBackupsToKeep = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weeklyBackupsToKeep"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weeklyBackupsToKeep = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("monthlyBackupsToKeep"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monthlyBackupsToKeep = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("volumesAssigned"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            volumesAssigned = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("volumeBackups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetAppVolumeBackupDetail> array = new List<NetAppVolumeBackupDetail>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetAppVolumeBackupDetail.DeserializeNetAppVolumeBackupDetail(item));
                            }
                            volumeBackups = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetAppBackupPolicyData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), backupPolicyId.Value, provisioningState.Value, Optional.ToNullable(dailyBackupsToKeep), Optional.ToNullable(weeklyBackupsToKeep), Optional.ToNullable(monthlyBackupsToKeep), Optional.ToNullable(volumesAssigned), Optional.ToNullable(enabled), Optional.ToList(volumeBackups));
        }
    }
}