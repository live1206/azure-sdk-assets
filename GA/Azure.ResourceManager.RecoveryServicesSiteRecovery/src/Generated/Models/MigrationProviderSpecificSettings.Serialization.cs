// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class MigrationProviderSpecificSettings
    {
        internal static MigrationProviderSpecificSettings DeserializeMigrationProviderSpecificSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "VMwareCbt": return VMwareCbtMigrationDetails.DeserializeVMwareCbtMigrationDetails(element);
                }
            }
            return UnknownMigrationProviderSpecificSettings.DeserializeUnknownMigrationProviderSpecificSettings(element);
        }
    }
}