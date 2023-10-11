// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyProperties
    {
        internal static ContentKeyPolicyProperties DeserializeContentKeyPolicyProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> policyId = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<string> description = default;
            IReadOnlyList<ContentKeyPolicyOption> options = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"u8))
                {
                    List<ContentKeyPolicyOption> array = new List<ContentKeyPolicyOption>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentKeyPolicyOption.DeserializeContentKeyPolicyOption(item));
                    }
                    options = array;
                    continue;
                }
            }
            return new ContentKeyPolicyProperties(Optional.ToNullable(policyId), Optional.ToNullable(created), Optional.ToNullable(lastModified), description.Value, options);
        }
    }
}