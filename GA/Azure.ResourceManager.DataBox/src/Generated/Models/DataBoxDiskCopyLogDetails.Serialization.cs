// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxDiskCopyLogDetails
    {
        internal static DataBoxDiskCopyLogDetails DeserializeDataBoxDiskCopyLogDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskSerialNumber = default;
            Optional<string> errorLogLink = default;
            Optional<string> verboseLogLink = default;
            DataBoxOrderType copyLogDetailsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSerialNumber"u8))
                {
                    diskSerialNumber = property.Value.GetString();
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
            return new DataBoxDiskCopyLogDetails(copyLogDetailsType, diskSerialNumber.Value, errorLogLink.Value, verboseLogLink.Value);
        }
    }
}