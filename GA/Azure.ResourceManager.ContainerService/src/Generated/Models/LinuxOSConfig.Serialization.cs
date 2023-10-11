// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class LinuxOSConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sysctls))
            {
                writer.WritePropertyName("sysctls"u8);
                writer.WriteObjectValue(Sysctls);
            }
            if (Optional.IsDefined(TransparentHugePageEnabled))
            {
                writer.WritePropertyName("transparentHugePageEnabled"u8);
                writer.WriteStringValue(TransparentHugePageEnabled);
            }
            if (Optional.IsDefined(TransparentHugePageDefrag))
            {
                writer.WritePropertyName("transparentHugePageDefrag"u8);
                writer.WriteStringValue(TransparentHugePageDefrag);
            }
            if (Optional.IsDefined(SwapFileSizeInMB))
            {
                writer.WritePropertyName("swapFileSizeMB"u8);
                writer.WriteNumberValue(SwapFileSizeInMB.Value);
            }
            writer.WriteEndObject();
        }

        internal static LinuxOSConfig DeserializeLinuxOSConfig(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SysctlConfig> sysctls = default;
            Optional<string> transparentHugePageEnabled = default;
            Optional<string> transparentHugePageDefrag = default;
            Optional<int> swapFileSizeMB = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sysctls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sysctls = SysctlConfig.DeserializeSysctlConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("transparentHugePageEnabled"u8))
                {
                    transparentHugePageEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transparentHugePageDefrag"u8))
                {
                    transparentHugePageDefrag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("swapFileSizeMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    swapFileSizeMB = property.Value.GetInt32();
                    continue;
                }
            }
            return new LinuxOSConfig(sysctls.Value, transparentHugePageEnabled.Value, transparentHugePageDefrag.Value, Optional.ToNullable(swapFileSizeMB));
        }
    }
}
