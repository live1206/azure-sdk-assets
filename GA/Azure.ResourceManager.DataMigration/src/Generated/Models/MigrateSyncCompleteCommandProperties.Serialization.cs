// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSyncCompleteCommandProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input);
            }
            if (Optional.IsDefined(CommandId))
            {
                writer.WritePropertyName("commandId"u8);
                writer.WriteStringValue(CommandId);
            }
            writer.WritePropertyName("commandType"u8);
            writer.WriteStringValue(CommandType.ToString());
            writer.WriteEndObject();
        }

        internal static MigrateSyncCompleteCommandProperties DeserializeMigrateSyncCompleteCommandProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MigrateSyncCompleteCommandInput> input = default;
            Optional<MigrateSyncCompleteCommandOutput> output = default;
            Optional<string> commandId = default;
            CommandType commandType = default;
            Optional<IReadOnlyList<ODataError>> errors = default;
            Optional<CommandState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = MigrateSyncCompleteCommandInput.DeserializeMigrateSyncCompleteCommandInput(property.Value);
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = MigrateSyncCompleteCommandOutput.DeserializeMigrateSyncCompleteCommandOutput(property.Value);
                    continue;
                }
                if (property.NameEquals("commandId"u8))
                {
                    commandId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commandType"u8))
                {
                    commandType = new CommandType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ODataError> array = new List<ODataError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ODataError.DeserializeODataError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new CommandState(property.Value.GetString());
                    continue;
                }
            }
            return new MigrateSyncCompleteCommandProperties(commandType, Optional.ToList(errors), Optional.ToNullable(state), input.Value, output.Value, commandId.Value);
        }
    }
}