// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class WorkspaceConnectionSharedAccessSignature : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sas))
            {
                writer.WritePropertyName("sas"u8);
                writer.WriteStringValue(Sas);
            }
            writer.WriteEndObject();
        }

        internal static WorkspaceConnectionSharedAccessSignature DeserializeWorkspaceConnectionSharedAccessSignature(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sas = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sas"u8))
                {
                    sas = property.Value.GetString();
                    continue;
                }
            }
            return new WorkspaceConnectionSharedAccessSignature(sas.Value);
        }
    }
}
