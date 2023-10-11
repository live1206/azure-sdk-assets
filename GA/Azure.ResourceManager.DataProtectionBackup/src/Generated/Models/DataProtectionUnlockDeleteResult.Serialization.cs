// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionUnlockDeleteResult
    {
        internal static DataProtectionUnlockDeleteResult DeserializeDataProtectionUnlockDeleteResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> unlockDeleteExpiryTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unlockDeleteExpiryTime"u8))
                {
                    unlockDeleteExpiryTime = property.Value.GetString();
                    continue;
                }
            }
            return new DataProtectionUnlockDeleteResult(unlockDeleteExpiryTime.Value);
        }
    }
}