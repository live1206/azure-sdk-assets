// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class AutoscaleSettingData : IUtf8JsonSerializable
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
            writer.WritePropertyName("profiles"u8);
            writer.WriteStartArray();
            foreach (var item in Profiles)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Notifications))
            {
                if (Notifications != null)
                {
                    writer.WritePropertyName("notifications"u8);
                    writer.WriteStartArray();
                    foreach (var item in Notifications)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("notifications");
                }
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(PredictiveAutoscalePolicy))
            {
                if (PredictiveAutoscalePolicy != null)
                {
                    writer.WritePropertyName("predictiveAutoscalePolicy"u8);
                    writer.WriteObjectValue(PredictiveAutoscalePolicy);
                }
                else
                {
                    writer.WriteNull("predictiveAutoscalePolicy");
                }
            }
            if (Optional.IsDefined(AutoscaleSettingName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(AutoscaleSettingName);
            }
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceUri"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (Optional.IsDefined(TargetResourceLocation))
            {
                writer.WritePropertyName("targetResourceLocation"u8);
                writer.WriteStringValue(TargetResourceLocation.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AutoscaleSettingData DeserializeAutoscaleSettingData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            IList<AutoscaleProfile> profiles = default;
            Optional<IList<AutoscaleNotification>> notifications = default;
            Optional<bool> enabled = default;
            Optional<PredictiveAutoscalePolicy> predictiveAutoscalePolicy = default;
            Optional<string> name0 = default;
            Optional<ResourceIdentifier> targetResourceUri = default;
            Optional<AzureLocation> targetResourceLocation = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("profiles"u8))
                        {
                            List<AutoscaleProfile> array = new List<AutoscaleProfile>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutoscaleProfile.DeserializeAutoscaleProfile(item));
                            }
                            profiles = array;
                            continue;
                        }
                        if (property0.NameEquals("notifications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                notifications = null;
                                continue;
                            }
                            List<AutoscaleNotification> array = new List<AutoscaleNotification>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutoscaleNotification.DeserializeAutoscaleNotification(item));
                            }
                            notifications = array;
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
                        if (property0.NameEquals("predictiveAutoscalePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                predictiveAutoscalePolicy = null;
                                continue;
                            }
                            predictiveAutoscalePolicy = PredictiveAutoscalePolicy.DeserializePredictiveAutoscalePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceUri = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetResourceLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AutoscaleSettingData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, profiles, Optional.ToList(notifications), Optional.ToNullable(enabled), predictiveAutoscalePolicy.Value, name0.Value, targetResourceUri.Value, Optional.ToNullable(targetResourceLocation));
        }
    }
}