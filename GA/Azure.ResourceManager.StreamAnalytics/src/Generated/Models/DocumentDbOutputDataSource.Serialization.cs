// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class DocumentDbOutputDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountId))
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId);
            }
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey"u8);
                writer.WriteStringValue(AccountKey);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                writer.WriteStringValue(Database);
            }
            if (Optional.IsDefined(CollectionNamePattern))
            {
                writer.WritePropertyName("collectionNamePattern"u8);
                writer.WriteStringValue(CollectionNamePattern);
            }
            if (Optional.IsDefined(PartitionKey))
            {
                writer.WritePropertyName("partitionKey"u8);
                writer.WriteStringValue(PartitionKey);
            }
            if (Optional.IsDefined(DocumentId))
            {
                writer.WritePropertyName("documentId"u8);
                writer.WriteStringValue(DocumentId);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DocumentDbOutputDataSource DeserializeDocumentDbOutputDataSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> accountId = default;
            Optional<string> accountKey = default;
            Optional<string> database = default;
            Optional<string> collectionNamePattern = default;
            Optional<string> partitionKey = default;
            Optional<string> documentId = default;
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
                        if (property0.NameEquals("accountId"u8))
                        {
                            accountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountKey"u8))
                        {
                            accountKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("database"u8))
                        {
                            database = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("collectionNamePattern"u8))
                        {
                            collectionNamePattern = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partitionKey"u8))
                        {
                            partitionKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentId"u8))
                        {
                            documentId = property0.Value.GetString();
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
            return new DocumentDbOutputDataSource(type, accountId.Value, accountKey.Value, database.Value, collectionNamePattern.Value, partitionKey.Value, documentId.Value, Optional.ToNullable(authenticationMode));
        }
    }
}