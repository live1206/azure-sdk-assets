// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxDiskGranularCopyLogDetails
    {
        internal static DataBoxDiskGranularCopyLogDetails DeserializeDataBoxDiskGranularCopyLogDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serialNumber = default;
            Optional<ResourceIdentifier> accountId = default;
            Optional<string> errorLogLink = default;
            Optional<string> verboseLogLink = default;
            DataBoxOrderType copyLogDetailsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorLogLink"u8))
                {
                    errorLogLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verboseLogLink"u8))
                {
                    verboseLogLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyLogDetailsType"u8))
                {
                    copyLogDetailsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
            }
            return new DataBoxDiskGranularCopyLogDetails(copyLogDetailsType, serialNumber.Value, accountId.Value, errorLogLink.Value, verboseLogLink.Value);
        }
    }
}
