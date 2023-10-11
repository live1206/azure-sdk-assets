// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayWebApplicationFirewallConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(Enabled);
            writer.WritePropertyName("firewallMode"u8);
            writer.WriteStringValue(FirewallMode.ToString());
            writer.WritePropertyName("ruleSetType"u8);
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion"u8);
            writer.WriteStringValue(RuleSetVersion);
            if (Optional.IsCollectionDefined(DisabledRuleGroups))
            {
                writer.WritePropertyName("disabledRuleGroups"u8);
                writer.WriteStartArray();
                foreach (var item in DisabledRuleGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RequestBodyCheck))
            {
                writer.WritePropertyName("requestBodyCheck"u8);
                writer.WriteBooleanValue(RequestBodyCheck.Value);
            }
            if (Optional.IsDefined(MaxRequestBodySize))
            {
                writer.WritePropertyName("maxRequestBodySize"u8);
                writer.WriteNumberValue(MaxRequestBodySize.Value);
            }
            if (Optional.IsDefined(MaxRequestBodySizeInKb))
            {
                writer.WritePropertyName("maxRequestBodySizeInKb"u8);
                writer.WriteNumberValue(MaxRequestBodySizeInKb.Value);
            }
            if (Optional.IsDefined(FileUploadLimitInMb))
            {
                writer.WritePropertyName("fileUploadLimitInMb"u8);
                writer.WriteNumberValue(FileUploadLimitInMb.Value);
            }
            if (Optional.IsCollectionDefined(Exclusions))
            {
                writer.WritePropertyName("exclusions"u8);
                writer.WriteStartArray();
                foreach (var item in Exclusions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayWebApplicationFirewallConfiguration DeserializeApplicationGatewayWebApplicationFirewallConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            ApplicationGatewayFirewallMode firewallMode = default;
            string ruleSetType = default;
            string ruleSetVersion = default;
            Optional<IList<ApplicationGatewayFirewallDisabledRuleGroup>> disabledRuleGroups = default;
            Optional<bool> requestBodyCheck = default;
            Optional<int> maxRequestBodySize = default;
            Optional<int> maxRequestBodySizeInKb = default;
            Optional<int> fileUploadLimitInMb = default;
            Optional<IList<ApplicationGatewayFirewallExclusion>> exclusions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("firewallMode"u8))
                {
                    firewallMode = new ApplicationGatewayFirewallMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleSetType"u8))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"u8))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disabledRuleGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayFirewallDisabledRuleGroup> array = new List<ApplicationGatewayFirewallDisabledRuleGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayFirewallDisabledRuleGroup.DeserializeApplicationGatewayFirewallDisabledRuleGroup(item));
                    }
                    disabledRuleGroups = array;
                    continue;
                }
                if (property.NameEquals("requestBodyCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestBodyCheck = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxRequestBodySize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRequestBodySize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxRequestBodySizeInKb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRequestBodySizeInKb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fileUploadLimitInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileUploadLimitInMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exclusions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayFirewallExclusion> array = new List<ApplicationGatewayFirewallExclusion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayFirewallExclusion.DeserializeApplicationGatewayFirewallExclusion(item));
                    }
                    exclusions = array;
                    continue;
                }
            }
            return new ApplicationGatewayWebApplicationFirewallConfiguration(enabled, firewallMode, ruleSetType, ruleSetVersion, Optional.ToList(disabledRuleGroups), Optional.ToNullable(requestBodyCheck), Optional.ToNullable(maxRequestBodySize), Optional.ToNullable(maxRequestBodySizeInKb), Optional.ToNullable(fileUploadLimitInMb), Optional.ToList(exclusions));
        }
    }
}