// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SsisEnvironmentReference
    {
        internal static SsisEnvironmentReference DeserializeSsisEnvironmentReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> id = default;
            Optional<string> environmentFolderName = default;
            Optional<string> environmentName = default;
            Optional<string> referenceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("environmentFolderName"u8))
                {
                    environmentFolderName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentName"u8))
                {
                    environmentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceType"u8))
                {
                    referenceType = property.Value.GetString();
                    continue;
                }
            }
            return new SsisEnvironmentReference(Optional.ToNullable(id), environmentFolderName.Value, environmentName.Value, referenceType.Value);
        }
    }
}
