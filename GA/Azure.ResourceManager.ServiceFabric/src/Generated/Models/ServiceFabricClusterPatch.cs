// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Cluster update request. </summary>
    public partial class ServiceFabricClusterPatch
    {
        /// <summary> Initializes a new instance of ServiceFabricClusterPatch. </summary>
        public ServiceFabricClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            AddOnFeatures = new ChangeTrackingList<ClusterAddOnFeature>();
            ClientCertificateCommonNames = new ChangeTrackingList<ClusterClientCertificateCommonName>();
            ClientCertificateThumbprints = new ChangeTrackingList<ClusterClientCertificateThumbprint>();
            FabricSettings = new ChangeTrackingList<SettingsSectionDescription>();
            NodeTypes = new ChangeTrackingList<ClusterNodeTypeDescription>();
            Notifications = new ChangeTrackingList<ClusterNotification>();
        }

        /// <summary> Cluster update parameters. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The list of add-on features to enable in the cluster. </summary>
        public IList<ClusterAddOnFeature> AddOnFeatures { get; }
        /// <summary> The certificate to use for securing the cluster. The certificate provided will be used for  node to node security within the cluster, SSL certificate for cluster management endpoint and default  admin client. </summary>
        public ClusterCertificateDescription Certificate { get; set; }
        /// <summary> Describes a list of server certificates referenced by common name that are used to secure the cluster. </summary>
        public ClusterServerCertificateCommonNames CertificateCommonNames { get; set; }
        /// <summary> The list of client certificates referenced by common name that are allowed to manage the cluster. This will overwrite the existing list. </summary>
        public IList<ClusterClientCertificateCommonName> ClientCertificateCommonNames { get; }
        /// <summary> The list of client certificates referenced by thumbprint that are allowed to manage the cluster. This will overwrite the existing list. </summary>
        public IList<ClusterClientCertificateThumbprint> ClientCertificateThumbprints { get; }
        /// <summary> The Service Fabric runtime version of the cluster. This property can only by set the user when **upgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get the list of available version for existing clusters use **availableClusterVersions**. </summary>
        public string ClusterCodeVersion { get; set; }
        /// <summary> Indicates if the event store service is enabled. </summary>
        public bool? IsEventStoreServiceEnabled { get; set; }
        /// <summary> The list of custom fabric settings to configure the cluster. This will overwrite the existing list. </summary>
        public IList<SettingsSectionDescription> FabricSettings { get; }
        /// <summary> The list of node types in the cluster. This will overwrite the existing list. </summary>
        public IList<ClusterNodeTypeDescription> NodeTypes { get; }
        /// <summary>
        /// The reliability level sets the replica set size of system services. Learn about [ReliabilityLevel](https://docs.microsoft.com/azure/service-fabric/service-fabric-cluster-capacity).
        ///
        ///   - None - Run the System services with a target replica set count of 1. This should only be used for test clusters.
        ///   - Bronze - Run the System services with a target replica set count of 3. This should only be used for test clusters.
        ///   - Silver - Run the System services with a target replica set count of 5.
        ///   - Gold - Run the System services with a target replica set count of 7.
        ///   - Platinum - Run the System services with a target replica set count of 9.
        ///
        /// </summary>
        public ClusterReliabilityLevel? ReliabilityLevel { get; set; }
        /// <summary> The server certificate used by reverse proxy. </summary>
        public ClusterCertificateDescription ReverseProxyCertificate { get; set; }
        /// <summary> The policy to use when upgrading the cluster. </summary>
        public ClusterUpgradePolicy UpgradeDescription { get; set; }
        /// <summary> The policy used to clean up unused versions. </summary>
        internal ApplicationTypeVersionsCleanupPolicy ApplicationTypeVersionsCleanupPolicy { get; set; }
        /// <summary> Number of unused versions per application type to keep. </summary>
        public long? MaxUnusedVersionsToKeep
        {
            get => ApplicationTypeVersionsCleanupPolicy is null ? default(long?) : ApplicationTypeVersionsCleanupPolicy.MaxUnusedVersionsToKeep;
            set
            {
                ApplicationTypeVersionsCleanupPolicy = value.HasValue ? new ApplicationTypeVersionsCleanupPolicy(value.Value) : null;
            }
        }

        /// <summary> The upgrade mode of the cluster when new Service Fabric runtime version is available. </summary>
        public ClusterUpgradeMode? UpgradeMode { get; set; }
        /// <summary> This property controls the logical grouping of VMs in upgrade domains (UDs). This property can't be modified if a node type with multiple Availability Zones is already present in the cluster. </summary>
        public SfZonalUpgradeMode? SfZonalUpgradeMode { get; set; }
        /// <summary> This property defines the upgrade mode for the virtual machine scale set, it is mandatory if a node type with multiple Availability Zones is added. </summary>
        public VmssZonalUpgradeMode? VmssZonalUpgradeMode { get; set; }
        /// <summary> Indicates if infrastructure service manager is enabled. </summary>
        public bool? IsInfrastructureServiceManagerEnabled { get; set; }
        /// <summary> Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only applies when **upgradeMode** is set to 'Automatic'. </summary>
        public ClusterUpgradeCadence? UpgradeWave { get; set; }
        /// <summary> The start timestamp to pause runtime version upgrades on the cluster (UTC). </summary>
        public DateTimeOffset? UpgradePauseStartOn { get; set; }
        /// <summary> The end timestamp of pause runtime version upgrades on the cluster (UTC). </summary>
        public DateTimeOffset? UpgradePauseEndOn { get; set; }
        /// <summary> Boolean to pause automatic runtime version upgrades to the cluster. </summary>
        public bool? IsWaveUpgradePaused { get; set; }
        /// <summary> Indicates a list of notification channels for cluster events. </summary>
        public IList<ClusterNotification> Notifications { get; }
    }
}