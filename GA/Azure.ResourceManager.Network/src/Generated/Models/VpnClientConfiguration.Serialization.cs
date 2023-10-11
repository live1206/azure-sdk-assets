// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VpnClientAddressPool))
            {
                writer.WritePropertyName("vpnClientAddressPool"u8);
                writer.WriteObjectValue(VpnClientAddressPool);
            }
            if (Optional.IsCollectionDefined(VpnClientRootCertificates))
            {
                writer.WritePropertyName("vpnClientRootCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnClientRevokedCertificates))
            {
                writer.WritePropertyName("vpnClientRevokedCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientRevokedCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnClientProtocols))
            {
                writer.WritePropertyName("vpnClientProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnAuthenticationTypes))
            {
                writer.WritePropertyName("vpnAuthenticationTypes"u8);
                writer.WriteStartArray();
                foreach (var item in VpnAuthenticationTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnClientIPsecPolicies))
            {
                writer.WritePropertyName("vpnClientIpsecPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientIPsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RadiusServerAddress))
            {
                writer.WritePropertyName("radiusServerAddress"u8);
                writer.WriteStringValue(RadiusServerAddress);
            }
            if (Optional.IsDefined(RadiusServerSecret))
            {
                writer.WritePropertyName("radiusServerSecret"u8);
                writer.WriteStringValue(RadiusServerSecret);
            }
            if (Optional.IsCollectionDefined(RadiusServers))
            {
                writer.WritePropertyName("radiusServers"u8);
                writer.WriteStartArray();
                foreach (var item in RadiusServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AadTenant))
            {
                writer.WritePropertyName("aadTenant"u8);
                writer.WriteStringValue(AadTenant);
            }
            if (Optional.IsDefined(AadAudience))
            {
                writer.WritePropertyName("aadAudience"u8);
                writer.WriteStringValue(AadAudience);
            }
            if (Optional.IsDefined(AadIssuer))
            {
                writer.WritePropertyName("aadIssuer"u8);
                writer.WriteStringValue(AadIssuer);
            }
            if (Optional.IsCollectionDefined(VngClientConnectionConfigurations))
            {
                writer.WritePropertyName("vngClientConnectionConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in VngClientConnectionConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VpnClientConfiguration DeserializeVpnClientConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AddressSpace> vpnClientAddressPool = default;
            Optional<IList<VpnClientRootCertificate>> vpnClientRootCertificates = default;
            Optional<IList<VpnClientRevokedCertificate>> vpnClientRevokedCertificates = default;
            Optional<IList<VpnClientProtocol>> vpnClientProtocols = default;
            Optional<IList<VpnAuthenticationType>> vpnAuthenticationTypes = default;
            Optional<IList<IPsecPolicy>> vpnClientIPsecPolicies = default;
            Optional<string> radiusServerAddress = default;
            Optional<string> radiusServerSecret = default;
            Optional<IList<RadiusServer>> radiusServers = default;
            Optional<string> aadTenant = default;
            Optional<string> aadAudience = default;
            Optional<string> aadIssuer = default;
            Optional<IList<VngClientConnectionConfiguration>> vngClientConnectionConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vpnClientAddressPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vpnClientAddressPool = AddressSpace.DeserializeAddressSpace(property.Value);
                    continue;
                }
                if (property.NameEquals("vpnClientRootCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VpnClientRootCertificate> array = new List<VpnClientRootCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VpnClientRootCertificate.DeserializeVpnClientRootCertificate(item));
                    }
                    vpnClientRootCertificates = array;
                    continue;
                }
                if (property.NameEquals("vpnClientRevokedCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VpnClientRevokedCertificate> array = new List<VpnClientRevokedCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VpnClientRevokedCertificate.DeserializeVpnClientRevokedCertificate(item));
                    }
                    vpnClientRevokedCertificates = array;
                    continue;
                }
                if (property.NameEquals("vpnClientProtocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VpnClientProtocol> array = new List<VpnClientProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new VpnClientProtocol(item.GetString()));
                    }
                    vpnClientProtocols = array;
                    continue;
                }
                if (property.NameEquals("vpnAuthenticationTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VpnAuthenticationType> array = new List<VpnAuthenticationType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new VpnAuthenticationType(item.GetString()));
                    }
                    vpnAuthenticationTypes = array;
                    continue;
                }
                if (property.NameEquals("vpnClientIpsecPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPsecPolicy> array = new List<IPsecPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPsecPolicy.DeserializeIPsecPolicy(item));
                    }
                    vpnClientIPsecPolicies = array;
                    continue;
                }
                if (property.NameEquals("radiusServerAddress"u8))
                {
                    radiusServerAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("radiusServerSecret"u8))
                {
                    radiusServerSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("radiusServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RadiusServer> array = new List<RadiusServer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RadiusServer.DeserializeRadiusServer(item));
                    }
                    radiusServers = array;
                    continue;
                }
                if (property.NameEquals("aadTenant"u8))
                {
                    aadTenant = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadAudience"u8))
                {
                    aadAudience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadIssuer"u8))
                {
                    aadIssuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vngClientConnectionConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VngClientConnectionConfiguration> array = new List<VngClientConnectionConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VngClientConnectionConfiguration.DeserializeVngClientConnectionConfiguration(item));
                    }
                    vngClientConnectionConfigurations = array;
                    continue;
                }
            }
            return new VpnClientConfiguration(vpnClientAddressPool.Value, Optional.ToList(vpnClientRootCertificates), Optional.ToList(vpnClientRevokedCertificates), Optional.ToList(vpnClientProtocols), Optional.ToList(vpnAuthenticationTypes), Optional.ToList(vpnClientIPsecPolicies), radiusServerAddress.Value, radiusServerSecret.Value, Optional.ToList(radiusServers), aadTenant.Value, aadAudience.Value, aadIssuer.Value, Optional.ToList(vngClientConnectionConfigurations));
        }
    }
}