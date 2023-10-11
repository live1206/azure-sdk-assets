// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformBuilderProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Stack))
            {
                writer.WritePropertyName("stack"u8);
                writer.WriteObjectValue(Stack);
            }
            if (Optional.IsCollectionDefined(BuildpackGroups))
            {
                writer.WritePropertyName("buildpackGroups"u8);
                writer.WriteStartArray();
                foreach (var item in BuildpackGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformBuilderProperties DeserializeAppPlatformBuilderProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformBuilderProvisioningState> provisioningState = default;
            Optional<AppPlatformClusterStackProperties> stack = default;
            Optional<IList<BuildpacksGroupProperties>> buildpackGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformBuilderProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stack"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stack = AppPlatformClusterStackProperties.DeserializeAppPlatformClusterStackProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("buildpackGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BuildpacksGroupProperties> array = new List<BuildpacksGroupProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BuildpacksGroupProperties.DeserializeBuildpacksGroupProperties(item));
                    }
                    buildpackGroups = array;
                    continue;
                }
            }
            return new AppPlatformBuilderProperties(Optional.ToNullable(provisioningState), stack.Value, Optional.ToList(buildpackGroups));
        }
    }
}