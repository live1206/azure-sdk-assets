// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class GovernanceAssignmentData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteStringValue(Owner);
            }
            if (Optional.IsDefined(RemediationDueOn))
            {
                writer.WritePropertyName("remediationDueDate"u8);
                writer.WriteStringValue(RemediationDueOn.Value, "O");
            }
            if (Optional.IsDefined(RemediationEta))
            {
                writer.WritePropertyName("remediationEta"u8);
                writer.WriteObjectValue(RemediationEta);
            }
            if (Optional.IsDefined(IsGracePeriod))
            {
                writer.WritePropertyName("isGracePeriod"u8);
                writer.WriteBooleanValue(IsGracePeriod.Value);
            }
            if (Optional.IsDefined(GovernanceEmailNotification))
            {
                writer.WritePropertyName("governanceEmailNotification"u8);
                writer.WriteObjectValue(GovernanceEmailNotification);
            }
            if (Optional.IsDefined(AdditionalData))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteObjectValue(AdditionalData);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static GovernanceAssignmentData DeserializeGovernanceAssignmentData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> owner = default;
            Optional<DateTimeOffset> remediationDueDate = default;
            Optional<RemediationEta> remediationEta = default;
            Optional<bool> isGracePeriod = default;
            Optional<GovernanceEmailNotification> governanceEmailNotification = default;
            Optional<GovernanceAssignmentAdditionalInfo> additionalData = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("owner"u8))
                        {
                            owner = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationDueDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remediationDueDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("remediationEta"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remediationEta = RemediationEta.DeserializeRemediationEta(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isGracePeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isGracePeriod = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("governanceEmailNotification"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            governanceEmailNotification = GovernanceEmailNotification.DeserializeGovernanceEmailNotification(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalData = GovernanceAssignmentAdditionalInfo.DeserializeGovernanceAssignmentAdditionalInfo(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new GovernanceAssignmentData(id, name, type, systemData.Value, owner.Value, Optional.ToNullable(remediationDueDate), remediationEta.Value, Optional.ToNullable(isGracePeriod), governanceEmailNotification.Value, additionalData.Value);
        }
    }
}
