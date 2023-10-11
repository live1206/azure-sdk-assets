// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterCreateOrUpdateProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterVersion))
            {
                writer.WritePropertyName("clusterVersion"u8);
                writer.WriteStringValue(ClusterVersion);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier.Value.ToString());
            }
            if (Optional.IsDefined(ClusterDefinition))
            {
                writer.WritePropertyName("clusterDefinition"u8);
                writer.WriteObjectValue(ClusterDefinition);
            }
            if (Optional.IsDefined(KafkaRestProperties))
            {
                writer.WritePropertyName("kafkaRestProperties"u8);
                writer.WriteObjectValue(KafkaRestProperties);
            }
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile);
            }
            if (Optional.IsDefined(ComputeProfile))
            {
                writer.WritePropertyName("computeProfile"u8);
                writer.WriteObjectValue(ComputeProfile);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(DiskEncryptionProperties))
            {
                writer.WritePropertyName("diskEncryptionProperties"u8);
                writer.WriteObjectValue(DiskEncryptionProperties);
            }
            if (Optional.IsDefined(EncryptionInTransitProperties))
            {
                writer.WritePropertyName("encryptionInTransitProperties"u8);
                writer.WriteObjectValue(EncryptionInTransitProperties);
            }
            if (Optional.IsDefined(MinSupportedTlsVersion))
            {
                writer.WritePropertyName("minSupportedTlsVersion"u8);
                writer.WriteStringValue(MinSupportedTlsVersion);
            }
            if (Optional.IsDefined(NetworkProperties))
            {
                writer.WritePropertyName("networkProperties"u8);
                writer.WriteObjectValue(NetworkProperties);
            }
            if (Optional.IsDefined(ComputeIsolationProperties))
            {
                writer.WritePropertyName("computeIsolationProperties"u8);
                writer.WriteObjectValue(ComputeIsolationProperties);
            }
            if (Optional.IsCollectionDefined(PrivateLinkConfigurations))
            {
                writer.WritePropertyName("privateLinkConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
