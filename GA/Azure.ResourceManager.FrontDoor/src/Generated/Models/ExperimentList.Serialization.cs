// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    internal partial class ExperimentList
    {
        internal static ExperimentList DeserializeExperimentList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<FrontDoorExperimentData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FrontDoorExperimentData> array = new List<FrontDoorExperimentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FrontDoorExperimentData.DeserializeFrontDoorExperimentData(item));
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
            return new ExperimentList(Optional.ToList(value), nextLink.Value);
        }
    }
}