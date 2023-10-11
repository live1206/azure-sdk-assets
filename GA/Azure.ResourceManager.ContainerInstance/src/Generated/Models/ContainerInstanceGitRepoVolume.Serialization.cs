// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerInstanceGitRepoVolume : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Directory))
            {
                writer.WritePropertyName("directory"u8);
                writer.WriteStringValue(Directory);
            }
            writer.WritePropertyName("repository"u8);
            writer.WriteStringValue(Repository);
            if (Optional.IsDefined(Revision))
            {
                writer.WritePropertyName("revision"u8);
                writer.WriteStringValue(Revision);
            }
            writer.WriteEndObject();
        }

        internal static ContainerInstanceGitRepoVolume DeserializeContainerInstanceGitRepoVolume(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> directory = default;
            string repository = default;
            Optional<string> revision = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("directory"u8))
                {
                    directory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repository"u8))
                {
                    repository = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("revision"u8))
                {
                    revision = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerInstanceGitRepoVolume(directory.Value, repository, revision.Value);
        }
    }
}