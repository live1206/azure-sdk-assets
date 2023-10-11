// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmHealthcareApisModelFactory
    {
        /// <summary> Initializes a new instance of HealthcareApisServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The common properties of a service. </param>
        /// <param name="kind"> The kind of the service. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. Current supported identity types: SystemAssigned, None. </param>
        /// <returns> A new <see cref="HealthcareApis.HealthcareApisServiceData"/> instance for mocking. </returns>
        public static HealthcareApisServiceData HealthcareApisServiceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, HealthcareApisServiceProperties properties = null, HealthcareApisKind kind = default, ETag? etag = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();

            return new HealthcareApisServiceData(id, name, resourceType, systemData, tags, location, properties, kind, etag, identity);
        }

        /// <summary> Initializes a new instance of HealthcareApisServiceProperties. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="accessPolicies"> The access policies of the service instance. </param>
        /// <param name="cosmosDbConfiguration"> The settings for the Cosmos DB database backing the service. </param>
        /// <param name="authenticationConfiguration"> The authentication configuration for the service instance. </param>
        /// <param name="corsConfiguration"> The settings for the CORS configuration of the service instance. </param>
        /// <param name="exportStorageAccountName"> The settings for the export operation of the service instance. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <param name="acrConfiguration"> The azure container registry settings used for convert data operation of the service instance. </param>
        /// <param name="importConfiguration"> The settings for the import operation of the service instance. </param>
        /// <returns> A new <see cref="Models.HealthcareApisServiceProperties"/> instance for mocking. </returns>
        public static HealthcareApisServiceProperties HealthcareApisServiceProperties(HealthcareApisProvisioningState? provisioningState = null, IEnumerable<HealthcareApisServiceAccessPolicyEntry> accessPolicies = null, HealthcareApisServiceCosmosDbConfiguration cosmosDbConfiguration = null, HealthcareApisServiceAuthenticationConfiguration authenticationConfiguration = null, HealthcareApisServiceCorsConfiguration corsConfiguration = null, string exportStorageAccountName = null, IEnumerable<HealthcareApisPrivateEndpointConnectionData> privateEndpointConnections = null, HealthcareApisPublicNetworkAccess? publicNetworkAccess = null, HealthcareApisServiceAcrConfiguration acrConfiguration = null, HealthcareApisServiceImportConfiguration importConfiguration = null)
        {
            accessPolicies ??= new List<HealthcareApisServiceAccessPolicyEntry>();
            privateEndpointConnections ??= new List<HealthcareApisPrivateEndpointConnectionData>();

            return new HealthcareApisServiceProperties(provisioningState, accessPolicies?.ToList(), cosmosDbConfiguration, authenticationConfiguration, corsConfiguration, exportStorageAccountName != null ? new ServiceExportConfigurationInfo(exportStorageAccountName) : null, privateEndpointConnections?.ToList(), publicNetworkAccess, acrConfiguration, importConfiguration);
        }

        /// <summary> Initializes a new instance of HealthcareApisPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpointId"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <returns> A new <see cref="HealthcareApis.HealthcareApisPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static HealthcareApisPrivateEndpointConnectionData HealthcareApisPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier privateEndpointId = null, HealthcareApisPrivateLinkServiceConnectionState connectionState = null, HealthcareApisPrivateEndpointConnectionProvisioningState? provisioningState = null)
        {
            return new HealthcareApisPrivateEndpointConnectionData(id, name, resourceType, systemData, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, connectionState, provisioningState);
        }

        /// <summary> Initializes a new instance of HealthcareApisNameAvailabilityResult. </summary>
        /// <param name="isNameAvailable"> The value which indicates whether the provided name is available. </param>
        /// <param name="reason"> The reason for unavailability. </param>
        /// <param name="message"> The detailed reason message. </param>
        /// <returns> A new <see cref="Models.HealthcareApisNameAvailabilityResult"/> instance for mocking. </returns>
        public static HealthcareApisNameAvailabilityResult HealthcareApisNameAvailabilityResult(bool? isNameAvailable = null, HealthcareApisNameUnavailableReason? reason = null, string message = null)
        {
            return new HealthcareApisNameAvailabilityResult(isNameAvailable, reason, message);
        }

        /// <summary> Initializes a new instance of HealthcareApisPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone name. </param>
        /// <returns> A new <see cref="HealthcareApis.HealthcareApisPrivateLinkResourceData"/> instance for mocking. </returns>
        public static HealthcareApisPrivateLinkResourceData HealthcareApisPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new HealthcareApisPrivateLinkResourceData(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList());
        }

        /// <summary> Initializes a new instance of HealthcareApisWorkspaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Workspaces resource specific properties. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        /// <returns> A new <see cref="HealthcareApis.HealthcareApisWorkspaceData"/> instance for mocking. </returns>
        public static HealthcareApisWorkspaceData HealthcareApisWorkspaceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, HealthcareApisWorkspaceProperties properties = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();

            return new HealthcareApisWorkspaceData(id, name, resourceType, systemData, tags, location, properties, etag);
        }

        /// <summary> Initializes a new instance of HealthcareApisWorkspaceProperties. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <returns> A new <see cref="Models.HealthcareApisWorkspaceProperties"/> instance for mocking. </returns>
        public static HealthcareApisWorkspaceProperties HealthcareApisWorkspaceProperties(HealthcareApisProvisioningState? provisioningState = null, IEnumerable<HealthcareApisPrivateEndpointConnectionData> privateEndpointConnections = null, HealthcareApisPublicNetworkAccess? publicNetworkAccess = null)
        {
            privateEndpointConnections ??= new List<HealthcareApisPrivateEndpointConnectionData>();

            return new HealthcareApisWorkspaceProperties(provisioningState, privateEndpointConnections?.ToList(), publicNetworkAccess);
        }

        /// <summary> Initializes a new instance of DicomServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="authenticationConfiguration"> Dicom Service authentication configuration. </param>
        /// <param name="corsConfiguration"> Dicom Service Cors configuration. </param>
        /// <param name="serviceUri"> The url of the Dicom Services. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        /// <returns> A new <see cref="HealthcareApis.DicomServiceData"/> instance for mocking. </returns>
        public static DicomServiceData DicomServiceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, HealthcareApisProvisioningState? provisioningState = null, DicomServiceAuthenticationConfiguration authenticationConfiguration = null, DicomServiceCorsConfiguration corsConfiguration = null, Uri serviceUri = null, IEnumerable<HealthcareApisPrivateEndpointConnectionData> privateEndpointConnections = null, HealthcareApisPublicNetworkAccess? publicNetworkAccess = null, ManagedServiceIdentity identity = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<HealthcareApisPrivateEndpointConnectionData>();

            return new DicomServiceData(id, name, resourceType, systemData, tags, location, provisioningState, authenticationConfiguration, corsConfiguration, serviceUri, privateEndpointConnections?.ToList(), publicNetworkAccess, identity, etag);
        }

        /// <summary> Initializes a new instance of DicomServiceAuthenticationConfiguration. </summary>
        /// <param name="authority"> The authority url for the service. </param>
        /// <param name="audiences"> The audiences for the service. </param>
        /// <returns> A new <see cref="Models.DicomServiceAuthenticationConfiguration"/> instance for mocking. </returns>
        public static DicomServiceAuthenticationConfiguration DicomServiceAuthenticationConfiguration(string authority = null, IEnumerable<string> audiences = null)
        {
            audiences ??= new List<string>();

            return new DicomServiceAuthenticationConfiguration(authority, audiences?.ToList());
        }

        /// <summary> Initializes a new instance of HealthcareApisIotConnectorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="ingestionEndpointConfiguration"> Source configuration. </param>
        /// <param name="deviceMappingContent"> Device Mappings. </param>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        /// <returns> A new <see cref="HealthcareApis.HealthcareApisIotConnectorData"/> instance for mocking. </returns>
        public static HealthcareApisIotConnectorData HealthcareApisIotConnectorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, HealthcareApisProvisioningState? provisioningState = null, HealthcareApisIotConnectorEventHubIngestionConfiguration ingestionEndpointConfiguration = null, BinaryData deviceMappingContent = null, ManagedServiceIdentity identity = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();

            return new HealthcareApisIotConnectorData(id, name, resourceType, systemData, tags, location, provisioningState, ingestionEndpointConfiguration, deviceMappingContent != null ? new HealthcareApisIotMappingProperties(deviceMappingContent) : null, identity, etag);
        }

        /// <summary> Initializes a new instance of HealthcareApisIotFhirDestinationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="resourceIdentityResolutionType"> Determines how resource identity is resolved on the destination. </param>
        /// <param name="fhirServiceResourceId"> Fully qualified resource id of the FHIR service to connect to. </param>
        /// <param name="fhirMappingContent"> FHIR Mappings. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        /// <returns> A new <see cref="HealthcareApis.HealthcareApisIotFhirDestinationData"/> instance for mocking. </returns>
        public static HealthcareApisIotFhirDestinationData HealthcareApisIotFhirDestinationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, HealthcareApisProvisioningState? provisioningState = null, HealthcareApisIotIdentityResolutionType resourceIdentityResolutionType = default, ResourceIdentifier fhirServiceResourceId = null, BinaryData fhirMappingContent = null, AzureLocation? location = null, ETag? etag = null)
        {
            return new HealthcareApisIotFhirDestinationData(id, name, resourceType, systemData, provisioningState, resourceIdentityResolutionType, fhirServiceResourceId, fhirMappingContent != null ? new HealthcareApisIotMappingProperties(fhirMappingContent) : null, location, etag);
        }

        /// <summary> Initializes a new instance of FhirServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The kind of the service. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="accessPolicies"> Fhir Service access policies. </param>
        /// <param name="acrConfiguration"> Fhir Service Azure container registry configuration. </param>
        /// <param name="authenticationConfiguration"> Fhir Service authentication configuration. </param>
        /// <param name="corsConfiguration"> Fhir Service Cors configuration. </param>
        /// <param name="exportStorageAccountName"> Fhir Service export configuration. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <param name="eventState"> Fhir Service event support status. </param>
        /// <param name="resourceVersionPolicyConfiguration"> Determines tracking of history for resources. </param>
        /// <param name="importConfiguration"> Fhir Service import configuration. </param>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        /// <returns> A new <see cref="HealthcareApis.FhirServiceData"/> instance for mocking. </returns>
        public static FhirServiceData FhirServiceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, FhirServiceKind? kind = null, HealthcareApisProvisioningState? provisioningState = null, IEnumerable<FhirServiceAccessPolicyEntry> accessPolicies = null, FhirServiceAcrConfiguration acrConfiguration = null, FhirServiceAuthenticationConfiguration authenticationConfiguration = null, FhirServiceCorsConfiguration corsConfiguration = null, string exportStorageAccountName = null, IEnumerable<HealthcareApisPrivateEndpointConnectionData> privateEndpointConnections = null, HealthcareApisPublicNetworkAccess? publicNetworkAccess = null, FhirServiceEventState? eventState = null, FhirServiceResourceVersionPolicyConfiguration resourceVersionPolicyConfiguration = null, FhirServiceImportConfiguration importConfiguration = null, ManagedServiceIdentity identity = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();
            accessPolicies ??= new List<FhirServiceAccessPolicyEntry>();
            privateEndpointConnections ??= new List<HealthcareApisPrivateEndpointConnectionData>();

            return new FhirServiceData(id, name, resourceType, systemData, tags, location, kind, provisioningState, accessPolicies?.ToList(), acrConfiguration, authenticationConfiguration, corsConfiguration, exportStorageAccountName != null ? new FhirServiceExportConfiguration(exportStorageAccountName) : null, privateEndpointConnections?.ToList(), publicNetworkAccess, eventState, resourceVersionPolicyConfiguration, importConfiguration, identity, etag);
        }
    }
}