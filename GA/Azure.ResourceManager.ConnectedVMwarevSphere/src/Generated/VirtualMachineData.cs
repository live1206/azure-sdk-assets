// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing the VirtualMachine data model.
    /// Define the virtualMachine.
    /// </summary>
    public partial class VirtualMachineData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualMachineData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineData(AzureLocation location) : base(location)
        {
            Statuses = new ChangeTrackingList<ResourceStatus>();
        }

        /// <summary> Initializes a new instance of VirtualMachineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="identity"> The identity of the resource. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="resourcePoolId">
        /// Gets or sets the ARM Id of the resourcePool resource on which this virtual machine will
        /// deploy.
        /// </param>
        /// <param name="templateId"> Gets or sets the ARM Id of the template resource to deploy the virtual machine. </param>
        /// <param name="vCenterId"> Gets or sets the ARM Id of the vCenter resource in which this resource pool resides. </param>
        /// <param name="placementProfile"> Placement properties. </param>
        /// <param name="osProfile"> OS properties. </param>
        /// <param name="hardwareProfile"> Hardware properties. </param>
        /// <param name="networkProfile"> Network properties. </param>
        /// <param name="storageProfile"> Storage properties. </param>
        /// <param name="guestAgentProfile"> Guest agent status properties. </param>
        /// <param name="moRefId"> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the virtual machine. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the virtual machine. </param>
        /// <param name="moName"> Gets or sets the vCenter Managed Object name for the virtual machine. </param>
        /// <param name="folderPath"> Gets or sets the folder path of the vm. </param>
        /// <param name="instanceUuid"> Gets or sets the instance uuid of the vm. </param>
        /// <param name="smbiosUuid"> Gets or sets the SMBIOS UUID of the vm. </param>
        /// <param name="firmwareType"> Firmware type. </param>
        /// <param name="powerState"> Gets the power state of the virtual machine. </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="uuid"> Gets or sets a unique identifier for this resource. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <param name="vmId"> Gets or sets a unique identifier for the vm resource. </param>
        internal VirtualMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string kind, ManagedServiceIdentity identity, string resourcePoolId, string templateId, string vCenterId, PlacementProfile placementProfile, OSProfile osProfile, HardwareProfile hardwareProfile, NetworkProfile networkProfile, StorageProfile storageProfile, GuestAgentProfile guestAgentProfile, string moRefId, string inventoryItemId, string moName, string folderPath, string instanceUuid, string smbiosUuid, FirmwareType? firmwareType, string powerState, string customResourceName, string uuid, IReadOnlyList<ResourceStatus> statuses, string provisioningState, string vmId) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            Kind = kind;
            Identity = identity;
            ResourcePoolId = resourcePoolId;
            TemplateId = templateId;
            VCenterId = vCenterId;
            PlacementProfile = placementProfile;
            OSProfile = osProfile;
            HardwareProfile = hardwareProfile;
            NetworkProfile = networkProfile;
            StorageProfile = storageProfile;
            GuestAgentProfile = guestAgentProfile;
            MoRefId = moRefId;
            InventoryItemId = inventoryItemId;
            MoName = moName;
            FolderPath = folderPath;
            InstanceUuid = instanceUuid;
            SmbiosUuid = smbiosUuid;
            FirmwareType = firmwareType;
            PowerState = powerState;
            CustomResourceName = customResourceName;
            Uuid = uuid;
            Statuses = statuses;
            ProvisioningState = provisioningState;
            VmId = vmId;
        }

        /// <summary> Gets or sets the extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> The identity of the resource. Current supported identity types: None, SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// Gets or sets the ARM Id of the resourcePool resource on which this virtual machine will
        /// deploy.
        /// </summary>
        public string ResourcePoolId { get; set; }
        /// <summary> Gets or sets the ARM Id of the template resource to deploy the virtual machine. </summary>
        public string TemplateId { get; set; }
        /// <summary> Gets or sets the ARM Id of the vCenter resource in which this resource pool resides. </summary>
        public string VCenterId { get; set; }
        /// <summary> Placement properties. </summary>
        public PlacementProfile PlacementProfile { get; set; }
        /// <summary> OS properties. </summary>
        public OSProfile OSProfile { get; set; }
        /// <summary> Hardware properties. </summary>
        public HardwareProfile HardwareProfile { get; set; }
        /// <summary> Network properties. </summary>
        internal NetworkProfile NetworkProfile { get; set; }
        /// <summary> Gets or sets the list of network interfaces associated with the virtual machine. </summary>
        public IList<NetworkInterface> NetworkInterfaces
        {
            get
            {
                if (NetworkProfile is null)
                    NetworkProfile = new NetworkProfile();
                return NetworkProfile.NetworkInterfaces;
            }
        }

        /// <summary> Storage properties. </summary>
        public StorageProfile StorageProfile { get; set; }
        /// <summary> Guest agent status properties. </summary>
        public GuestAgentProfile GuestAgentProfile { get; set; }
        /// <summary> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the virtual machine. </summary>
        public string MoRefId { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the virtual machine. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> Gets or sets the vCenter Managed Object name for the virtual machine. </summary>
        public string MoName { get; }
        /// <summary> Gets or sets the folder path of the vm. </summary>
        public string FolderPath { get; }
        /// <summary> Gets or sets the instance uuid of the vm. </summary>
        public string InstanceUuid { get; }
        /// <summary> Gets or sets the SMBIOS UUID of the vm. </summary>
        public string SmbiosUuid { get; set; }
        /// <summary> Firmware type. </summary>
        public FirmwareType? FirmwareType { get; set; }
        /// <summary> Gets the power state of the virtual machine. </summary>
        public string PowerState { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> Gets or sets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<ResourceStatus> Statuses { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Gets or sets a unique identifier for the vm resource. </summary>
        public string VmId { get; }
    }
}