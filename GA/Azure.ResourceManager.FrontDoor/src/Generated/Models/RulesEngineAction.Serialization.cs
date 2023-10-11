// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RulesEngineAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(RequestHeaderActions))
            {
                writer.WritePropertyName("requestHeaderActions"u8);
                writer.WriteStartArray();
                foreach (var item in RequestHeaderActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResponseHeaderActions))
            {
                writer.WritePropertyName("responseHeaderActions"u8);
                writer.WriteStartArray();
                foreach (var item in ResponseHeaderActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RouteConfigurationOverride))
            {
                if (RouteConfigurationOverride != null)
                {
                    writer.WritePropertyName("routeConfigurationOverride"u8);
                    writer.WriteObjectValue(RouteConfigurationOverride);
                }
                else
                {
                    writer.WriteNull("routeConfigurationOverride");
                }
            }
            writer.WriteEndObject();
        }

        internal static RulesEngineAction DeserializeRulesEngineAction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<RulesEngineHeaderAction>> requestHeaderActions = default;
            Optional<IList<RulesEngineHeaderAction>> responseHeaderActions = default;
            Optional<RouteConfiguration> routeConfigurationOverride = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestHeaderActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RulesEngineHeaderAction> array = new List<RulesEngineHeaderAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RulesEngineHeaderAction.DeserializeRulesEngineHeaderAction(item));
                    }
                    requestHeaderActions = array;
                    continue;
                }
                if (property.NameEquals("responseHeaderActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RulesEngineHeaderAction> array = new List<RulesEngineHeaderAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RulesEngineHeaderAction.DeserializeRulesEngineHeaderAction(item));
                    }
                    responseHeaderActions = array;
                    continue;
                }
                if (property.NameEquals("routeConfigurationOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        routeConfigurationOverride = null;
                        continue;
                    }
                    routeConfigurationOverride = RouteConfiguration.DeserializeRouteConfiguration(property.Value);
                    continue;
                }
            }
            return new RulesEngineAction(Optional.ToList(requestHeaderActions), Optional.ToList(responseHeaderActions), routeConfigurationOverride.Value);
        }
    }
}