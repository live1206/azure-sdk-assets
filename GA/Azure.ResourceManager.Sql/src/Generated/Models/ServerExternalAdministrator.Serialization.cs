// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ServerExternalAdministrator : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorType))
            {
                writer.WritePropertyName("administratorType"u8);
                writer.WriteStringValue(AdministratorType.Value.ToString());
            }
            if (Optional.IsDefined(PrincipalType))
            {
                writer.WritePropertyName("principalType"u8);
                writer.WriteStringValue(PrincipalType.Value.ToString());
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login"u8);
                writer.WriteStringValue(Login);
            }
            if (Optional.IsDefined(Sid))
            {
                writer.WritePropertyName("sid"u8);
                writer.WriteStringValue(Sid.Value);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(IsAzureADOnlyAuthenticationEnabled))
            {
                writer.WritePropertyName("azureADOnlyAuthentication"u8);
                writer.WriteBooleanValue(IsAzureADOnlyAuthenticationEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static ServerExternalAdministrator DeserializeServerExternalAdministrator(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlAdministratorType> administratorType = default;
            Optional<SqlServerPrincipalType> principalType = default;
            Optional<string> login = default;
            Optional<Guid> sid = default;
            Optional<Guid> tenantId = default;
            Optional<bool> azureADOnlyAuthentication = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("administratorType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    administratorType = new SqlAdministratorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("principalType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    principalType = new SqlServerPrincipalType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("login"u8))
                {
                    login = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("azureADOnlyAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureADOnlyAuthentication = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ServerExternalAdministrator(Optional.ToNullable(administratorType), Optional.ToNullable(principalType), login.Value, Optional.ToNullable(sid), Optional.ToNullable(tenantId), Optional.ToNullable(azureADOnlyAuthentication));
        }
    }
}