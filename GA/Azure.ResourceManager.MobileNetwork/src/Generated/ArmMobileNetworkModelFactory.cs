// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMobileNetworkModelFactory
    {
        /// <summary> Initializes a new instance of MobileAttachedDataNetworkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the attached data network resource. </param>
        /// <param name="userPlaneDataInterface"> The user plane interface on the data network. For 5G networks, this is the N6 interface. For 4G networks, this is the SGi interface. </param>
        /// <param name="dnsAddresses"> The DNS servers to signal to UEs to use for this attached data network. This configuration is mandatory - if you don't want DNS servers, you must provide an empty array. </param>
        /// <param name="naptConfiguration">
        /// The network address and port translation (NAPT) configuration.
        /// If this is not specified, the attached data network will use a default NAPT configuration with NAPT enabled.
        /// </param>
        /// <param name="userEquipmentAddressPoolPrefix">
        /// The user equipment (UE) address pool prefixes for the attached data network from which the packet core instance will dynamically assign IP addresses to UEs.
        /// The packet core instance assigns an IP address to a UE when the UE sets up a PDU session.
        ///  You must define at least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix. If you define both, they must be of the same size.
        /// </param>
        /// <param name="userEquipmentStaticAddressPoolPrefix">
        /// The user equipment (UE) address pool prefixes for the attached data network from which the packet core instance will assign static IP addresses to UEs.
        /// The packet core instance assigns an IP address to a UE when the UE sets up a PDU session. The static IP address for a specific UE is set in StaticIPConfiguration on the corresponding SIM resource.
        /// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined, they must be of the same size.
        /// </param>
        /// <returns> A new <see cref="MobileNetwork.MobileAttachedDataNetworkData"/> instance for mocking. </returns>
        public static MobileAttachedDataNetworkData MobileAttachedDataNetworkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MobileNetworkProvisioningState? provisioningState = null, MobileNetworkInterfaceProperties userPlaneDataInterface = null, IEnumerable<string> dnsAddresses = null, NaptConfiguration naptConfiguration = null, IEnumerable<string> userEquipmentAddressPoolPrefix = null, IEnumerable<string> userEquipmentStaticAddressPoolPrefix = null)
        {
            tags ??= new Dictionary<string, string>();
            dnsAddresses ??= new List<string>();
            userEquipmentAddressPoolPrefix ??= new List<string>();
            userEquipmentStaticAddressPoolPrefix ??= new List<string>();

            return new MobileAttachedDataNetworkData(id, name, resourceType, systemData, tags, location, provisioningState, userPlaneDataInterface, dnsAddresses?.ToList(), naptConfiguration, userEquipmentAddressPoolPrefix?.ToList(), userEquipmentStaticAddressPoolPrefix?.ToList());
        }

        /// <summary> Initializes a new instance of MobileDataNetworkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the data network resource. </param>
        /// <param name="description"> An optional description for this data network. </param>
        /// <returns> A new <see cref="MobileNetwork.MobileDataNetworkData"/> instance for mocking. </returns>
        public static MobileDataNetworkData MobileDataNetworkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MobileNetworkProvisioningState? provisioningState = null, string description = null)
        {
            tags ??= new Dictionary<string, string>();

            return new MobileDataNetworkData(id, name, resourceType, systemData, tags, location, provisioningState, description);
        }

        /// <summary> Initializes a new instance of MobileNetworkDiagnosticsPackageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the diagnostics package resource. </param>
        /// <param name="status"> The status of the diagnostics package collection. </param>
        /// <param name="reason"> The reason for the current state of the diagnostics package collection. </param>
        /// <returns> A new <see cref="MobileNetwork.MobileNetworkDiagnosticsPackageData"/> instance for mocking. </returns>
        public static MobileNetworkDiagnosticsPackageData MobileNetworkDiagnosticsPackageData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MobileNetworkProvisioningState? provisioningState = null, MobileNetworkDiagnosticsPackageStatus? status = null, string reason = null)
        {
            return new MobileNetworkDiagnosticsPackageData(id, name, resourceType, systemData, provisioningState, status, reason);
        }

        /// <summary> Initializes a new instance of MobileNetworkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the mobile network resource. </param>
        /// <param name="publicLandMobileNetworkIdentifier"> The unique public land mobile network identifier for the network. This is made up of the mobile country code and mobile network code, as defined in https://www.itu.int/rec/T-REC-E.212. The values 001-01 and 001-001 can be used for testing and the values 999-99 and 999-999 can be used on internal private networks. </param>
        /// <param name="serviceKey"> The mobile network resource identifier. </param>
        /// <returns> A new <see cref="MobileNetwork.MobileNetworkData"/> instance for mocking. </returns>
        public static MobileNetworkData MobileNetworkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MobileNetworkProvisioningState? provisioningState = null, MobileNetworkPlmnId publicLandMobileNetworkIdentifier = null, string serviceKey = null)
        {
            tags ??= new Dictionary<string, string>();

            return new MobileNetworkData(id, name, resourceType, systemData, tags, location, provisioningState, publicLandMobileNetworkIdentifier, serviceKey);
        }

        /// <summary> Initializes a new instance of MobileNetworkPacketCaptureData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the packet capture session resource. </param>
        /// <param name="status"> The status of the packet capture session. </param>
        /// <param name="reason"> The reason the current packet capture session state. </param>
        /// <param name="captureStartOn"> The start time of the packet capture session. </param>
        /// <param name="networkInterfaces"> List of network interfaces to capture on. </param>
        /// <param name="bytesToCapturePerPacket"> Number of bytes captured per packet, the remaining bytes are truncated. The default "0" means the entire packet is captured. </param>
        /// <param name="totalBytesPerSession"> Maximum size of the capture output. </param>
        /// <param name="timeLimitInSeconds"> Maximum duration of the capture session in seconds. </param>
        /// <returns> A new <see cref="MobileNetwork.MobileNetworkPacketCaptureData"/> instance for mocking. </returns>
        public static MobileNetworkPacketCaptureData MobileNetworkPacketCaptureData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MobileNetworkProvisioningState? provisioningState = null, MobileNetworkPacketCaptureStatus? status = null, string reason = null, DateTimeOffset? captureStartOn = null, IEnumerable<string> networkInterfaces = null, long? bytesToCapturePerPacket = null, long? totalBytesPerSession = null, int? timeLimitInSeconds = null)
        {
            networkInterfaces ??= new List<string>();

            return new MobileNetworkPacketCaptureData(id, name, resourceType, systemData, provisioningState, status, reason, captureStartOn, networkInterfaces?.ToList(), bytesToCapturePerPacket, totalBytesPerSession, timeLimitInSeconds);
        }

        /// <summary> Initializes a new instance of AsyncOperationStatus. </summary>
        /// <param name="id"> Fully qualified ID for the async operation. </param>
        /// <param name="name"> Name of the async operation. </param>
        /// <param name="status"> The operation status. </param>
        /// <param name="resourceId"> Fully qualified ID for the resource that this async operation status relates to. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="percentComplete"> Percentage of the operation that is complete. </param>
        /// <param name="properties"> Properties returned by the resource provider on a successful operation. </param>
        /// <param name="error"> If present, details of the operation error. </param>
        /// <returns> A new <see cref="Models.AsyncOperationStatus"/> instance for mocking. </returns>
        public static AsyncOperationStatus AsyncOperationStatus(string id = null, string name = null, string status = null, string resourceId = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, double? percentComplete = null, BinaryData properties = null, ResponseError error = null)
        {
            return new AsyncOperationStatus(id, name, status, resourceId, startOn, endOn, percentComplete, properties, error);
        }

        /// <summary> Initializes a new instance of PacketCoreControlPlaneData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="userAssignedIdentity"> The identity used to retrieve the ingress certificate from Azure key vault. </param>
        /// <param name="provisioningState"> The provisioning state of the packet core control plane resource. </param>
        /// <param name="installation"> The installation state of the packet core control plane resource. </param>
        /// <param name="sites"> Site(s) under which this packet core control plane should be deployed. The sites must be in the same location as the packet core control plane. </param>
        /// <param name="platform"> The platform where the packet core is deployed. </param>
        /// <param name="coreNetworkTechnology"> The core network technology generation (5G core or EPC / 4G core). </param>
        /// <param name="version"> The desired version of the packet core software. </param>
        /// <param name="installedVersion"> The currently installed version of the packet core software. </param>
        /// <param name="rollbackVersion"> The previous version of the packet core software that was deployed. Used when performing the rollback action. </param>
        /// <param name="controlPlaneAccessInterface"> The control plane interface on the access network. For 5G networks, this is the N2 interface. For 4G networks, this is the S1-MME interface. </param>
        /// <param name="sku"> The SKU defining the throughput and SIM allowances for this packet core control plane deployment. </param>
        /// <param name="ueMtu"> The MTU (in bytes) signaled to the UE. The same MTU is set on the user plane data links for all data networks. The MTU set on the user plane access link is calculated to be 60 bytes greater than this value to allow for GTP encapsulation. </param>
        /// <param name="localDiagnosticsAccess"> The kubernetes ingress configuration to control access to packet core diagnostics over local APIs. </param>
        /// <param name="diagnosticsUploadStorageAccountContainerUri"> Configuration for uploading packet core diagnostics. </param>
        /// <param name="interopSettings"> Settings to allow interoperability with third party components e.g. RANs and UEs. </param>
        /// <returns> A new <see cref="MobileNetwork.PacketCoreControlPlaneData"/> instance for mocking. </returns>
        public static PacketCoreControlPlaneData PacketCoreControlPlaneData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MobileNetworkManagedServiceIdentity userAssignedIdentity = null, MobileNetworkProvisioningState? provisioningState = null, MobileNetworkInstallation installation = null, IEnumerable<WritableSubResource> sites = null, MobileNetworkPlatformConfiguration platform = null, MobileNetworkCoreNetworkType? coreNetworkTechnology = null, string version = null, string installedVersion = null, string rollbackVersion = null, MobileNetworkInterfaceProperties controlPlaneAccessInterface = null, MobileNetworkBillingSku sku = default, int? ueMtu = null, MobileNetworkLocalDiagnosticsAccessConfiguration localDiagnosticsAccess = null, Uri diagnosticsUploadStorageAccountContainerUri = null, BinaryData interopSettings = null)
        {
            tags ??= new Dictionary<string, string>();
            sites ??= new List<WritableSubResource>();

            return new PacketCoreControlPlaneData(id, name, resourceType, systemData, tags, location, userAssignedIdentity, provisioningState, installation, sites?.ToList(), platform, coreNetworkTechnology, version, installedVersion, rollbackVersion, controlPlaneAccessInterface, sku, ueMtu, localDiagnosticsAccess, diagnosticsUploadStorageAccountContainerUri != null ? new DiagnosticsUploadConfiguration(diagnosticsUploadStorageAccountContainerUri) : null, interopSettings);
        }

        /// <summary> Initializes a new instance of MobileNetworkInstallation. </summary>
        /// <param name="desiredState"> The desired installation state. </param>
        /// <param name="state"> Installation state. </param>
        /// <param name="reinstallRequired"> Whether a reinstall of the packet core is required to pick up the latest configuration changes. </param>
        /// <param name="reasons"> Reason(s) for the current installation state of the packet core. </param>
        /// <param name="operationId"> A reference to an in-progress installation operation. </param>
        /// <returns> A new <see cref="Models.MobileNetworkInstallation"/> instance for mocking. </returns>
        public static MobileNetworkInstallation MobileNetworkInstallation(DesiredInstallationState? desiredState = null, MobileNetworkInstallationState? state = null, MobileNetworkReinstallRequired? reinstallRequired = null, IEnumerable<MobileNetworkInstallationReason> reasons = null, ResourceIdentifier operationId = null)
        {
            reasons ??= new List<MobileNetworkInstallationReason>();

            return new MobileNetworkInstallation(desiredState, state, reinstallRequired, reasons?.ToList(), operationId != null ? ResourceManagerModelFactory.SubResource(operationId) : null);
        }

        /// <summary> Initializes a new instance of MobileNetworkPlatformConfiguration. </summary>
        /// <param name="platformType"> The platform type where packet core is deployed. </param>
        /// <param name="azureStackEdgeDeviceId"> The Azure Stack Edge device where the packet core is deployed. If the device is part of a fault tolerant pair, either device in the pair can be specified. </param>
        /// <param name="azureStackEdgeDevices"> The Azure Stack Edge devices where the packet core is deployed. If the packet core is deployed across multiple devices, all devices will appear in this list. </param>
        /// <param name="azureStackHciClusterId"> The Azure Stack HCI cluster where the packet core is deployed. </param>
        /// <param name="connectedClusterId"> Azure Arc connected cluster where the packet core is deployed. </param>
        /// <param name="customLocationId"> Azure Arc custom location where the packet core is deployed. </param>
        /// <returns> A new <see cref="Models.MobileNetworkPlatformConfiguration"/> instance for mocking. </returns>
        public static MobileNetworkPlatformConfiguration MobileNetworkPlatformConfiguration(MobileNetworkPlatformType platformType = default, ResourceIdentifier azureStackEdgeDeviceId = null, IEnumerable<WritableSubResource> azureStackEdgeDevices = null, ResourceIdentifier azureStackHciClusterId = null, ResourceIdentifier connectedClusterId = null, ResourceIdentifier customLocationId = null)
        {
            azureStackEdgeDevices ??= new List<WritableSubResource>();

            return new MobileNetworkPlatformConfiguration(platformType, azureStackEdgeDeviceId != null ? ResourceManagerModelFactory.WritableSubResource(azureStackEdgeDeviceId) : null, azureStackEdgeDevices?.ToList(), azureStackHciClusterId != null ? ResourceManagerModelFactory.WritableSubResource(azureStackHciClusterId) : null, connectedClusterId != null ? ResourceManagerModelFactory.WritableSubResource(connectedClusterId) : null, customLocationId != null ? ResourceManagerModelFactory.WritableSubResource(customLocationId) : null);
        }

        /// <summary> Initializes a new instance of MobileNetworkHttpsServerCertificate. </summary>
        /// <param name="certificateUri"> The certificate URL, unversioned. For example: https://contosovault.vault.azure.net/certificates/ingress. </param>
        /// <param name="provisioning"> The provisioning state of the certificate. </param>
        /// <returns> A new <see cref="Models.MobileNetworkHttpsServerCertificate"/> instance for mocking. </returns>
        public static MobileNetworkHttpsServerCertificate MobileNetworkHttpsServerCertificate(Uri certificateUri = null, MobileNetworkCertificateProvisioning provisioning = null)
        {
            return new MobileNetworkHttpsServerCertificate(certificateUri, provisioning);
        }

        /// <summary> Initializes a new instance of MobileNetworkCertificateProvisioning. </summary>
        /// <param name="state"> The certificate's provisioning state. </param>
        /// <param name="reason"> Reason for certificate provisioning failure. </param>
        /// <returns> A new <see cref="Models.MobileNetworkCertificateProvisioning"/> instance for mocking. </returns>
        public static MobileNetworkCertificateProvisioning MobileNetworkCertificateProvisioning(CertificateProvisioningState? state = null, string reason = null)
        {
            return new MobileNetworkCertificateProvisioning(state, reason);
        }

        /// <summary> Initializes a new instance of PacketCoreControlPlaneVersionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the packet core control plane version resource. </param>
        /// <param name="platforms"> Platform specific packet core control plane version properties. </param>
        /// <returns> A new <see cref="MobileNetwork.PacketCoreControlPlaneVersionData"/> instance for mocking. </returns>
        public static PacketCoreControlPlaneVersionData PacketCoreControlPlaneVersionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MobileNetworkProvisioningState? provisioningState = null, IEnumerable<MobileNetworkPlatform> platforms = null)
        {
            platforms ??= new List<MobileNetworkPlatform>();

            return new PacketCoreControlPlaneVersionData(id, name, resourceType, systemData, provisioningState, platforms?.ToList());
        }

        /// <summary> Initializes a new instance of PacketCoreDataPlaneData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the packet core data plane resource. </param>
        /// <param name="userPlaneAccessInterface"> The user plane interface on the access network. For 5G networks, this is the N3 interface. For 4G networks, this is the S1-U interface. </param>
        /// <returns> A new <see cref="MobileNetwork.PacketCoreDataPlaneData"/> instance for mocking. </returns>
        public static PacketCoreDataPlaneData PacketCoreDataPlaneData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MobileNetworkProvisioningState? provisioningState = null, MobileNetworkInterfaceProperties userPlaneAccessInterface = null)
        {
            tags ??= new Dictionary<string, string>();

            return new PacketCoreDataPlaneData(id, name, resourceType, systemData, tags, location, provisioningState, userPlaneAccessInterface);
        }

        /// <summary> Initializes a new instance of MobileNetworkServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the service resource. </param>
        /// <param name="servicePrecedence"> A precedence value that is used to decide between services when identifying the QoS values to use for a particular SIM. A lower value means a higher priority. This value should be unique among all services configured in the mobile network. </param>
        /// <param name="serviceQosPolicy"> The QoS policy to use for packets matching this service. This can be overridden for particular flows using the ruleQosPolicy field in a PccRuleConfiguration. If this field is null then the UE's SIM policy will define the QoS settings. </param>
        /// <param name="pccRules"> The set of data flow policy rules that make up this service. </param>
        /// <returns> A new <see cref="MobileNetwork.MobileNetworkServiceData"/> instance for mocking. </returns>
        public static MobileNetworkServiceData MobileNetworkServiceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MobileNetworkProvisioningState? provisioningState = null, int servicePrecedence = default, MobileNetworkQosPolicy serviceQosPolicy = null, IEnumerable<PccRuleConfiguration> pccRules = null)
        {
            tags ??= new Dictionary<string, string>();
            pccRules ??= new List<PccRuleConfiguration>();

            return new MobileNetworkServiceData(id, name, resourceType, systemData, tags, location, provisioningState, servicePrecedence, serviceQosPolicy, pccRules?.ToList());
        }

        /// <summary> Initializes a new instance of MobileNetworkSimData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the SIM resource. </param>
        /// <param name="simState"> The state of the SIM resource. </param>
        /// <param name="siteProvisioningState"> A dictionary of sites to the provisioning state of this SIM on that site. </param>
        /// <param name="internationalMobileSubscriberIdentity"> The international mobile subscriber identity (IMSI) for the SIM. </param>
        /// <param name="integratedCircuitCardIdentifier"> The integrated circuit card ID (ICCID) for the SIM. </param>
        /// <param name="deviceType"> An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video camera'. The Azure portal allows SIMs to be grouped and filtered based on this value. </param>
        /// <param name="simPolicyId"> The SIM policy used by this SIM. The SIM policy must be in the same location as the SIM. </param>
        /// <param name="staticIPConfiguration"> A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached data network, slice}. </param>
        /// <param name="vendorName"> The name of the SIM vendor who provided this SIM, if any. </param>
        /// <param name="vendorKeyFingerprint"> The public key fingerprint of the SIM vendor who provided this SIM, if any. </param>
        /// <param name="authenticationKey"> The Ki value for the SIM. </param>
        /// <param name="operatorKeyCode"> The Opc value for the SIM. </param>
        /// <returns> A new <see cref="MobileNetwork.MobileNetworkSimData"/> instance for mocking. </returns>
        public static MobileNetworkSimData MobileNetworkSimData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MobileNetworkProvisioningState? provisioningState = null, MobileNetworkSimState? simState = null, IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState> siteProvisioningState = null, string internationalMobileSubscriberIdentity = null, string integratedCircuitCardIdentifier = null, string deviceType = null, ResourceIdentifier simPolicyId = null, IEnumerable<SimStaticIPProperties> staticIPConfiguration = null, string vendorName = null, string vendorKeyFingerprint = null, string authenticationKey = null, string operatorKeyCode = null)
        {
            siteProvisioningState ??= new Dictionary<string, MobileNetworkSiteProvisioningState>();
            staticIPConfiguration ??= new List<SimStaticIPProperties>();

            return new MobileNetworkSimData(id, name, resourceType, systemData, provisioningState, simState, siteProvisioningState, internationalMobileSubscriberIdentity, integratedCircuitCardIdentifier, deviceType, simPolicyId != null ? ResourceManagerModelFactory.WritableSubResource(simPolicyId) : null, staticIPConfiguration?.ToList(), vendorName, vendorKeyFingerprint, authenticationKey, operatorKeyCode);
        }

        /// <summary> Initializes a new instance of MobileNetworkSimGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="userAssignedIdentity"> The identity used to retrieve the encryption key from Azure key vault. </param>
        /// <param name="provisioningState"> The provisioning state of the SIM group resource. </param>
        /// <param name="keyUri"> A key to encrypt the SIM data that belongs to this SIM group. </param>
        /// <param name="mobileNetworkId"> Mobile network that this SIM group belongs to. The mobile network must be in the same location as the SIM group. </param>
        /// <returns> A new <see cref="MobileNetwork.MobileNetworkSimGroupData"/> instance for mocking. </returns>
        public static MobileNetworkSimGroupData MobileNetworkSimGroupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MobileNetworkManagedServiceIdentity userAssignedIdentity = null, MobileNetworkProvisioningState? provisioningState = null, Uri keyUri = null, ResourceIdentifier mobileNetworkId = null)
        {
            tags ??= new Dictionary<string, string>();

            return new MobileNetworkSimGroupData(id, name, resourceType, systemData, tags, location, userAssignedIdentity, provisioningState, keyUri != null ? new KeyVaultKey(keyUri) : null, mobileNetworkId != null ? ResourceManagerModelFactory.WritableSubResource(mobileNetworkId) : null);
        }

        /// <summary> Initializes a new instance of MobileNetworkSimPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the SIM policy resource. </param>
        /// <param name="siteProvisioningState"> A dictionary of sites to the provisioning state of this SIM policy on that site. </param>
        /// <param name="ueAmbr"> Aggregate maximum bit rate across all non-GBR QoS flows of all PDU sessions of a given UE. See 3GPP TS23.501 section 5.7.2.6 for a full description of the UE-AMBR. </param>
        /// <param name="defaultSliceId"> The default slice to use if the UE does not explicitly specify it. This slice must exist in the `sliceConfigurations` map. The slice must be in the same location as the SIM policy. </param>
        /// <param name="rfspIndex"> RAT/Frequency Selection Priority Index, defined in 3GPP TS 36.413. This is an optional setting and by default is unspecified. </param>
        /// <param name="registrationTimer"> UE periodic registration update timer (5G) or UE periodic tracking area update timer (4G), in seconds. </param>
        /// <param name="sliceConfigurations"> The allowed slices and the settings to use for them. The list must not contain duplicate items and must contain at least one item. </param>
        /// <returns> A new <see cref="MobileNetwork.MobileNetworkSimPolicyData"/> instance for mocking. </returns>
        public static MobileNetworkSimPolicyData MobileNetworkSimPolicyData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MobileNetworkProvisioningState? provisioningState = null, IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState> siteProvisioningState = null, Ambr ueAmbr = null, ResourceIdentifier defaultSliceId = null, int? rfspIndex = null, int? registrationTimer = null, IEnumerable<MobileNetworkSliceConfiguration> sliceConfigurations = null)
        {
            tags ??= new Dictionary<string, string>();
            siteProvisioningState ??= new Dictionary<string, MobileNetworkSiteProvisioningState>();
            sliceConfigurations ??= new List<MobileNetworkSliceConfiguration>();

            return new MobileNetworkSimPolicyData(id, name, resourceType, systemData, tags, location, provisioningState, siteProvisioningState, ueAmbr, defaultSliceId != null ? ResourceManagerModelFactory.WritableSubResource(defaultSliceId) : null, rfspIndex, registrationTimer, sliceConfigurations?.ToList());
        }

        /// <summary> Initializes a new instance of MobileNetworkSiteData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the site resource. </param>
        /// <param name="networkFunctions"> An array of IDs of the network functions deployed in the site. Deleting the site will delete any network functions that are deployed in the site. </param>
        /// <returns> A new <see cref="MobileNetwork.MobileNetworkSiteData"/> instance for mocking. </returns>
        public static MobileNetworkSiteData MobileNetworkSiteData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MobileNetworkProvisioningState? provisioningState = null, IEnumerable<SubResource> networkFunctions = null)
        {
            tags ??= new Dictionary<string, string>();
            networkFunctions ??= new List<SubResource>();

            return new MobileNetworkSiteData(id, name, resourceType, systemData, tags, location, provisioningState, networkFunctions?.ToList());
        }

        /// <summary> Initializes a new instance of MobileNetworkSliceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the network slice resource. </param>
        /// <param name="snssai"> Single-network slice selection assistance information (S-NSSAI). Unique at the scope of a mobile network. </param>
        /// <param name="description"> An optional description for this network slice. </param>
        /// <returns> A new <see cref="MobileNetwork.MobileNetworkSliceData"/> instance for mocking. </returns>
        public static MobileNetworkSliceData MobileNetworkSliceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MobileNetworkProvisioningState? provisioningState = null, Snssai snssai = null, string description = null)
        {
            tags ??= new Dictionary<string, string>();

            return new MobileNetworkSliceData(id, name, resourceType, systemData, tags, location, provisioningState, snssai, description);
        }
    }
}