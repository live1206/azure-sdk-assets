// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RecoveryPointDiskConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NumberOfDisksIncludedInBackup))
            {
                writer.WritePropertyName("numberOfDisksIncludedInBackup"u8);
                writer.WriteNumberValue(NumberOfDisksIncludedInBackup.Value);
            }
            if (Optional.IsDefined(NumberOfDisksAttachedToVm))
            {
                writer.WritePropertyName("numberOfDisksAttachedToVm"u8);
                writer.WriteNumberValue(NumberOfDisksAttachedToVm.Value);
            }
            if (Optional.IsCollectionDefined(IncludedDiskList))
            {
                writer.WritePropertyName("includedDiskList"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedDiskList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedDiskList))
            {
                writer.WritePropertyName("excludedDiskList"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedDiskList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RecoveryPointDiskConfiguration DeserializeRecoveryPointDiskConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> numberOfDisksIncludedInBackup = default;
            Optional<int> numberOfDisksAttachedToVm = default;
            Optional<IList<DiskInformation>> includedDiskList = default;
            Optional<IList<DiskInformation>> excludedDiskList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numberOfDisksIncludedInBackup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfDisksIncludedInBackup = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numberOfDisksAttachedToVm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfDisksAttachedToVm = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("includedDiskList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiskInformation> array = new List<DiskInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskInformation.DeserializeDiskInformation(item));
                    }
                    includedDiskList = array;
                    continue;
                }
                if (property.NameEquals("excludedDiskList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiskInformation> array = new List<DiskInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskInformation.DeserializeDiskInformation(item));
                    }
                    excludedDiskList = array;
                    continue;
                }
            }
            return new RecoveryPointDiskConfiguration(Optional.ToNullable(numberOfDisksIncludedInBackup), Optional.ToNullable(numberOfDisksAttachedToVm), Optional.ToList(includedDiskList), Optional.ToList(excludedDiskList));
        }
    }
}