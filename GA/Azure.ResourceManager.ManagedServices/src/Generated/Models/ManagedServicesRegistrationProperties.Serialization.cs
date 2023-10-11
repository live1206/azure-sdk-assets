// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesRegistrationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("authorizations"u8);
            writer.WriteStartArray();
            foreach (var item in Authorizations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(EligibleAuthorizations))
            {
                writer.WritePropertyName("eligibleAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in EligibleAuthorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RegistrationDefinitionName))
            {
                writer.WritePropertyName("registrationDefinitionName"u8);
                writer.WriteStringValue(RegistrationDefinitionName);
            }
            writer.WritePropertyName("managedByTenantId"u8);
            writer.WriteStringValue(ManagedByTenantId);
            writer.WriteEndObject();
        }

        internal static ManagedServicesRegistrationProperties DeserializeManagedServicesRegistrationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            IList<ManagedServicesAuthorization> authorizations = default;
            Optional<IList<ManagedServicesEligibleAuthorization>> eligibleAuthorizations = default;
            Optional<string> registrationDefinitionName = default;
            Guid managedByTenantId = default;
            Optional<ManagedServicesProvisioningState> provisioningState = default;
            Optional<Guid> manageeTenantId = default;
            Optional<string> manageeTenantName = default;
            Optional<string> managedByTenantName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizations"u8))
                {
                    List<ManagedServicesAuthorization> array = new List<ManagedServicesAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesAuthorization.DeserializeManagedServicesAuthorization(item));
                    }
                    authorizations = array;
                    continue;
                }
                if (property.NameEquals("eligibleAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServicesEligibleAuthorization> array = new List<ManagedServicesEligibleAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesEligibleAuthorization.DeserializeManagedServicesEligibleAuthorization(item));
                    }
                    eligibleAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("registrationDefinitionName"u8))
                {
                    registrationDefinitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByTenantId"u8))
                {
                    managedByTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ManagedServicesProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("manageeTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    manageeTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("manageeTenantName"u8))
                {
                    manageeTenantName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByTenantName"u8))
                {
                    managedByTenantName = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedServicesRegistrationProperties(description.Value, authorizations, Optional.ToList(eligibleAuthorizations), registrationDefinitionName.Value, managedByTenantId, Optional.ToNullable(provisioningState), Optional.ToNullable(manageeTenantId), manageeTenantName.Value, managedByTenantName.Value);
        }
    }
}