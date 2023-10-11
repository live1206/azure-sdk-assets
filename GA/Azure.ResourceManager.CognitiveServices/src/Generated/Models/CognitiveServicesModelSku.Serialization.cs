// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesModelSku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(UsageName))
            {
                writer.WritePropertyName("usageName"u8);
                writer.WriteStringValue(UsageName);
            }
            if (Optional.IsDefined(DeprecationOn))
            {
                writer.WritePropertyName("deprecationDate"u8);
                writer.WriteStringValue(DeprecationOn.Value, "O");
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity);
            }
            writer.WriteEndObject();
        }

        internal static CognitiveServicesModelSku DeserializeCognitiveServicesModelSku(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> usageName = default;
            Optional<DateTimeOffset> deprecationDate = default;
            Optional<CognitiveServicesCapacityConfig> capacity = default;
            Optional<IReadOnlyList<ServiceAccountCallRateLimit>> rateLimits = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usageName"u8))
                {
                    usageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deprecationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deprecationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = CognitiveServicesCapacityConfig.DeserializeCognitiveServicesCapacityConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("rateLimits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAccountCallRateLimit> array = new List<ServiceAccountCallRateLimit>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAccountCallRateLimit.DeserializeServiceAccountCallRateLimit(item));
                    }
                    rateLimits = array;
                    continue;
                }
            }
            return new CognitiveServicesModelSku(name.Value, usageName.Value, Optional.ToNullable(deprecationDate), capacity.Value, Optional.ToList(rateLimits));
        }
    }
}