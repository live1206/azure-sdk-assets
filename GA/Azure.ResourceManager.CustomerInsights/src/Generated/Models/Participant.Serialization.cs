// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class Participant : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("profileTypeName"u8);
            writer.WriteStringValue(ProfileTypeName);
            writer.WritePropertyName("participantPropertyReferences"u8);
            writer.WriteStartArray();
            foreach (var item in ParticipantPropertyReferences)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("participantName"u8);
            writer.WriteStringValue(ParticipantName);
            if (Optional.IsCollectionDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role);
            }
            writer.WriteEndObject();
        }

        internal static Participant DeserializeParticipant(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string profileTypeName = default;
            IList<ParticipantPropertyReference> participantPropertyReferences = default;
            string participantName = default;
            Optional<IDictionary<string, string>> displayName = default;
            Optional<IDictionary<string, string>> description = default;
            Optional<string> role = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileTypeName"u8))
                {
                    profileTypeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("participantPropertyReferences"u8))
                {
                    List<ParticipantPropertyReference> array = new List<ParticipantPropertyReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParticipantPropertyReference.DeserializeParticipantPropertyReference(item));
                    }
                    participantPropertyReferences = array;
                    continue;
                }
                if (property.NameEquals("participantName"u8))
                {
                    participantName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    displayName = dictionary;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    description = dictionary;
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString();
                    continue;
                }
            }
            return new Participant(profileTypeName, participantPropertyReferences, participantName, Optional.ToDictionary(displayName), Optional.ToDictionary(description), role.Value);
        }
    }
}