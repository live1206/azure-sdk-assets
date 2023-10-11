// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstanceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedInstanceCreateMode))
            {
                writer.WritePropertyName("managedInstanceCreateMode"u8);
                writer.WriteStringValue(ManagedInstanceCreateMode.Value.ToString());
            }
            if (Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin"u8);
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(VCores))
            {
                writer.WritePropertyName("vCores"u8);
                writer.WriteNumberValue(VCores.Value);
            }
            if (Optional.IsDefined(StorageSizeInGB))
            {
                writer.WritePropertyName("storageSizeInGB"u8);
                writer.WriteNumberValue(StorageSizeInGB.Value);
            }
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation"u8);
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(ManagedDnsZonePartner))
            {
                writer.WritePropertyName("dnsZonePartner"u8);
                writer.WriteStringValue(ManagedDnsZonePartner);
            }
            if (Optional.IsDefined(IsPublicDataEndpointEnabled))
            {
                writer.WritePropertyName("publicDataEndpointEnabled"u8);
                writer.WriteBooleanValue(IsPublicDataEndpointEnabled.Value);
            }
            if (Optional.IsDefined(SourceManagedInstanceId))
            {
                writer.WritePropertyName("sourceManagedInstanceId"u8);
                writer.WriteStringValue(SourceManagedInstanceId);
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime"u8);
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (Optional.IsDefined(ProxyOverride))
            {
                writer.WritePropertyName("proxyOverride"u8);
                writer.WriteStringValue(ProxyOverride.Value.ToString());
            }
            if (Optional.IsDefined(TimezoneId))
            {
                writer.WritePropertyName("timezoneId"u8);
                writer.WriteStringValue(TimezoneId);
            }
            if (Optional.IsDefined(InstancePoolId))
            {
                writer.WritePropertyName("instancePoolId"u8);
                writer.WriteStringValue(InstancePoolId);
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId"u8);
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinimalTlsVersion);
            }
            if (Optional.IsDefined(RequestedBackupStorageRedundancy))
            {
                writer.WritePropertyName("requestedBackupStorageRedundancy"u8);
                writer.WriteStringValue(RequestedBackupStorageRedundancy.Value.ToString());
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId))
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId.AbsoluteUri);
            }
            if (Optional.IsDefined(Administrators))
            {
                writer.WritePropertyName("administrators"u8);
                writer.WriteObjectValue(Administrators);
            }
            if (Optional.IsDefined(ServicePrincipal))
            {
                writer.WritePropertyName("servicePrincipal"u8);
                writer.WriteObjectValue(ServicePrincipal);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedInstanceData DeserializeManagedInstanceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<SqlSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ManagedInstancePropertiesProvisioningState> provisioningState = default;
            Optional<ManagedServerCreateMode> managedInstanceCreateMode = default;
            Optional<string> fullyQualifiedDomainName = default;
            Optional<string> administratorLogin = default;
            Optional<string> administratorLoginPassword = default;
            Optional<ResourceIdentifier> subnetId = default;
            Optional<string> state = default;
            Optional<ManagedInstanceLicenseType> licenseType = default;
            Optional<int> vCores = default;
            Optional<int> storageSizeInGB = default;
            Optional<string> collation = default;
            Optional<string> dnsZone = default;
            Optional<ResourceIdentifier> dnsZonePartner = default;
            Optional<bool> publicDataEndpointEnabled = default;
            Optional<ResourceIdentifier> sourceManagedInstanceId = default;
            Optional<DateTimeOffset> restorePointInTime = default;
            Optional<ManagedInstanceProxyOverride> proxyOverride = default;
            Optional<string> timezoneId = default;
            Optional<ResourceIdentifier> instancePoolId = default;
            Optional<ResourceIdentifier> maintenanceConfigurationId = default;
            Optional<IReadOnlyList<ManagedInstancePecProperty>> privateEndpointConnections = default;
            Optional<string> minimalTlsVersion = default;
            Optional<SqlBackupStorageRedundancy> currentBackupStorageRedundancy = default;
            Optional<SqlBackupStorageRedundancy> requestedBackupStorageRedundancy = default;
            Optional<bool> zoneRedundant = default;
            Optional<ResourceIdentifier> primaryUserAssignedIdentityId = default;
            Optional<Uri> keyId = default;
            Optional<ManagedInstanceExternalAdministrator> administrators = default;
            Optional<SqlServicePrincipal> servicePrincipal = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ManagedInstancePropertiesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedInstanceCreateMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedInstanceCreateMode = new ManagedServerCreateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fullyQualifiedDomainName"u8))
                        {
                            fullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administratorLogin"u8))
                        {
                            administratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administratorLoginPassword"u8))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseType = new ManagedInstanceLicenseType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("storageSizeInGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageSizeInGB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("collation"u8))
                        {
                            collation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsZone"u8))
                        {
                            dnsZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsZonePartner"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsZonePartner = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicDataEndpointEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicDataEndpointEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("sourceManagedInstanceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceManagedInstanceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("restorePointInTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorePointInTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("proxyOverride"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            proxyOverride = new ManagedInstanceProxyOverride(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timezoneId"u8))
                        {
                            timezoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instancePoolId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instancePoolId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maintenanceConfigurationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceConfigurationId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedInstancePecProperty> array = new List<ManagedInstancePecProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedInstancePecProperty.DeserializeManagedInstancePecProperty(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("minimalTlsVersion"u8))
                        {
                            minimalTlsVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentBackupStorageRedundancy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentBackupStorageRedundancy = new SqlBackupStorageRedundancy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestedBackupStorageRedundancy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedBackupStorageRedundancy = new SqlBackupStorageRedundancy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("primaryUserAssignedIdentityId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primaryUserAssignedIdentityId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("keyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyId = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrators"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrators = ManagedInstanceExternalAdministrator.DeserializeManagedInstanceExternalAdministrator(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipal = SqlServicePrincipal.DeserializeSqlServicePrincipal(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedInstanceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, sku.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(managedInstanceCreateMode), fullyQualifiedDomainName.Value, administratorLogin.Value, administratorLoginPassword.Value, subnetId.Value, state.Value, Optional.ToNullable(licenseType), Optional.ToNullable(vCores), Optional.ToNullable(storageSizeInGB), collation.Value, dnsZone.Value, dnsZonePartner.Value, Optional.ToNullable(publicDataEndpointEnabled), sourceManagedInstanceId.Value, Optional.ToNullable(restorePointInTime), Optional.ToNullable(proxyOverride), timezoneId.Value, instancePoolId.Value, maintenanceConfigurationId.Value, Optional.ToList(privateEndpointConnections), minimalTlsVersion.Value, Optional.ToNullable(currentBackupStorageRedundancy), Optional.ToNullable(requestedBackupStorageRedundancy), Optional.ToNullable(zoneRedundant), primaryUserAssignedIdentityId.Value, keyId.Value, administrators.Value, servicePrincipal.Value);
        }
    }
}