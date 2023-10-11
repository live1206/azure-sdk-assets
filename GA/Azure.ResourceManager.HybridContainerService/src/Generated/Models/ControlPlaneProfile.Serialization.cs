// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ControlPlaneProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ControlPlaneEndpoint))
            {
                writer.WritePropertyName("controlPlaneEndpoint"u8);
                writer.WriteObjectValue(ControlPlaneEndpoint);
            }
            if (Optional.IsDefined(LinuxProfile))
            {
                writer.WritePropertyName("linuxProfile"u8);
                writer.WriteObjectValue(LinuxProfile);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MaxCount))
            {
                writer.WritePropertyName("maxCount"u8);
                writer.WriteNumberValue(MaxCount.Value);
            }
            if (Optional.IsDefined(MaxPods))
            {
                writer.WritePropertyName("maxPods"u8);
                writer.WriteNumberValue(MaxPods.Value);
            }
            if (Optional.IsDefined(MinCount))
            {
                writer.WritePropertyName("minCount"u8);
                writer.WriteNumberValue(MinCount.Value);
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NodeLabels))
            {
                writer.WritePropertyName("nodeLabels"u8);
                writer.WriteStartObject();
                foreach (var item in NodeLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeTaints))
            {
                writer.WritePropertyName("nodeTaints"u8);
                writer.WriteStartArray();
                foreach (var item in NodeTaints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(NodeImageVersion))
            {
                writer.WritePropertyName("nodeImageVersion"u8);
                writer.WriteStringValue(NodeImageVersion);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(CloudProviderProfile))
            {
                writer.WritePropertyName("cloudProviderProfile"u8);
                writer.WriteObjectValue(CloudProviderProfile);
            }
            writer.WriteEndObject();
        }

        internal static ControlPlaneProfile DeserializeControlPlaneProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ControlPlaneEndpointProfileControlPlaneEndpoint> controlPlaneEndpoint = default;
            Optional<LinuxProfileProperties> linuxProfile = default;
            Optional<string> name = default;
            Optional<int> count = default;
            Optional<IList<string>> availabilityZones = default;
            Optional<int> maxCount = default;
            Optional<int> maxPods = default;
            Optional<int> minCount = default;
            Optional<Mode> mode = default;
            Optional<IDictionary<string, string>> nodeLabels = default;
            Optional<IList<string>> nodeTaints = default;
            Optional<OSType> osType = default;
            Optional<string> nodeImageVersion = default;
            Optional<string> vmSize = default;
            Optional<CloudProviderProfile> cloudProviderProfile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("controlPlaneEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlPlaneEndpoint = ControlPlaneEndpointProfileControlPlaneEndpoint.DeserializeControlPlaneEndpointProfileControlPlaneEndpoint(property.Value);
                    continue;
                }
                if (property.NameEquals("linuxProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxProfile = LinuxProfileProperties.DeserializeLinuxProfileProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("availabilityZones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    availabilityZones = array;
                    continue;
                }
                if (property.NameEquals("maxCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPods = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new Mode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeLabels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    nodeLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeTaints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nodeTaints = array;
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new OSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeImageVersion"u8))
                {
                    nodeImageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloudProviderProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudProviderProfile = CloudProviderProfile.DeserializeCloudProviderProfile(property.Value);
                    continue;
                }
            }
            return new ControlPlaneProfile(Optional.ToNullable(count), Optional.ToList(availabilityZones), Optional.ToNullable(maxCount), Optional.ToNullable(maxPods), Optional.ToNullable(minCount), Optional.ToNullable(mode), Optional.ToDictionary(nodeLabels), Optional.ToList(nodeTaints), Optional.ToNullable(osType), nodeImageVersion.Value, vmSize.Value, cloudProviderProfile.Value, name.Value, controlPlaneEndpoint.Value, linuxProfile.Value);
        }
    }
}
