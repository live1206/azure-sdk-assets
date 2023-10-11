// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class VerifiedPartnerData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PartnerRegistrationImmutableId))
            {
                writer.WritePropertyName("partnerRegistrationImmutableId"u8);
                writer.WriteStringValue(PartnerRegistrationImmutableId.Value);
            }
            if (Optional.IsDefined(OrganizationName))
            {
                writer.WritePropertyName("organizationName"u8);
                writer.WriteStringValue(OrganizationName);
            }
            if (Optional.IsDefined(PartnerDisplayName))
            {
                writer.WritePropertyName("partnerDisplayName"u8);
                writer.WriteStringValue(PartnerDisplayName);
            }
            if (Optional.IsDefined(PartnerTopicDetails))
            {
                writer.WritePropertyName("partnerTopicDetails"u8);
                writer.WriteObjectValue(PartnerTopicDetails);
            }
            if (Optional.IsDefined(PartnerDestinationDetails))
            {
                writer.WritePropertyName("partnerDestinationDetails"u8);
                writer.WriteObjectValue(PartnerDestinationDetails);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VerifiedPartnerData DeserializeVerifiedPartnerData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> partnerRegistrationImmutableId = default;
            Optional<string> organizationName = default;
            Optional<string> partnerDisplayName = default;
            Optional<PartnerDetails> partnerTopicDetails = default;
            Optional<PartnerDetails> partnerDestinationDetails = default;
            Optional<VerifiedPartnerProvisioningState> provisioningState = default;
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
                        if (property0.NameEquals("partnerRegistrationImmutableId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerRegistrationImmutableId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("organizationName"u8))
                        {
                            organizationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerDisplayName"u8))
                        {
                            partnerDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerTopicDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerTopicDetails = PartnerDetails.DeserializePartnerDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("partnerDestinationDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerDestinationDetails = PartnerDetails.DeserializePartnerDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VerifiedPartnerProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VerifiedPartnerData(id, name, type, systemData.Value, Optional.ToNullable(partnerRegistrationImmutableId), organizationName.Value, partnerDisplayName.Value, partnerTopicDetails.Value, partnerDestinationDetails.Value, Optional.ToNullable(provisioningState));
        }
    }
}