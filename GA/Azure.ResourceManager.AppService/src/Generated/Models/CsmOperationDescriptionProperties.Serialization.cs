// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class CsmOperationDescriptionProperties
    {
        internal static CsmOperationDescriptionProperties DeserializeCsmOperationDescriptionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ServiceSpecification> serviceSpecification = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceSpecification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceSpecification = ServiceSpecification.DeserializeServiceSpecification(property.Value);
                    continue;
                }
            }
            return new CsmOperationDescriptionProperties(serviceSpecification.Value);
        }
    }
}