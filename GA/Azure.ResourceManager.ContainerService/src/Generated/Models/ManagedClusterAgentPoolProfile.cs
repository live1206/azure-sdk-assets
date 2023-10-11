// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Profile for the container service agent pool. </summary>
    public partial class ManagedClusterAgentPoolProfile : ManagedClusterAgentPoolProfileProperties
    {
        /// <summary> Initializes a new instance of ManagedClusterAgentPoolProfile. </summary>
        /// <param name="name"> Windows agent pool names must be 6 characters or less. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ManagedClusterAgentPoolProfile(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of ManagedClusterAgentPoolProfile. </summary>
        /// <param name="count"> Number of agents (VMs) to host docker containers. Allowed values must be in the range of 0 to 1000 (inclusive) for user pools and in the range of 1 to 1000 (inclusive) for system pools. The default value is 1. </param>
        /// <param name="vmSize"> VM size availability varies by region. If a node contains insufficient compute resources (memory, cpu, etc) pods might fail to run correctly. For more details on restricted VM sizes, see: https://docs.microsoft.com/azure/aks/quotas-skus-regions. </param>
        /// <param name="osDiskSizeInGB"> OS Disk Size in GB to be used to specify the disk size for every machine in the master/agent pool. If you specify 0, it will apply the default osDisk size according to the vmSize specified. </param>
        /// <param name="osDiskType"> The default is 'Ephemeral' if the VM supports it and has a cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to 'Managed'. May not be changed after creation. For more information see [Ephemeral OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os). </param>
        /// <param name="kubeletDiskType"> Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral storage. </param>
        /// <param name="workloadRuntime"> Determines the type of workload a node can run. </param>
        /// <param name="messageOfTheDay"> A base64-encoded string which will be written to /etc/motd after decoding. This allows customization of the message of the day for Linux nodes. It must not be specified for Windows nodes. It must be a static string (i.e., will be printed raw and not be executed as a script). </param>
        /// <param name="vnetSubnetId"> If this is not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and pods, otherwise it applies to just nodes. This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}. </param>
        /// <param name="podSubnetId"> If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details). This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}. </param>
        /// <param name="maxPods"> The maximum number of pods that can run on a node. </param>
        /// <param name="osType"> The operating system type. The default is Linux. </param>
        /// <param name="osSku"> Specifies the OS SKU used by the agent pool. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. </param>
        /// <param name="maxCount"> The maximum number of nodes for auto-scaling. </param>
        /// <param name="minCount"> The minimum number of nodes for auto-scaling. </param>
        /// <param name="enableAutoScaling"> Whether to enable auto-scaler. </param>
        /// <param name="scaleDownMode"> This also effects the cluster autoscaler behavior. If not specified, it defaults to Delete. </param>
        /// <param name="agentPoolType"> The type of Agent Pool. </param>
        /// <param name="mode"> A cluster must have at least one 'System' Agent Pool at all times. For additional information on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools. </param>
        /// <param name="orchestratorVersion"> Both patch version &lt;major.minor.patch&gt; and &lt;major.minor&gt; are supported. When &lt;major.minor&gt; is specified, the latest supported patch version is chosen automatically. Updating the agent pool with the same &lt;major.minor&gt; once it has been created will not trigger an upgrade, even if a newer patch version is available. As a best practice, you should upgrade all node pools in an AKS cluster to the same Kubernetes version. The node pool version must have the same major version as the control plane. The node pool minor version must be within two minor versions of the control plane version. The node pool version cannot be greater than the control plane version. For more information see [upgrading a node pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#upgrade-a-node-pool). </param>
        /// <param name="currentOrchestratorVersion"> If orchestratorVersion was a fully specified version &lt;major.minor.patch&gt;, this field will be exactly equal to it. If orchestratorVersion was &lt;major.minor&gt;, this field will contain the full &lt;major.minor.patch&gt; version being used. </param>
        /// <param name="nodeImageVersion"> The version of node image. </param>
        /// <param name="upgradeSettings"> Settings for upgrading the agentpool. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state. </param>
        /// <param name="powerState"> When an Agent Pool is first created it is initially Running. The Agent Pool can be stopped by setting this field to Stopped. A stopped Agent Pool stops all of its VMs and does not accrue billing charges. An Agent Pool can only be stopped if it is Running and provisioning state is Succeeded. </param>
        /// <param name="availabilityZones"> The list of Availability zones to use for nodes. This can only be specified if the AgentPoolType property is 'VirtualMachineScaleSets'. </param>
        /// <param name="enableNodePublicIP"> Some scenarios may require nodes in a node pool to receive their own dedicated public IP addresses. A common scenario is for gaming workloads, where a console needs to make a direct connection to a cloud virtual machine to minimize hops. For more information see [assigning a public IP per node](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#assign-a-public-ip-per-node-for-your-node-pools). The default is false. </param>
        /// <param name="enableCustomCATrust"> When set to true, AKS adds a label to the node indicating that the feature is enabled and deploys a daemonset along with host services to sync custom certificate authorities from user-provided list of base64 encoded certificates into node trust stores. Defaults to false. </param>
        /// <param name="nodePublicIPPrefixId"> This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}. </param>
        /// <param name="scaleSetPriority"> The Virtual Machine Scale Set priority. If not specified, the default is 'Regular'. </param>
        /// <param name="scaleSetEvictionPolicy"> This cannot be specified unless the scaleSetPriority is 'Spot'. If not specified, the default is 'Delete'. </param>
        /// <param name="spotMaxPrice"> Possible values are any decimal value greater than zero or -1 which indicates the willingness to pay any on-demand price. For more details on spot pricing, see [spot VMs pricing](https://docs.microsoft.com/azure/virtual-machines/spot-vms#pricing). </param>
        /// <param name="tags"> The tags to be persisted on the agent pool virtual machine scale set. </param>
        /// <param name="nodeLabels"> The node labels to be persisted across all nodes in agent pool. </param>
        /// <param name="nodeTaints"> The taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule. </param>
        /// <param name="proximityPlacementGroupId"> The ID for Proximity Placement Group. </param>
        /// <param name="kubeletConfig"> The Kubelet configuration on the agent pool nodes. </param>
        /// <param name="linuxOSConfig"> The OS configuration of Linux agent nodes. </param>
        /// <param name="enableEncryptionAtHost"> This is only supported on certain VM sizes and in certain Azure regions. For more information, see: https://docs.microsoft.com/azure/aks/enable-host-encryption. </param>
        /// <param name="enableUltraSsd"> Whether to enable UltraSSD. </param>
        /// <param name="enableFips"> See [Add a FIPS-enabled node pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#add-a-fips-enabled-node-pool-preview) for more details. </param>
        /// <param name="gpuInstanceProfile"> GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU. </param>
        /// <param name="creationData"> CreationData to be used to specify the source Snapshot ID if the node pool will be created/upgraded using a snapshot. </param>
        /// <param name="capacityReservationGroupId"> AKS will associate the specified agent pool with the Capacity Reservation Group. </param>
        /// <param name="hostGroupId"> This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}. For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts). </param>
        /// <param name="windowsProfile"> The Windows agent pool's specific profile. </param>
        /// <param name="networkProfile"> Network-related settings of an agent pool. </param>
        /// <param name="name"> Windows agent pool names must be 6 characters or less. </param>
        internal ManagedClusterAgentPoolProfile(int? count, string vmSize, int? osDiskSizeInGB, ContainerServiceOSDiskType? osDiskType, KubeletDiskType? kubeletDiskType, WorkloadRuntime? workloadRuntime, string messageOfTheDay, ResourceIdentifier vnetSubnetId, ResourceIdentifier podSubnetId, int? maxPods, ContainerServiceOSType? osType, ContainerServiceOSSku? osSku, int? maxCount, int? minCount, bool? enableAutoScaling, ScaleDownMode? scaleDownMode, AgentPoolType? agentPoolType, AgentPoolMode? mode, string orchestratorVersion, string currentOrchestratorVersion, string nodeImageVersion, AgentPoolUpgradeSettings upgradeSettings, string provisioningState, ContainerServicePowerState powerState, IList<string> availabilityZones, bool? enableNodePublicIP, bool? enableCustomCATrust, ResourceIdentifier nodePublicIPPrefixId, ScaleSetPriority? scaleSetPriority, ScaleSetEvictionPolicy? scaleSetEvictionPolicy, float? spotMaxPrice, IDictionary<string, string> tags, IDictionary<string, string> nodeLabels, IList<string> nodeTaints, ResourceIdentifier proximityPlacementGroupId, KubeletConfig kubeletConfig, LinuxOSConfig linuxOSConfig, bool? enableEncryptionAtHost, bool? enableUltraSsd, bool? enableFips, GpuInstanceProfile? gpuInstanceProfile, ContainerServiceCreationData creationData, ResourceIdentifier capacityReservationGroupId, ResourceIdentifier hostGroupId, AgentPoolWindowsProfile windowsProfile, AgentPoolNetworkProfile networkProfile, string name) : base(count, vmSize, osDiskSizeInGB, osDiskType, kubeletDiskType, workloadRuntime, messageOfTheDay, vnetSubnetId, podSubnetId, maxPods, osType, osSku, maxCount, minCount, enableAutoScaling, scaleDownMode, agentPoolType, mode, orchestratorVersion, currentOrchestratorVersion, nodeImageVersion, upgradeSettings, provisioningState, powerState, availabilityZones, enableNodePublicIP, enableCustomCATrust, nodePublicIPPrefixId, scaleSetPriority, scaleSetEvictionPolicy, spotMaxPrice, tags, nodeLabels, nodeTaints, proximityPlacementGroupId, kubeletConfig, linuxOSConfig, enableEncryptionAtHost, enableUltraSsd, enableFips, gpuInstanceProfile, creationData, capacityReservationGroupId, hostGroupId, windowsProfile, networkProfile)
        {
            Name = name;
        }

        /// <summary> Windows agent pool names must be 6 characters or less. </summary>
        public string Name { get; set; }
    }
}
