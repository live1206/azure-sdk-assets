// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyRuleTarget : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Caller))
            {
                writer.WritePropertyName("caller"u8);
                writer.WriteStringValue(Caller);
            }
            if (Optional.IsCollectionDefined(Operations))
            {
                writer.WritePropertyName("operations"u8);
                writer.WriteStartArray();
                foreach (var item in Operations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToString());
            }
            if (Optional.IsCollectionDefined(TargetObjects))
            {
                writer.WritePropertyName("targetObjects"u8);
                writer.WriteStartArray();
                foreach (var item in TargetObjects)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(InheritableSettings))
            {
                writer.WritePropertyName("inheritableSettings"u8);
                writer.WriteStartArray();
                foreach (var item in InheritableSettings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EnforcedSettings))
            {
                writer.WritePropertyName("enforcedSettings"u8);
                writer.WriteStartArray();
                foreach (var item in EnforcedSettings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RoleManagementPolicyRuleTarget DeserializeRoleManagementPolicyRuleTarget(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> caller = default;
            Optional<IList<string>> operations = default;
            Optional<RoleManagementAssignmentLevel> level = default;
            Optional<IList<string>> targetObjects = default;
            Optional<IList<string>> inheritableSettings = default;
            Optional<IList<string>> enforcedSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("caller"u8))
                {
                    caller = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    operations = array;
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = new RoleManagementAssignmentLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetObjects"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    targetObjects = array;
                    continue;
                }
                if (property.NameEquals("inheritableSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    inheritableSettings = array;
                    continue;
                }
                if (property.NameEquals("enforcedSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    enforcedSettings = array;
                    continue;
                }
            }
            return new RoleManagementPolicyRuleTarget(caller.Value, Optional.ToList(operations), Optional.ToNullable(level), Optional.ToList(targetObjects), Optional.ToList(inheritableSettings), Optional.ToList(enforcedSettings));
        }
    }
}