// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class CustomSetupBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CustomSetupBaseType);
            writer.WriteEndObject();
        }

        internal static CustomSetupBase DeserializeCustomSetupBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzPowerShellSetup": return AzPowerShellSetup.DeserializeAzPowerShellSetup(element);
                    case "CmdkeySetup": return CmdkeySetup.DeserializeCmdkeySetup(element);
                    case "ComponentSetup": return ComponentSetup.DeserializeComponentSetup(element);
                    case "EnvironmentVariableSetup": return EnvironmentVariableSetup.DeserializeEnvironmentVariableSetup(element);
                }
            }
            return UnknownCustomSetupBase.DeserializeUnknownCustomSetupBase(element);
        }
    }
}