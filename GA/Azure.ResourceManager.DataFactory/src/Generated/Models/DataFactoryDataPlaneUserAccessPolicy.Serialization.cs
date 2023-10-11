// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryDataPlaneUserAccessPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Permissions))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStringValue(Permissions);
            }
            if (Optional.IsDefined(AccessResourcePath))
            {
                writer.WritePropertyName("accessResourcePath"u8);
                writer.WriteStringValue(AccessResourcePath);
            }
            if (Optional.IsDefined(ProfileName))
            {
                writer.WritePropertyName("profileName"u8);
                writer.WriteStringValue(ProfileName);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expireTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static DataFactoryDataPlaneUserAccessPolicy DeserializeDataFactoryDataPlaneUserAccessPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> permissions = default;
            Optional<string> accessResourcePath = default;
            Optional<string> profileName = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> expireTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("permissions"u8))
                {
                    permissions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessResourcePath"u8))
                {
                    accessResourcePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("profileName"u8))
                {
                    profileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expireTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expireTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new DataFactoryDataPlaneUserAccessPolicy(permissions.Value, accessResourcePath.Value, profileName.Value, Optional.ToNullable(startTime), Optional.ToNullable(expireTime));
        }
    }
}