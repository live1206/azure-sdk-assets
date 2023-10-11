// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class RunbookTestJob
    {
        internal static RunbookTestJob DeserializeRunbookTestJob(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> creationTime = default;
            Optional<string> status = default;
            Optional<string> statusDetails = default;
            Optional<string> runOn = default;
            Optional<DateTimeOffset?> startTime = default;
            Optional<DateTimeOffset?> endTime = default;
            Optional<string> exception = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<DateTimeOffset?> lastStatusModifiedTime = default;
            Optional<IReadOnlyDictionary<string, string>> parameters = default;
            Optional<int> logActivityTrace = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusDetails"u8))
                {
                    statusDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runOn"u8))
                {
                    runOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("exception"u8))
                {
                    exception = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStatusModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastStatusModifiedTime = null;
                        continue;
                    }
                    lastStatusModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("logActivityTrace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logActivityTrace = property.Value.GetInt32();
                    continue;
                }
            }
            return new RunbookTestJob(Optional.ToNullable(creationTime), status.Value, statusDetails.Value, runOn.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), exception.Value, Optional.ToNullable(lastModifiedTime), Optional.ToNullable(lastStatusModifiedTime), Optional.ToDictionary(parameters), Optional.ToNullable(logActivityTrace));
        }
    }
}