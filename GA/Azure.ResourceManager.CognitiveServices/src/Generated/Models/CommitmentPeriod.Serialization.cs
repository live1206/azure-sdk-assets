// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CommitmentPeriod : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            writer.WriteEndObject();
        }

        internal static CommitmentPeriod DeserializeCommitmentPeriod(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> tier = default;
            Optional<int> count = default;
            Optional<CommitmentQuota> quota = default;
            Optional<DateTimeOffset> startDate = default;
            Optional<DateTimeOffset> endDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("quota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quota = CommitmentQuota.DeserializeCommitmentQuota(property.Value);
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new CommitmentPeriod(tier.Value, Optional.ToNullable(count), quota.Value, Optional.ToNullable(startDate), Optional.ToNullable(endDate));
        }
    }
}