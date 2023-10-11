// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class UpdateTopicSpacesConfigurationInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(RouteTopicResourceId))
            {
                writer.WritePropertyName("routeTopicResourceId"u8);
                writer.WriteStringValue(RouteTopicResourceId);
            }
            if (Optional.IsDefined(RoutingEnrichments))
            {
                writer.WritePropertyName("routingEnrichments"u8);
                writer.WriteObjectValue(RoutingEnrichments);
            }
            if (Optional.IsDefined(ClientAuthentication))
            {
                writer.WritePropertyName("clientAuthentication"u8);
                writer.WriteObjectValue(ClientAuthentication);
            }
            if (Optional.IsDefined(MaximumSessionExpiryInHours))
            {
                writer.WritePropertyName("maximumSessionExpiryInHours"u8);
                writer.WriteNumberValue(MaximumSessionExpiryInHours.Value);
            }
            if (Optional.IsDefined(MaximumClientSessionsPerAuthenticationName))
            {
                writer.WritePropertyName("maximumClientSessionsPerAuthenticationName"u8);
                writer.WriteNumberValue(MaximumClientSessionsPerAuthenticationName.Value);
            }
            if (Optional.IsDefined(RoutingIdentityInfo))
            {
                writer.WritePropertyName("routingIdentityInfo"u8);
                writer.WriteObjectValue(RoutingIdentityInfo);
            }
            writer.WriteEndObject();
        }
    }
}