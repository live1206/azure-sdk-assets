// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class ResourceCertificateDetails
    {
        internal static ResourceCertificateDetails DeserializeResourceCertificateDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("authType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AccessControlService": return ResourceCertificateAndAcsDetails.DeserializeResourceCertificateAndAcsDetails(element);
                    case "AzureActiveDirectory": return ResourceCertificateAndAadDetails.DeserializeResourceCertificateAndAadDetails(element);
                }
            }
            return UnknownResourceCertificateDetails.DeserializeUnknownResourceCertificateDetails(element);
        }
    }
}