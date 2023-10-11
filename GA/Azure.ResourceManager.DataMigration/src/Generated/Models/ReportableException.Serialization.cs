// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ReportableException
    {
        internal static ReportableException DeserializeReportableException(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> message = default;
            Optional<string> actionableMessage = default;
            Optional<string> filePath = default;
            Optional<string> lineNumber = default;
            Optional<int> hResult = default;
            Optional<string> stackTrace = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionableMessage"u8))
                {
                    actionableMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filePath"u8))
                {
                    filePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lineNumber"u8))
                {
                    lineNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hResult = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stackTrace"u8))
                {
                    stackTrace = property.Value.GetString();
                    continue;
                }
            }
            return new ReportableException(message.Value, actionableMessage.Value, filePath.Value, lineNumber.Value, Optional.ToNullable(hResult), stackTrace.Value);
        }
    }
}