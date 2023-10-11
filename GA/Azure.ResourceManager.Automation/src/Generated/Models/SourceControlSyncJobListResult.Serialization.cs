// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class SourceControlSyncJobListResult
    {
        internal static SourceControlSyncJobListResult DeserializeSourceControlSyncJobListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SourceControlSyncJob>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SourceControlSyncJob> array = new List<SourceControlSyncJob>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SourceControlSyncJob.DeserializeSourceControlSyncJob(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SourceControlSyncJobListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}