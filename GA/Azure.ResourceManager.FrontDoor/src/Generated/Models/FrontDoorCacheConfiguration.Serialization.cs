// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class FrontDoorCacheConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QueryParameterStripDirective))
            {
                writer.WritePropertyName("queryParameterStripDirective"u8);
                writer.WriteStringValue(QueryParameterStripDirective.Value.ToString());
            }
            if (Optional.IsDefined(QueryParameters))
            {
                writer.WritePropertyName("queryParameters"u8);
                writer.WriteStringValue(QueryParameters);
            }
            if (Optional.IsDefined(DynamicCompression))
            {
                writer.WritePropertyName("dynamicCompression"u8);
                writer.WriteStringValue(DynamicCompression.Value.ToString());
            }
            if (Optional.IsDefined(CacheDuration))
            {
                writer.WritePropertyName("cacheDuration"u8);
                writer.WriteStringValue(CacheDuration.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static FrontDoorCacheConfiguration DeserializeFrontDoorCacheConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FrontDoorQuery> queryParameterStripDirective = default;
            Optional<string> queryParameters = default;
            Optional<DynamicCompressionEnabled> dynamicCompression = default;
            Optional<TimeSpan> cacheDuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryParameterStripDirective"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryParameterStripDirective = new FrontDoorQuery(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryParameters"u8))
                {
                    queryParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dynamicCompression"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicCompression = new DynamicCompressionEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new FrontDoorCacheConfiguration(Optional.ToNullable(queryParameterStripDirective), queryParameters.Value, Optional.ToNullable(dynamicCompression), Optional.ToNullable(cacheDuration));
        }
    }
}