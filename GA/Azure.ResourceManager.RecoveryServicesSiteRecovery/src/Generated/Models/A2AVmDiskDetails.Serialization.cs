// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AVmDiskDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("diskUri"u8);
            writer.WriteStringValue(DiskUri.AbsoluteUri);
            writer.WritePropertyName("recoveryAzureStorageAccountId"u8);
            writer.WriteStringValue(RecoveryAzureStorageAccountId);
            writer.WritePropertyName("primaryStagingAzureStorageAccountId"u8);
            writer.WriteStringValue(PrimaryStagingAzureStorageAccountId);
            writer.WriteEndObject();
        }
    }
}