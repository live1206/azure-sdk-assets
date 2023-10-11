// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmDeviceProvisioningServicesModelFactory
    {
        /// <summary> Initializes a new instance of DeviceProvisioningServicesCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> properties of a certificate. </param>
        /// <param name="etag"> The entity tag. </param>
        /// <returns> A new <see cref="DeviceProvisioningServices.DeviceProvisioningServicesCertificateData"/> instance for mocking. </returns>
        public static DeviceProvisioningServicesCertificateData DeviceProvisioningServicesCertificateData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DeviceProvisioningServicesCertificateProperties properties = null, ETag? etag = null)
        {
            return new DeviceProvisioningServicesCertificateData(id, name, resourceType, systemData, properties, etag);
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServicesCertificateProperties. </summary>
        /// <param name="subject"> The certificate's subject name. </param>
        /// <param name="expireOn"> The certificate's expiration date and time. </param>
        /// <param name="thumbprint"> The certificate's thumbprint. </param>
        /// <param name="isVerified"> Determines whether certificate has been verified. </param>
        /// <param name="certificate"> base-64 representation of X509 certificate .cer file or just .pem file content. </param>
        /// <param name="createdOn"> The certificate's creation date and time. </param>
        /// <param name="updatedOn"> The certificate's last update date and time. </param>
        /// <returns> A new <see cref="Models.DeviceProvisioningServicesCertificateProperties"/> instance for mocking. </returns>
        public static DeviceProvisioningServicesCertificateProperties DeviceProvisioningServicesCertificateProperties(string subject = null, DateTimeOffset? expireOn = null, BinaryData thumbprint = null, bool? isVerified = null, BinaryData certificate = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null)
        {
            return new DeviceProvisioningServicesCertificateProperties(subject, expireOn, thumbprint, isVerified, certificate, createdOn, updatedOn);
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. </param>
        /// <param name="properties"> Service specific properties for a provisioning service. </param>
        /// <param name="sku"> Sku info for a provisioning Service. </param>
        /// <returns> A new <see cref="DeviceProvisioningServices.DeviceProvisioningServiceData"/> instance for mocking. </returns>
        public static DeviceProvisioningServiceData DeviceProvisioningServiceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ETag? etag = null, DeviceProvisioningServiceProperties properties = null, DeviceProvisioningServicesSkuInfo sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DeviceProvisioningServiceData(id, name, resourceType, systemData, tags, location, etag, properties, sku);
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServiceProperties. </summary>
        /// <param name="state"> Current state of the provisioning service. </param>
        /// <param name="publicNetworkAccess"> Whether requests from Public Network are allowed. </param>
        /// <param name="ipFilterRules"> The IP filter rules. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections created on this IotHub. </param>
        /// <param name="provisioningState"> The ARM provisioning state of the provisioning service. </param>
        /// <param name="iotHubs"> List of IoT hubs associated with this provisioning service. </param>
        /// <param name="allocationPolicy"> Allocation policy to be used by this provisioning service. </param>
        /// <param name="serviceOperationsHostName"> Service endpoint for provisioning service. </param>
        /// <param name="deviceProvisioningHostName"> Device endpoint for this provisioning service. </param>
        /// <param name="idScope"> Unique identifier of this provisioning service. </param>
        /// <param name="authorizationPolicies"> List of authorization keys for a provisioning service. </param>
        /// <param name="isDataResidencyEnabled">
        /// Optional.
        /// Indicates if the DPS instance has Data Residency enabled, removing the cross geo-pair disaster recovery.
        /// </param>
        /// <returns> A new <see cref="Models.DeviceProvisioningServiceProperties"/> instance for mocking. </returns>
        public static DeviceProvisioningServiceProperties DeviceProvisioningServiceProperties(DeviceProvisioningServicesState? state = null, DeviceProvisioningServicesPublicNetworkAccess? publicNetworkAccess = null, IEnumerable<DeviceProvisioningServicesIPFilterRule> ipFilterRules = null, IEnumerable<DeviceProvisioningServicesPrivateEndpointConnectionData> privateEndpointConnections = null, string provisioningState = null, IEnumerable<IotHubDefinitionDescription> iotHubs = null, DeviceProvisioningServicesAllocationPolicy? allocationPolicy = null, string serviceOperationsHostName = null, string deviceProvisioningHostName = null, string idScope = null, IEnumerable<DeviceProvisioningServicesSharedAccessKey> authorizationPolicies = null, bool? isDataResidencyEnabled = null)
        {
            ipFilterRules ??= new List<DeviceProvisioningServicesIPFilterRule>();
            privateEndpointConnections ??= new List<DeviceProvisioningServicesPrivateEndpointConnectionData>();
            iotHubs ??= new List<IotHubDefinitionDescription>();
            authorizationPolicies ??= new List<DeviceProvisioningServicesSharedAccessKey>();

            return new DeviceProvisioningServiceProperties(state, publicNetworkAccess, ipFilterRules?.ToList(), privateEndpointConnections?.ToList(), provisioningState, iotHubs?.ToList(), allocationPolicy, serviceOperationsHostName, deviceProvisioningHostName, idScope, authorizationPolicies?.ToList(), isDataResidencyEnabled);
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServicesPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of a private endpoint connection. </param>
        /// <returns> A new <see cref="DeviceProvisioningServices.DeviceProvisioningServicesPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static DeviceProvisioningServicesPrivateEndpointConnectionData DeviceProvisioningServicesPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DeviceProvisioningServicesPrivateEndpointConnectionProperties properties = null)
        {
            return new DeviceProvisioningServicesPrivateEndpointConnectionData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of IotHubDefinitionDescription. </summary>
        /// <param name="applyAllocationPolicy"> flag for applying allocationPolicy or not for a given iot hub. </param>
        /// <param name="allocationWeight"> weight to apply for a given iot h. </param>
        /// <param name="name"> Host name of the IoT hub. </param>
        /// <param name="connectionString"> Connection string of the IoT hub. </param>
        /// <param name="location"> ARM region of the IoT hub. </param>
        /// <returns> A new <see cref="Models.IotHubDefinitionDescription"/> instance for mocking. </returns>
        public static IotHubDefinitionDescription IotHubDefinitionDescription(bool? applyAllocationPolicy = null, int? allocationWeight = null, string name = null, string connectionString = null, AzureLocation location = default)
        {
            return new IotHubDefinitionDescription(applyAllocationPolicy, allocationWeight, name, connectionString, location);
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServicesSkuInfo. </summary>
        /// <param name="name"> Sku name. </param>
        /// <param name="tier"> Pricing tier name of the provisioning service. </param>
        /// <param name="capacity"> The number of units to provision. </param>
        /// <returns> A new <see cref="Models.DeviceProvisioningServicesSkuInfo"/> instance for mocking. </returns>
        public static DeviceProvisioningServicesSkuInfo DeviceProvisioningServicesSkuInfo(DeviceProvisioningServicesSku? name = null, string tier = null, long? capacity = null)
        {
            return new DeviceProvisioningServicesSkuInfo(name, tier, capacity);
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServicesSkuDefinition. </summary>
        /// <param name="name"> Sku name. </param>
        /// <returns> A new <see cref="Models.DeviceProvisioningServicesSkuDefinition"/> instance for mocking. </returns>
        public static DeviceProvisioningServicesSkuDefinition DeviceProvisioningServicesSkuDefinition(DeviceProvisioningServicesSku? name = null)
        {
            return new DeviceProvisioningServicesSkuDefinition(name);
        }

        /// <summary> Initializes a new instance of CertificateVerificationCodeResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Request etag. </param>
        /// <param name="properties"></param>
        /// <returns> A new <see cref="Models.CertificateVerificationCodeResult"/> instance for mocking. </returns>
        public static CertificateVerificationCodeResult CertificateVerificationCodeResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ETag? etag = null, CertificateVerificationCodeProperties properties = null)
        {
            return new CertificateVerificationCodeResult(id, name, resourceType, systemData, etag, properties);
        }

        /// <summary> Initializes a new instance of CertificateVerificationCodeProperties. </summary>
        /// <param name="verificationCode"> Verification code. </param>
        /// <param name="subject"> Certificate subject. </param>
        /// <param name="expireOn"> Code expiry. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="isVerified"> Indicate if the certificate is verified by owner of private key. </param>
        /// <param name="certificate"> base-64 representation of X509 certificate .cer file or just .pem file content. </param>
        /// <param name="createdOn"> Certificate created time. </param>
        /// <param name="updatedOn"> Certificate updated time. </param>
        /// <returns> A new <see cref="Models.CertificateVerificationCodeProperties"/> instance for mocking. </returns>
        public static CertificateVerificationCodeProperties CertificateVerificationCodeProperties(string verificationCode = null, string subject = null, DateTimeOffset? expireOn = null, BinaryData thumbprint = null, bool? isVerified = null, BinaryData certificate = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null)
        {
            return new CertificateVerificationCodeProperties(verificationCode, subject, expireOn, thumbprint, isVerified, certificate, createdOn, updatedOn);
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServicesNameAvailabilityResult. </summary>
        /// <param name="isNameAvailable"> specifies if a name is available or not. </param>
        /// <param name="reason"> specifies the reason a name is unavailable. </param>
        /// <param name="message"> message containing a detailed reason name is unavailable. </param>
        /// <returns> A new <see cref="Models.DeviceProvisioningServicesNameAvailabilityResult"/> instance for mocking. </returns>
        public static DeviceProvisioningServicesNameAvailabilityResult DeviceProvisioningServicesNameAvailabilityResult(bool? isNameAvailable = null, DeviceProvisioningServicesNameUnavailableReason? reason = null, string message = null)
        {
            return new DeviceProvisioningServicesNameAvailabilityResult(isNameAvailable, reason, message);
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServicesPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties for a group information object. </param>
        /// <returns> A new <see cref="DeviceProvisioningServices.DeviceProvisioningServicesPrivateLinkResourceData"/> instance for mocking. </returns>
        public static DeviceProvisioningServicesPrivateLinkResourceData DeviceProvisioningServicesPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DeviceProvisioningServicesPrivateLinkResourceProperties properties = null)
        {
            return new DeviceProvisioningServicesPrivateLinkResourceData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServicesPrivateLinkResourceProperties. </summary>
        /// <param name="groupId"> The group id. </param>
        /// <param name="requiredMembers"> The required members for a specific group id. </param>
        /// <param name="requiredZoneNames"> The required DNS zones for a specific group id. </param>
        /// <returns> A new <see cref="Models.DeviceProvisioningServicesPrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static DeviceProvisioningServicesPrivateLinkResourceProperties DeviceProvisioningServicesPrivateLinkResourceProperties(string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new DeviceProvisioningServicesPrivateLinkResourceProperties(groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList());
        }
    }
}
