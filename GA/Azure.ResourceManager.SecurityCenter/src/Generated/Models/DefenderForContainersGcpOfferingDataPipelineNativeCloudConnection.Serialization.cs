// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceAccountEmailAddress))
            {
                writer.WritePropertyName("serviceAccountEmailAddress"u8);
                writer.WriteStringValue(ServiceAccountEmailAddress);
            }
            if (Optional.IsDefined(WorkloadIdentityProviderId))
            {
                writer.WritePropertyName("workloadIdentityProviderId"u8);
                writer.WriteStringValue(WorkloadIdentityProviderId);
            }
            writer.WriteEndObject();
        }

        internal static DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection DeserializeDefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceAccountEmailAddress = default;
            Optional<string> workloadIdentityProviderId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceAccountEmailAddress"u8))
                {
                    serviceAccountEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
            }
            return new DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(serviceAccountEmailAddress.Value, workloadIdentityProviderId.Value);
        }
    }
}