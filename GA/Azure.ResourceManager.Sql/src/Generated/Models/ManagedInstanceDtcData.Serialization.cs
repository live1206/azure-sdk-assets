// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstanceDtcData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DtcEnabled))
            {
                writer.WritePropertyName("dtcEnabled"u8);
                writer.WriteBooleanValue(DtcEnabled.Value);
            }
            if (Optional.IsDefined(SecuritySettings))
            {
                writer.WritePropertyName("securitySettings"u8);
                writer.WriteObjectValue(SecuritySettings);
            }
            if (Optional.IsCollectionDefined(ExternalDnsSuffixSearchList))
            {
                writer.WritePropertyName("externalDnsSuffixSearchList"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalDnsSuffixSearchList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedInstanceDtcData DeserializeManagedInstanceDtcData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> dtcEnabled = default;
            Optional<ManagedInstanceDtcSecuritySettings> securitySettings = default;
            Optional<IList<string>> externalDnsSuffixSearchList = default;
            Optional<string> dtcHostNameDnsSuffix = default;
            Optional<JobExecutionProvisioningState> provisioningState = default;
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
                        if (property0.NameEquals("dtcEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dtcEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("securitySettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securitySettings = ManagedInstanceDtcSecuritySettings.DeserializeManagedInstanceDtcSecuritySettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("externalDnsSuffixSearchList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            externalDnsSuffixSearchList = array;
                            continue;
                        }
                        if (property0.NameEquals("dtcHostNameDnsSuffix"u8))
                        {
                            dtcHostNameDnsSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new JobExecutionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedInstanceDtcData(id, name, type, systemData.Value, Optional.ToNullable(dtcEnabled), securitySettings.Value, Optional.ToList(externalDnsSuffixSearchList), dtcHostNameDnsSuffix.Value, Optional.ToNullable(provisioningState));
        }
    }
}