// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class SubscriptionContractData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OwnerId))
            {
                writer.WritePropertyName("ownerId"u8);
                writer.WriteStringValue(OwnerId);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDate"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(NotifiesOn))
            {
                writer.WritePropertyName("notificationDate"u8);
                writer.WriteStringValue(NotifiesOn.Value, "O");
            }
            if (Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteStringValue(SecondaryKey);
            }
            if (Optional.IsDefined(StateComment))
            {
                writer.WritePropertyName("stateComment"u8);
                writer.WriteStringValue(StateComment);
            }
            if (Optional.IsDefined(AllowTracing))
            {
                writer.WritePropertyName("allowTracing"u8);
                writer.WriteBooleanValue(AllowTracing.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SubscriptionContractData DeserializeSubscriptionContractData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> ownerId = default;
            Optional<string> scope = default;
            Optional<string> displayName = default;
            Optional<SubscriptionState> state = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<DateTimeOffset> startDate = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<DateTimeOffset> endDate = default;
            Optional<DateTimeOffset> notificationDate = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<string> stateComment = default;
            Optional<bool> allowTracing = default;
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
                        if (property0.NameEquals("ownerId"u8))
                        {
                            ownerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToSubscriptionState();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("notificationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notificationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("primaryKey"u8))
                        {
                            primaryKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryKey"u8))
                        {
                            secondaryKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("stateComment"u8))
                        {
                            stateComment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowTracing"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowTracing = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SubscriptionContractData(id, name, type, systemData.Value, ownerId.Value, scope.Value, displayName.Value, Optional.ToNullable(state), Optional.ToNullable(createdDate), Optional.ToNullable(startDate), Optional.ToNullable(expirationDate), Optional.ToNullable(endDate), Optional.ToNullable(notificationDate), primaryKey.Value, secondaryKey.Value, stateComment.Value, Optional.ToNullable(allowTracing));
        }
    }
}