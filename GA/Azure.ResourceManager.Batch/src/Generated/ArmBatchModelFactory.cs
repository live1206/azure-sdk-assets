// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Batch;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmBatchModelFactory
    {
        /// <summary> Initializes a new instance of BatchIPRule. </summary>
        /// <param name="action"> Action when client IP address is matched. </param>
        /// <param name="value"> IPv4 address, or IPv4 address range in CIDR format. </param>
        /// <returns> A new <see cref="Models.BatchIPRule"/> instance for mocking. </returns>
        public static BatchIPRule BatchIPRule(BatchIPRuleAction action = default, string value = null)
        {
            return new BatchIPRule(action, value);
        }

        /// <summary> Initializes a new instance of BatchAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The identity of the Batch account. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="accountEndpoint"> The account endpoint used to interact with the Batch service. </param>
        /// <param name="nodeManagementEndpoint"> The endpoint used by compute node to connect to the Batch node management service. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="poolAllocationMode"> The allocation mode for creating pools in the Batch account. </param>
        /// <param name="keyVaultReference"> Identifies the Azure key vault associated with a Batch account. </param>
        /// <param name="publicNetworkAccess"> If not specified, the default value is 'enabled'. </param>
        /// <param name="networkProfile"> The network profile only takes effect when publicNetworkAccess is enabled. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the Batch account. </param>
        /// <param name="autoStorage"> Contains information about the auto-storage account associated with a Batch account. </param>
        /// <param name="encryption"> Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft managed key. For additional control, a customer-managed key can be used instead. </param>
        /// <param name="dedicatedCoreQuota"> For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </param>
        /// <param name="lowPriorityCoreQuota"> For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </param>
        /// <param name="dedicatedCoreQuotaPerVmFamily"> A list of the dedicated core quota per Virtual Machine family for the Batch account. For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </param>
        /// <param name="isDedicatedCoreQuotaPerVmFamilyEnforced"> If this flag is true, dedicated core quota is enforced via both the dedicatedCoreQuotaPerVMFamily and dedicatedCoreQuota properties on the account. If this flag is false, dedicated core quota is enforced only via the dedicatedCoreQuota property on the account and does not consider Virtual Machine family. </param>
        /// <param name="poolQuota"> The pool quota for the Batch account. </param>
        /// <param name="activeJobAndJobScheduleQuota"> The active job and job schedule quota for the Batch account. </param>
        /// <param name="allowedAuthenticationModes"> List of allowed authentication modes for the Batch account that can be used to authenticate with the data plane. This does not affect authentication with the control plane. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="tags"> The tags of the resource. </param>
        /// <returns> A new <see cref="Batch.BatchAccountData"/> instance for mocking. </returns>
        public static BatchAccountData BatchAccountData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ManagedServiceIdentity identity = null, string accountEndpoint = null, string nodeManagementEndpoint = null, BatchProvisioningState? provisioningState = null, BatchAccountPoolAllocationMode? poolAllocationMode = null, BatchKeyVaultReference keyVaultReference = null, BatchPublicNetworkAccess? publicNetworkAccess = null, BatchNetworkProfile networkProfile = null, IEnumerable<BatchPrivateEndpointConnectionData> privateEndpointConnections = null, BatchAccountAutoStorageConfiguration autoStorage = null, BatchAccountEncryptionConfiguration encryption = null, int? dedicatedCoreQuota = null, int? lowPriorityCoreQuota = null, IEnumerable<BatchVmFamilyCoreQuota> dedicatedCoreQuotaPerVmFamily = null, bool? isDedicatedCoreQuotaPerVmFamilyEnforced = null, int? poolQuota = null, int? activeJobAndJobScheduleQuota = null, IEnumerable<BatchAuthenticationMode> allowedAuthenticationModes = null, AzureLocation? location = null, IDictionary<string, string> tags = null)
        {
            privateEndpointConnections ??= new List<BatchPrivateEndpointConnectionData>();
            dedicatedCoreQuotaPerVmFamily ??= new List<BatchVmFamilyCoreQuota>();
            allowedAuthenticationModes ??= new List<BatchAuthenticationMode>();
            tags ??= new Dictionary<string, string>();

            return new BatchAccountData(id, name, resourceType, systemData, identity, accountEndpoint, nodeManagementEndpoint, provisioningState, poolAllocationMode, keyVaultReference, publicNetworkAccess, networkProfile, privateEndpointConnections?.ToList(), autoStorage, encryption, dedicatedCoreQuota, lowPriorityCoreQuota, dedicatedCoreQuotaPerVmFamily?.ToList(), isDedicatedCoreQuotaPerVmFamilyEnforced, poolQuota, activeJobAndJobScheduleQuota, allowedAuthenticationModes?.ToList(), location, tags);
        }

        /// <summary> Initializes a new instance of BatchPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection. </param>
        /// <param name="privateEndpointId"> The private endpoint of the private endpoint connection. </param>
        /// <param name="groupIds"> The value has one and only one group id. </param>
        /// <param name="connectionState"> The private link service connection state of the private endpoint connection. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <returns> A new <see cref="Batch.BatchPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static BatchPrivateEndpointConnectionData BatchPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, BatchPrivateEndpointConnectionProvisioningState? provisioningState = null, ResourceIdentifier privateEndpointId = null, IEnumerable<string> groupIds = null, BatchPrivateLinkServiceConnectionState connectionState = null, ETag? etag = null)
        {
            groupIds ??= new List<string>();

            return new BatchPrivateEndpointConnectionData(id, name, resourceType, systemData, provisioningState, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, groupIds?.ToList(), connectionState, etag);
        }

        /// <summary> Initializes a new instance of BatchPrivateLinkServiceConnectionState. </summary>
        /// <param name="status"> The status of the Batch private endpoint connection. </param>
        /// <param name="description"> Description of the private Connection state. </param>
        /// <param name="actionRequired"> Action required on the private connection state. </param>
        /// <returns> A new <see cref="Models.BatchPrivateLinkServiceConnectionState"/> instance for mocking. </returns>
        public static BatchPrivateLinkServiceConnectionState BatchPrivateLinkServiceConnectionState(BatchPrivateLinkServiceConnectionStatus status = default, string description = null, string actionRequired = null)
        {
            return new BatchPrivateLinkServiceConnectionState(status, description, actionRequired);
        }

        /// <summary> Initializes a new instance of BatchVmFamilyCoreQuota. </summary>
        /// <param name="name"> The Virtual Machine family name. </param>
        /// <param name="coreQuota"> The core quota for the VM family for the Batch account. </param>
        /// <returns> A new <see cref="Models.BatchVmFamilyCoreQuota"/> instance for mocking. </returns>
        public static BatchVmFamilyCoreQuota BatchVmFamilyCoreQuota(string name = null, int? coreQuota = null)
        {
            return new BatchVmFamilyCoreQuota(name, coreQuota);
        }

        /// <summary> Initializes a new instance of BatchAccountKeys. </summary>
        /// <param name="accountName"> The Batch account name. </param>
        /// <param name="primary"> The primary key associated with the account. </param>
        /// <param name="secondary"> The secondary key associated with the account. </param>
        /// <returns> A new <see cref="Models.BatchAccountKeys"/> instance for mocking. </returns>
        public static BatchAccountKeys BatchAccountKeys(string accountName = null, string primary = null, string secondary = null)
        {
            return new BatchAccountKeys(accountName, primary, secondary);
        }

        /// <summary> Initializes a new instance of BatchApplicationPackageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> The current state of the application package. </param>
        /// <param name="format"> The format of the application package, if the package is active. </param>
        /// <param name="storageUri"> The URL for the application package in Azure Storage. </param>
        /// <param name="storageUriExpireOn"> The UTC time at which the Azure Storage URL will expire. </param>
        /// <param name="lastActivatedOn"> The time at which the package was last activated, if the package is active. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <returns> A new <see cref="Batch.BatchApplicationPackageData"/> instance for mocking. </returns>
        public static BatchApplicationPackageData BatchApplicationPackageData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, BatchApplicationPackageState? state = null, string format = null, Uri storageUri = null, DateTimeOffset? storageUriExpireOn = null, DateTimeOffset? lastActivatedOn = null, ETag? etag = null)
        {
            return new BatchApplicationPackageData(id, name, resourceType, systemData, state, format, storageUri, storageUriExpireOn, lastActivatedOn, etag);
        }

        /// <summary> Initializes a new instance of BatchApplicationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> The display name for the application. </param>
        /// <param name="allowUpdates"> A value indicating whether packages within the application may be overwritten using the same version string. </param>
        /// <param name="defaultVersion"> The package to use if a client requests the application but does not specify a version. This property can only be set to the name of an existing package. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <returns> A new <see cref="Batch.BatchApplicationData"/> instance for mocking. </returns>
        public static BatchApplicationData BatchApplicationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, bool? allowUpdates = null, string defaultVersion = null, ETag? etag = null)
        {
            return new BatchApplicationData(id, name, resourceType, systemData, displayName, allowUpdates, defaultVersion, etag);
        }

        /// <summary> Initializes a new instance of BatchLocationQuota. </summary>
        /// <param name="accountQuota"> The number of Batch accounts that may be created under the subscription in the specified region. </param>
        /// <returns> A new <see cref="Models.BatchLocationQuota"/> instance for mocking. </returns>
        public static BatchLocationQuota BatchLocationQuota(int? accountQuota = null)
        {
            return new BatchLocationQuota(accountQuota);
        }

        /// <summary> Initializes a new instance of BatchSupportedSku. </summary>
        /// <param name="name"> The name of the SKU. </param>
        /// <param name="familyName"> The family name of the SKU. </param>
        /// <param name="capabilities"> A collection of capabilities which this SKU supports. </param>
        /// <returns> A new <see cref="Models.BatchSupportedSku"/> instance for mocking. </returns>
        public static BatchSupportedSku BatchSupportedSku(string name = null, string familyName = null, IEnumerable<BatchSkuCapability> capabilities = null)
        {
            capabilities ??= new List<BatchSkuCapability>();

            return new BatchSupportedSku(name, familyName, capabilities?.ToList());
        }

        /// <summary> Initializes a new instance of BatchSkuCapability. </summary>
        /// <param name="name"> The name of the feature. </param>
        /// <param name="value"> The value of the feature. </param>
        /// <returns> A new <see cref="Models.BatchSkuCapability"/> instance for mocking. </returns>
        public static BatchSkuCapability BatchSkuCapability(string name = null, string value = null)
        {
            return new BatchSkuCapability(name, value);
        }

        /// <summary> Initializes a new instance of BatchNameAvailabilityResult. </summary>
        /// <param name="isNameAvailable"> Gets a boolean value that indicates whether the name is available for you to use. If true, the name is available. If false, the name has already been taken or invalid and cannot be used. </param>
        /// <param name="reason"> Gets the reason that a Batch account name could not be used. The Reason element is only returned if NameAvailable is false. </param>
        /// <param name="message"> Gets an error message explaining the Reason value in more detail. </param>
        /// <returns> A new <see cref="Models.BatchNameAvailabilityResult"/> instance for mocking. </returns>
        public static BatchNameAvailabilityResult BatchNameAvailabilityResult(bool? isNameAvailable = null, BatchNameUnavailableReason? reason = null, string message = null)
        {
            return new BatchNameAvailabilityResult(isNameAvailable, reason, message);
        }

        /// <summary> Initializes a new instance of BatchAccountCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="thumbprintAlgorithm"> This must match the first portion of the certificate name. Currently required to be 'SHA1'. </param>
        /// <param name="thumbprintString"> This must match the thumbprint from the name. </param>
        /// <param name="format"> The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx. </param>
        /// <param name="provisioningState"></param>
        /// <param name="provisioningStateTransitOn"> The time at which the certificate entered its current state. </param>
        /// <param name="previousProvisioningState"> The previous provisioned state of the resource. </param>
        /// <param name="previousProvisioningStateTransitOn"> The time at which the certificate entered its previous state. </param>
        /// <param name="publicData"> The public key of the certificate. </param>
        /// <param name="deleteCertificateError"> This is only returned when the certificate provisioningState is 'Failed'. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <returns> A new <see cref="Batch.BatchAccountCertificateData"/> instance for mocking. </returns>
        public static BatchAccountCertificateData BatchAccountCertificateData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string thumbprintAlgorithm = null, string thumbprintString = null, BatchAccountCertificateFormat? format = null, BatchAccountCertificateProvisioningState? provisioningState = null, DateTimeOffset? provisioningStateTransitOn = null, BatchAccountCertificateProvisioningState? previousProvisioningState = null, DateTimeOffset? previousProvisioningStateTransitOn = null, string publicData = null, ResponseError deleteCertificateError = null, ETag? etag = null)
        {
            return new BatchAccountCertificateData(id, name, resourceType, systemData, thumbprintAlgorithm, thumbprintString, format, provisioningState, provisioningStateTransitOn, previousProvisioningState, previousProvisioningStateTransitOn, publicData, deleteCertificateError, etag);
        }

        /// <summary> Initializes a new instance of BatchAccountCertificateCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="thumbprintAlgorithm"> This must match the first portion of the certificate name. Currently required to be 'SHA1'. </param>
        /// <param name="thumbprintString"> This must match the thumbprint from the name. </param>
        /// <param name="format"> The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx. </param>
        /// <param name="data"> The maximum size is 10KB. </param>
        /// <param name="password"> This must not be specified if the certificate format is Cer. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <returns> A new <see cref="Models.BatchAccountCertificateCreateOrUpdateContent"/> instance for mocking. </returns>
        public static BatchAccountCertificateCreateOrUpdateContent BatchAccountCertificateCreateOrUpdateContent(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string thumbprintAlgorithm = null, string thumbprintString = null, BatchAccountCertificateFormat? format = null, BinaryData data = null, string password = null, ETag? etag = null)
        {
            return new BatchAccountCertificateCreateOrUpdateContent(id, name, resourceType, systemData, thumbprintAlgorithm, thumbprintString, format, data, password, etag);
        }

        /// <summary> Initializes a new instance of BatchAccountDetectorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> A base64 encoded string that represents the content of a detector. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <returns> A new <see cref="Batch.BatchAccountDetectorData"/> instance for mocking. </returns>
        public static BatchAccountDetectorData BatchAccountDetectorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string value = null, ETag? etag = null)
        {
            return new BatchAccountDetectorData(id, name, resourceType, systemData, value, etag);
        }

        /// <summary> Initializes a new instance of BatchPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The group id is used to establish the private link connection. </param>
        /// <param name="requiredMembers"> The list of required members that are used to establish the private link connection. </param>
        /// <param name="requiredZoneNames"> The list of required zone names for the private DNS resource name. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <returns> A new <see cref="Batch.BatchPrivateLinkResourceData"/> instance for mocking. </returns>
        public static BatchPrivateLinkResourceData BatchPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null, ETag? etag = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new BatchPrivateLinkResourceData(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), etag);
        }

        /// <summary> Initializes a new instance of BatchAccountPoolData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The type of identity used for the Batch Pool. Current supported identity types: UserAssigned, None. </param>
        /// <param name="displayName"> The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </param>
        /// <param name="lastModifiedOn"> This is the last time at which the pool level data, such as the targetDedicatedNodes or autoScaleSettings, changed. It does not factor in node-level changes such as a compute node changing state. </param>
        /// <param name="createdOn"> The creation time of the pool. </param>
        /// <param name="provisioningState"> The current state of the pool. </param>
        /// <param name="provisioningStateTransitOn"> The time at which the pool entered its current state. </param>
        /// <param name="allocationState"> Whether the pool is resizing. </param>
        /// <param name="allocationStateTransitionOn"> The time at which the pool entered its current allocation state. </param>
        /// <param name="vmSize"> For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series). </param>
        /// <param name="deploymentConfiguration"> Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS). </param>
        /// <param name="currentDedicatedNodes"> The number of dedicated compute nodes currently in the pool. </param>
        /// <param name="currentLowPriorityNodes"> The number of Spot/low-priority compute nodes currently in the pool. </param>
        /// <param name="scaleSettings"> Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes. </param>
        /// <param name="autoScaleRun"> This property is set only if the pool automatically scales, i.e. autoScaleSettings are used. </param>
        /// <param name="interNodeCommunication"> This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'. </param>
        /// <param name="networkConfiguration"> The network configuration for a pool. </param>
        /// <param name="taskSlotsPerNode"> The default value is 1. The maximum value is the smaller of 4 times the number of cores of the vmSize of the pool or 256. </param>
        /// <param name="taskSchedulingNodeFillType"> If not specified, the default is spread. </param>
        /// <param name="userAccounts"> The list of user accounts to be created on each node in the pool. </param>
        /// <param name="metadata"> The Batch service does not assign any meaning to metadata; it is solely for the use of user code. </param>
        /// <param name="startTask"> In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool. </param>
        /// <param name="certificates">
        /// For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
        ///
        /// Warning: This property is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// </param>
        /// <param name="applicationPackages"> Changes to application package references affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged. There is a maximum of 10 application package references on any given pool. </param>
        /// <param name="applicationLicenses"> The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail. </param>
        /// <param name="resizeOperationStatus"> Describes either the current operation (if the pool AllocationState is Resizing) or the previously completed operation (if the AllocationState is Steady). </param>
        /// <param name="mountConfiguration"> This supports Azure Files, NFS, CIFS/SMB, and Blobfuse. </param>
        /// <param name="targetNodeCommunicationMode"> If omitted, the default value is Default. </param>
        /// <param name="currentNodeCommunicationMode"> Determines how a pool communicates with the Batch service. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <returns> A new <see cref="Batch.BatchAccountPoolData"/> instance for mocking. </returns>
        public static BatchAccountPoolData BatchAccountPoolData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ManagedServiceIdentity identity = null, string displayName = null, DateTimeOffset? lastModifiedOn = null, DateTimeOffset? createdOn = null, BatchAccountPoolProvisioningState? provisioningState = null, DateTimeOffset? provisioningStateTransitOn = null, BatchAccountPoolAllocationState? allocationState = null, DateTimeOffset? allocationStateTransitionOn = null, string vmSize = null, BatchDeploymentConfiguration deploymentConfiguration = null, int? currentDedicatedNodes = null, int? currentLowPriorityNodes = null, BatchAccountPoolScaleSettings scaleSettings = null, BatchAccountPoolAutoScaleRun autoScaleRun = null, InterNodeCommunicationState? interNodeCommunication = null, BatchNetworkConfiguration networkConfiguration = null, int? taskSlotsPerNode = null, BatchNodeFillType? taskSchedulingNodeFillType = null, IEnumerable<BatchUserAccount> userAccounts = null, IEnumerable<BatchAccountPoolMetadataItem> metadata = null, BatchAccountPoolStartTask startTask = null, IEnumerable<BatchCertificateReference> certificates = null, IEnumerable<BatchApplicationPackageReference> applicationPackages = null, IEnumerable<string> applicationLicenses = null, BatchResizeOperationStatus resizeOperationStatus = null, IEnumerable<BatchMountConfiguration> mountConfiguration = null, NodeCommunicationMode? targetNodeCommunicationMode = null, NodeCommunicationMode? currentNodeCommunicationMode = null, ETag? etag = null)
        {
            userAccounts ??= new List<BatchUserAccount>();
            metadata ??= new List<BatchAccountPoolMetadataItem>();
            certificates ??= new List<BatchCertificateReference>();
            applicationPackages ??= new List<BatchApplicationPackageReference>();
            applicationLicenses ??= new List<string>();
            mountConfiguration ??= new List<BatchMountConfiguration>();

            return new BatchAccountPoolData(id, name, resourceType, systemData, identity, displayName, lastModifiedOn, createdOn, provisioningState, provisioningStateTransitOn, allocationState, allocationStateTransitionOn, vmSize, deploymentConfiguration, currentDedicatedNodes, currentLowPriorityNodes, scaleSettings, autoScaleRun, interNodeCommunication, networkConfiguration, taskSlotsPerNode, taskSchedulingNodeFillType.HasValue ? new TaskSchedulingPolicy(taskSchedulingNodeFillType.Value) : null, userAccounts?.ToList(), metadata?.ToList(), startTask, certificates?.ToList(), applicationPackages?.ToList(), applicationLicenses?.ToList(), resizeOperationStatus, mountConfiguration?.ToList(), targetNodeCommunicationMode, currentNodeCommunicationMode, etag);
        }

        /// <summary> Initializes a new instance of BatchAccountPoolAutoScaleRun. </summary>
        /// <param name="evaluationOn"> The time at which the autoscale formula was last evaluated. </param>
        /// <param name="results"> Each variable value is returned in the form $variable=value, and variables are separated by semicolons. </param>
        /// <param name="error"> An error that occurred when autoscaling a pool. </param>
        /// <returns> A new <see cref="Models.BatchAccountPoolAutoScaleRun"/> instance for mocking. </returns>
        public static BatchAccountPoolAutoScaleRun BatchAccountPoolAutoScaleRun(DateTimeOffset evaluationOn = default, string results = null, ResponseError error = null)
        {
            return new BatchAccountPoolAutoScaleRun(evaluationOn, results, error);
        }

        /// <summary> Initializes a new instance of BatchResizeOperationStatus. </summary>
        /// <param name="targetDedicatedNodes"> The desired number of dedicated compute nodes in the pool. </param>
        /// <param name="targetLowPriorityNodes"> The desired number of Spot/low-priority compute nodes in the pool. </param>
        /// <param name="resizeTimeout"> The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="nodeDeallocationOption"> The default value is requeue. </param>
        /// <param name="startOn"> The time when this resize operation was started. </param>
        /// <param name="errors"> This property is set only if an error occurred during the last pool resize, and only when the pool allocationState is Steady. </param>
        /// <returns> A new <see cref="Models.BatchResizeOperationStatus"/> instance for mocking. </returns>
        public static BatchResizeOperationStatus BatchResizeOperationStatus(int? targetDedicatedNodes = null, int? targetLowPriorityNodes = null, TimeSpan? resizeTimeout = null, BatchNodeDeallocationOption? nodeDeallocationOption = null, DateTimeOffset? startOn = null, IEnumerable<ResponseError> errors = null)
        {
            errors ??= new List<ResponseError>();

            return new BatchResizeOperationStatus(targetDedicatedNodes, targetLowPriorityNodes, resizeTimeout, nodeDeallocationOption, startOn, errors?.ToList());
        }

        /// <summary> Initializes a new instance of BatchAccountOutboundEnvironmentEndpoint. </summary>
        /// <param name="category"> The type of service that the Batch service connects to. </param>
        /// <param name="endpoints"> The endpoints for this service to which the Batch service makes outbound calls. </param>
        /// <returns> A new <see cref="Models.BatchAccountOutboundEnvironmentEndpoint"/> instance for mocking. </returns>
        public static BatchAccountOutboundEnvironmentEndpoint BatchAccountOutboundEnvironmentEndpoint(string category = null, IEnumerable<BatchAccountEndpointDependency> endpoints = null)
        {
            endpoints ??= new List<BatchAccountEndpointDependency>();

            return new BatchAccountOutboundEnvironmentEndpoint(category, endpoints?.ToList());
        }

        /// <summary> Initializes a new instance of BatchAccountEndpointDependency. </summary>
        /// <param name="domainName"> The domain name of the dependency. Domain names may be fully qualified or may contain a * wildcard. </param>
        /// <param name="description"> Human-readable supplemental information about the dependency and when it is applicable. </param>
        /// <param name="endpointDetails"> The list of connection details for this endpoint. </param>
        /// <returns> A new <see cref="Models.BatchAccountEndpointDependency"/> instance for mocking. </returns>
        public static BatchAccountEndpointDependency BatchAccountEndpointDependency(string domainName = null, string description = null, IEnumerable<BatchEndpointDetail> endpointDetails = null)
        {
            endpointDetails ??= new List<BatchEndpointDetail>();

            return new BatchAccountEndpointDependency(domainName, description, endpointDetails?.ToList());
        }

        /// <summary> Initializes a new instance of BatchEndpointDetail. </summary>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <returns> A new <see cref="Models.BatchEndpointDetail"/> instance for mocking. </returns>
        public static BatchEndpointDetail BatchEndpointDetail(int? port = null)
        {
            return new BatchEndpointDetail(port);
        }
    }
}