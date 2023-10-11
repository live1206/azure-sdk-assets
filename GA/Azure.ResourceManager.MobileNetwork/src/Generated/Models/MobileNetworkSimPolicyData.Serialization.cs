// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class MobileNetworkSimPolicyData : IUtf8JsonSerializable
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
            writer.WritePropertyName("ueAmbr"u8);
            writer.WriteObjectValue(UeAmbr);
            writer.WritePropertyName("defaultSlice"u8);
            JsonSerializer.Serialize(writer, DefaultSlice); if (Optional.IsDefined(RfspIndex))
            {
                writer.WritePropertyName("rfspIndex"u8);
                writer.WriteNumberValue(RfspIndex.Value);
            }
            if (Optional.IsDefined(RegistrationTimer))
            {
                writer.WritePropertyName("registrationTimer"u8);
                writer.WriteNumberValue(RegistrationTimer.Value);
            }
            writer.WritePropertyName("sliceConfigurations"u8);
            writer.WriteStartArray();
            foreach (var item in SliceConfigurations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MobileNetworkSimPolicyData DeserializeMobileNetworkSimPolicyData(JsonElement element)
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
            Optional<MobileNetworkProvisioningState> provisioningState = default;
            Optional<IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState>> siteProvisioningState = default;
            Ambr ueAmbr = default;
            WritableSubResource defaultSlice = default;
            Optional<int> rfspIndex = default;
            Optional<int> registrationTimer = default;
            IList<MobileNetworkSliceConfiguration> sliceConfigurations = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MobileNetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("siteProvisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, MobileNetworkSiteProvisioningState> dictionary = new Dictionary<string, MobileNetworkSiteProvisioningState>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, new MobileNetworkSiteProvisioningState(property1.Value.GetString()));
                            }
                            siteProvisioningState = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("ueAmbr"u8))
                        {
                            ueAmbr = Ambr.DeserializeAmbr(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultSlice"u8))
                        {
                            defaultSlice = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("rfspIndex"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rfspIndex = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("registrationTimer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationTimer = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sliceConfigurations"u8))
                        {
                            List<MobileNetworkSliceConfiguration> array = new List<MobileNetworkSliceConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MobileNetworkSliceConfiguration.DeserializeMobileNetworkSliceConfiguration(item));
                            }
                            sliceConfigurations = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MobileNetworkSimPolicyData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), Optional.ToDictionary(siteProvisioningState), ueAmbr, defaultSlice, Optional.ToNullable(rfspIndex), Optional.ToNullable(registrationTimer), sliceConfigurations);
        }
    }
}