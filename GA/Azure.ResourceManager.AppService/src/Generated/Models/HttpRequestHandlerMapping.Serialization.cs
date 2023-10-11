// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class HttpRequestHandlerMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Extension))
            {
                writer.WritePropertyName("extension"u8);
                writer.WriteStringValue(Extension);
            }
            if (Optional.IsDefined(ScriptProcessor))
            {
                writer.WritePropertyName("scriptProcessor"u8);
                writer.WriteStringValue(ScriptProcessor);
            }
            if (Optional.IsDefined(Arguments))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStringValue(Arguments);
            }
            writer.WriteEndObject();
        }

        internal static HttpRequestHandlerMapping DeserializeHttpRequestHandlerMapping(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> extension = default;
            Optional<string> scriptProcessor = default;
            Optional<string> arguments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extension"u8))
                {
                    extension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptProcessor"u8))
                {
                    scriptProcessor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"u8))
                {
                    arguments = property.Value.GetString();
                    continue;
                }
            }
            return new HttpRequestHandlerMapping(extension.Value, scriptProcessor.Value, arguments.Value);
        }
    }
}