// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterPodIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("namespace"u8);
            writer.WriteStringValue(Namespace);
            if (Optional.IsDefined(BindingSelector))
            {
                writer.WritePropertyName("bindingSelector"u8);
                writer.WriteStringValue(BindingSelector);
            }
            writer.WritePropertyName("identity"u8);
            writer.WriteObjectValue(Identity);
            writer.WriteEndObject();
        }

        internal static ManagedClusterPodIdentity DeserializeManagedClusterPodIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string @namespace = default;
            Optional<string> bindingSelector = default;
            ContainerServiceUserAssignedIdentity identity = default;
            Optional<ManagedClusterPodIdentityProvisioningState> provisioningState = default;
            Optional<ManagedClusterPodIdentityProvisioningInfo> provisioningInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bindingSelector"u8))
                {
                    bindingSelector = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = ContainerServiceUserAssignedIdentity.DeserializeContainerServiceUserAssignedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ManagedClusterPodIdentityProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningInfo = ManagedClusterPodIdentityProvisioningInfo.DeserializeManagedClusterPodIdentityProvisioningInfo(property.Value);
                    continue;
                }
            }
            return new ManagedClusterPodIdentity(name, @namespace, bindingSelector.Value, identity, Optional.ToNullable(provisioningState), provisioningInfo.Value);
        }
    }
}
