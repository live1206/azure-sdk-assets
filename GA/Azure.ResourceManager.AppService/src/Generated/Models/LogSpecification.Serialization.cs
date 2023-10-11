// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class LogSpecification
    {
        internal static LogSpecification DeserializeLogSpecification(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<TimeSpan> blobDuration = default;
            Optional<string> logFilterPattern = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("logFilterPattern"u8))
                {
                    logFilterPattern = property.Value.GetString();
                    continue;
                }
            }
            return new LogSpecification(name.Value, displayName.Value, Optional.ToNullable(blobDuration), logFilterPattern.Value);
        }
    }
}