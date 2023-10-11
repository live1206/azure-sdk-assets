// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class RouteMapRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(MatchCriteria))
            {
                writer.WritePropertyName("matchCriteria"u8);
                writer.WriteStartArray();
                foreach (var item in MatchCriteria)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextStepIfMatched))
            {
                writer.WritePropertyName("nextStepIfMatched"u8);
                writer.WriteStringValue(NextStepIfMatched.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static RouteMapRule DeserializeRouteMapRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IList<RouteCriterion>> matchCriteria = default;
            Optional<IList<RouteMapAction>> actions = default;
            Optional<RouteMapNextStepBehavior> nextStepIfMatched = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("matchCriteria"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteCriterion> array = new List<RouteCriterion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteCriterion.DeserializeRouteCriterion(item));
                    }
                    matchCriteria = array;
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteMapAction> array = new List<RouteMapAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteMapAction.DeserializeRouteMapAction(item));
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("nextStepIfMatched"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextStepIfMatched = new RouteMapNextStepBehavior(property.Value.GetString());
                    continue;
                }
            }
            return new RouteMapRule(name.Value, Optional.ToList(matchCriteria), Optional.ToList(actions), Optional.ToNullable(nextStepIfMatched));
        }
    }
}