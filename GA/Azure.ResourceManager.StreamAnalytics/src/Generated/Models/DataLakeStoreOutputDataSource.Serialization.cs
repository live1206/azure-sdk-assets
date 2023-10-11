// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class DataLakeStoreOutputDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken"u8);
                writer.WriteStringValue(RefreshToken);
            }
            if (Optional.IsDefined(TokenUserPrincipalName))
            {
                writer.WritePropertyName("tokenUserPrincipalName"u8);
                writer.WriteStringValue(TokenUserPrincipalName);
            }
            if (Optional.IsDefined(TokenUserDisplayName))
            {
                writer.WritePropertyName("tokenUserDisplayName"u8);
                writer.WriteStringValue(TokenUserDisplayName);
            }
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(FilePathPrefix))
            {
                writer.WritePropertyName("filePathPrefix"u8);
                writer.WriteStringValue(FilePathPrefix);
            }
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat"u8);
                writer.WriteStringValue(DateFormat);
            }
            if (Optional.IsDefined(TimeFormat))
            {
                writer.WritePropertyName("timeFormat"u8);
                writer.WriteStringValue(TimeFormat);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataLakeStoreOutputDataSource DeserializeDataLakeStoreOutputDataSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> refreshToken = default;
            Optional<string> tokenUserPrincipalName = default;
            Optional<string> tokenUserDisplayName = default;
            Optional<string> accountName = default;
            Optional<Guid> tenantId = default;
            Optional<string> filePathPrefix = default;
            Optional<string> dateFormat = default;
            Optional<string> timeFormat = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("refreshToken"u8))
                        {
                            refreshToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tokenUserPrincipalName"u8))
                        {
                            tokenUserPrincipalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tokenUserDisplayName"u8))
                        {
                            tokenUserDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("filePathPrefix"u8))
                        {
                            filePathPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dateFormat"u8))
                        {
                            dateFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeFormat"u8))
                        {
                            timeFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataLakeStoreOutputDataSource(type, refreshToken.Value, tokenUserPrincipalName.Value, tokenUserDisplayName.Value, accountName.Value, Optional.ToNullable(tenantId), filePathPrefix.Value, dateFormat.Value, timeFormat.Value, Optional.ToNullable(authenticationMode));
        }
    }
}