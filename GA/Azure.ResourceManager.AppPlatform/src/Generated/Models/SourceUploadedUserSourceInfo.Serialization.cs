// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class SourceUploadedUserSourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactSelector))
            {
                writer.WritePropertyName("artifactSelector"u8);
                writer.WriteStringValue(ArtifactSelector);
            }
            if (Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
            }
            if (Optional.IsDefined(RelativePath))
            {
                writer.WritePropertyName("relativePath"u8);
                writer.WriteStringValue(RelativePath);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(UserSourceInfoType);
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            writer.WriteEndObject();
        }

        internal static SourceUploadedUserSourceInfo DeserializeSourceUploadedUserSourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> artifactSelector = default;
            Optional<string> runtimeVersion = default;
            Optional<string> relativePath = default;
            string type = default;
            Optional<string> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactSelector"u8))
                {
                    artifactSelector = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new SourceUploadedUserSourceInfo(type, version.Value, relativePath.Value, artifactSelector.Value, runtimeVersion.Value);
        }
    }
}
