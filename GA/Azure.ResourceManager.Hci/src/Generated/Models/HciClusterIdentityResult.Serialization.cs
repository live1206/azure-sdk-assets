// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciClusterIdentityResult
    {
        internal static HciClusterIdentityResult DeserializeHciClusterIdentityResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> aadClientId = default;
            Optional<Guid> aadTenantId = default;
            Optional<Guid> aadServicePrincipalObjectId = default;
            Optional<Guid> aadApplicationObjectId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("aadClientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadServicePrincipalObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadServicePrincipalObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadApplicationObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadApplicationObjectId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HciClusterIdentityResult(Optional.ToNullable(aadClientId), Optional.ToNullable(aadTenantId), Optional.ToNullable(aadServicePrincipalObjectId), Optional.ToNullable(aadApplicationObjectId));
        }
    }
}