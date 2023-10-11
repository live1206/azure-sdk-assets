// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class DiagnosticsCollection
    {
        internal static DiagnosticsCollection DeserializeDiagnosticsCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ContainerAppDiagnosticData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ContainerAppDiagnosticData> array = new List<ContainerAppDiagnosticData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppDiagnosticData.DeserializeContainerAppDiagnosticData(item));
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
            return new DiagnosticsCollection(value, nextLink.Value);
        }
    }
}