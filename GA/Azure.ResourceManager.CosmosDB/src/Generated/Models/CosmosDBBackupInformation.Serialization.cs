// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBBackupInformation
    {
        internal static CosmosDBBackupInformation DeserializeCosmosDBBackupInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContinuousBackupInformation> continuousBackupInformation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continuousBackupInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    continuousBackupInformation = ContinuousBackupInformation.DeserializeContinuousBackupInformation(property.Value);
                    continue;
                }
            }
            return new CosmosDBBackupInformation(continuousBackupInformation.Value);
        }
    }
}