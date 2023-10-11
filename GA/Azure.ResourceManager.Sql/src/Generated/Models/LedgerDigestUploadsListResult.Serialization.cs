// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class LedgerDigestUploadsListResult
    {
        internal static LedgerDigestUploadsListResult DeserializeLedgerDigestUploadsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<LedgerDigestUploadData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LedgerDigestUploadData> array = new List<LedgerDigestUploadData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LedgerDigestUploadData.DeserializeLedgerDigestUploadData(item));
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
            return new LedgerDigestUploadsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}