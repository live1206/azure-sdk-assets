// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class LocalRulestackUpdateProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PanETag))
            {
                writer.WritePropertyName("panEtag"u8);
                writer.WriteStringValue(PanETag.Value.ToString());
            }
            if (Optional.IsDefined(PanLocation))
            {
                writer.WritePropertyName("panLocation"u8);
                writer.WriteStringValue(PanLocation.Value);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AssociatedSubscriptions))
            {
                writer.WritePropertyName("associatedSubscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in AssociatedSubscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DefaultMode))
            {
                writer.WritePropertyName("defaultMode"u8);
                writer.WriteStringValue(DefaultMode.Value.ToString());
            }
            if (Optional.IsDefined(MinAppIdVersion))
            {
                writer.WritePropertyName("minAppIdVersion"u8);
                writer.WriteStringValue(MinAppIdVersion);
            }
            if (Optional.IsDefined(SecurityServices))
            {
                writer.WritePropertyName("securityServices"u8);
                writer.WriteObjectValue(SecurityServices);
            }
            writer.WriteEndObject();
        }
    }
}