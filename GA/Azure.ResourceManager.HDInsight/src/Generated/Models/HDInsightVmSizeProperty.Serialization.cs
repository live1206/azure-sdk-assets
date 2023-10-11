// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightVmSizeProperty
    {
        internal static HDInsightVmSizeProperty DeserializeHDInsightVmSizeProperty(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<int> cores = default;
            Optional<string> dataDiskStorageTier = default;
            Optional<string> label = default;
            Optional<long> maxDataDiskCount = default;
            Optional<long> memoryInMB = default;
            Optional<bool> supportedByVirtualMachines = default;
            Optional<bool> supportedByWebWorkerRoles = default;
            Optional<long> virtualMachineResourceDiskSizeInMB = default;
            Optional<long> webWorkerResourceDiskSizeInMB = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataDiskStorageTier"u8))
                {
                    dataDiskStorageTier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxDataDiskCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDataDiskCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryInMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("supportedByVirtualMachines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedByVirtualMachines = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedByWebWorkerRoles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedByWebWorkerRoles = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("virtualMachineResourceDiskSizeInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineResourceDiskSizeInMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("webWorkerResourceDiskSizeInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    webWorkerResourceDiskSizeInMB = property.Value.GetInt64();
                    continue;
                }
            }
            return new HDInsightVmSizeProperty(name.Value, Optional.ToNullable(cores), dataDiskStorageTier.Value, label.Value, Optional.ToNullable(maxDataDiskCount), Optional.ToNullable(memoryInMB), Optional.ToNullable(supportedByVirtualMachines), Optional.ToNullable(supportedByWebWorkerRoles), Optional.ToNullable(virtualMachineResourceDiskSizeInMB), Optional.ToNullable(webWorkerResourceDiskSizeInMB));
        }
    }
}