// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    internal partial class UploadOciDriverTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DriverShare))
            {
                writer.WritePropertyName("driverShare"u8);
                writer.WriteObjectValue(DriverShare);
            }
            writer.WriteEndObject();
        }

        internal static UploadOciDriverTaskInput DeserializeUploadOciDriverTaskInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FileShare> driverShare = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("driverShare"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    driverShare = FileShare.DeserializeFileShare(property.Value);
                    continue;
                }
            }
            return new UploadOciDriverTaskInput(driverShare.Value);
        }
    }
}