// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataStoreSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("dataStoreType"u8);
            writer.WriteStringValue(DataStoreType.ToString());
            writer.WriteEndObject();
        }

        internal static DataStoreSettings DeserializeDataStoreSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureOperationalStoreParameters": return OperationalDataStoreSettings.DeserializeOperationalDataStoreSettings(element);
                }
            }
            return UnknownDataStoreParameters.DeserializeUnknownDataStoreParameters(element);
        }
    }
}