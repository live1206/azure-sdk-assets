// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The VirtualNetworksPropertiesInfraVnetProfile. </summary>
    public partial class VirtualNetworksPropertiesInfraVnetProfile
    {
        /// <summary> Initializes a new instance of VirtualNetworksPropertiesInfraVnetProfile. </summary>
        public VirtualNetworksPropertiesInfraVnetProfile()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworksPropertiesInfraVnetProfile. </summary>
        /// <param name="hci"> Infra network profile for HCI platform. </param>
        /// <param name="networkCloud"> Infra network profile for the NetworkCloud platform. </param>
        /// <param name="vmware"> Infra network profile for VMware platform. </param>
        internal VirtualNetworksPropertiesInfraVnetProfile(VirtualNetworksPropertiesInfraVnetProfileHci hci, VirtualNetworksPropertiesInfraVnetProfileNetworkCloud networkCloud, VirtualNetworksPropertiesInfraVnetProfileVmware vmware)
        {
            Hci = hci;
            NetworkCloud = networkCloud;
            Vmware = vmware;
        }

        /// <summary> Infra network profile for HCI platform. </summary>
        public VirtualNetworksPropertiesInfraVnetProfileHci Hci { get; set; }
        /// <summary> Infra network profile for the NetworkCloud platform. </summary>
        internal VirtualNetworksPropertiesInfraVnetProfileNetworkCloud NetworkCloud { get; set; }
        /// <summary> The ARM ID of Network Cloud Network Resource to Associate with this VirtualNetwork. </summary>
        public string NetworkId
        {
            get => NetworkCloud is null ? default : NetworkCloud.NetworkId;
            set
            {
                if (NetworkCloud is null)
                    NetworkCloud = new VirtualNetworksPropertiesInfraVnetProfileNetworkCloud();
                NetworkCloud.NetworkId = value;
            }
        }

        /// <summary> Infra network profile for VMware platform. </summary>
        internal VirtualNetworksPropertiesInfraVnetProfileVmware Vmware { get; set; }
        /// <summary> Name of the network segment in VSphere. </summary>
        public string VmwareSegmentName
        {
            get => Vmware is null ? default : Vmware.SegmentName;
            set
            {
                if (Vmware is null)
                    Vmware = new VirtualNetworksPropertiesInfraVnetProfileVmware();
                Vmware.SegmentName = value;
            }
        }
    }
}
