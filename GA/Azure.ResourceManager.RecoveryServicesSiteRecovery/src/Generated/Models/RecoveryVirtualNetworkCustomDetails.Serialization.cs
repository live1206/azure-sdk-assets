// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryVirtualNetworkCustomDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            writer.WriteEndObject();
        }

        internal static RecoveryVirtualNetworkCustomDetails DeserializeRecoveryVirtualNetworkCustomDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Existing": return ExistingRecoveryVirtualNetwork.DeserializeExistingRecoveryVirtualNetwork(element);
                    case "New": return NewRecoveryVirtualNetwork.DeserializeNewRecoveryVirtualNetwork(element);
                }
            }
            return UnknownRecoveryVirtualNetworkCustomDetails.DeserializeUnknownRecoveryVirtualNetworkCustomDetails(element);
        }
    }
}