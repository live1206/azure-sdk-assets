// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceLinuxProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("adminUsername"u8);
            writer.WriteStringValue(AdminUsername);
            writer.WritePropertyName("ssh"u8);
            writer.WriteObjectValue(Ssh);
            writer.WriteEndObject();
        }

        internal static ContainerServiceLinuxProfile DeserializeContainerServiceLinuxProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string adminUsername = default;
            ContainerServiceSshConfiguration ssh = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ssh"u8))
                {
                    ssh = ContainerServiceSshConfiguration.DeserializeContainerServiceSshConfiguration(property.Value);
                    continue;
                }
            }
            return new ContainerServiceLinuxProfile(adminUsername, ssh);
        }
    }
}