// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class MdeOnboarding : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OnboardingPackageWindows))
            {
                writer.WritePropertyName("onboardingPackageWindows"u8);
                writer.WriteBase64StringValue(OnboardingPackageWindows, "D");
            }
            if (Optional.IsDefined(OnboardingPackageLinux))
            {
                writer.WritePropertyName("onboardingPackageLinux"u8);
                writer.WriteBase64StringValue(OnboardingPackageLinux, "D");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MdeOnboarding DeserializeMdeOnboarding(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<byte[]> onboardingPackageWindows = default;
            Optional<byte[]> onboardingPackageLinux = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("onboardingPackageWindows"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            onboardingPackageWindows = property0.Value.GetBytesFromBase64("D");
                            continue;
                        }
                        if (property0.NameEquals("onboardingPackageLinux"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            onboardingPackageLinux = property0.Value.GetBytesFromBase64("D");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MdeOnboarding(id, name, type, systemData.Value, onboardingPackageWindows.Value, onboardingPackageLinux.Value);
        }
    }
}