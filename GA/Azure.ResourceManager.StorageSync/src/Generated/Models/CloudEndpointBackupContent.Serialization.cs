// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudEndpointBackupContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureFileShare))
            {
                writer.WritePropertyName("azureFileShare"u8);
                writer.WriteStringValue(AzureFileShare);
            }
            writer.WriteEndObject();
        }
    }
}
