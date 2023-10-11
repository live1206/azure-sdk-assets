// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFailbackSyncDetails
    {
        internal static InMageRcmFailbackSyncDetails DeserializeInMageRcmFailbackSyncDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryDiskReplicationProgressHealth> progressHealth = default;
            Optional<long> transferredBytes = default;
            Optional<long> last15MinutesTransferredBytes = default;
            Optional<DateTimeOffset> lastDataTransferTimeUtc = default;
            Optional<long> processedBytes = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> lastRefreshTime = default;
            Optional<int> progressPercentage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("progressHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressHealth = new SiteRecoveryDiskReplicationProgressHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("transferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("last15MinutesTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    last15MinutesTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastDataTransferTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastDataTransferTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("processedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processedBytes = property.Value.GetInt64();
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
                if (property.NameEquals("lastRefreshTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRefreshTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("progressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressPercentage = property.Value.GetInt32();
                    continue;
                }
            }
            return new InMageRcmFailbackSyncDetails(Optional.ToNullable(progressHealth), Optional.ToNullable(transferredBytes), Optional.ToNullable(last15MinutesTransferredBytes), Optional.ToNullable(lastDataTransferTimeUtc), Optional.ToNullable(processedBytes), Optional.ToNullable(startTime), Optional.ToNullable(lastRefreshTime), Optional.ToNullable(progressPercentage));
        }
    }
}
