// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine network interface configurations. </summary>
    public partial class VirtualMachineNetworkInterfaceConfiguration
    {
        /// <summary> Initializes a new instance of VirtualMachineNetworkInterfaceConfiguration. </summary>
        /// <param name="name"> The network interface configuration name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public VirtualMachineNetworkInterfaceConfiguration(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            IPConfigurations = new ChangeTrackingList<VirtualMachineNetworkInterfaceIPConfiguration>();
        }

        /// <summary> Initializes a new instance of VirtualMachineNetworkInterfaceConfiguration. </summary>
        /// <param name="name"> The network interface configuration name. </param>
        /// <param name="primary"> Specifies the primary network interface in case the virtual machine has more than 1 network interface. </param>
        /// <param name="deleteOption"> Specify what happens to the network interface when the VM is deleted. </param>
        /// <param name="enableAcceleratedNetworking"> Specifies whether the network interface is accelerated networking-enabled. </param>
        /// <param name="isTcpStateTrackingDisabled"> Specifies whether the network interface is disabled for tcp state tracking. </param>
        /// <param name="enableFpga"> Specifies whether the network interface is FPGA networking-enabled. </param>
        /// <param name="enableIPForwarding"> Whether IP forwarding enabled on this NIC. </param>
        /// <param name="networkSecurityGroup"> The network security group. </param>
        /// <param name="dnsSettings"> The dns settings to be applied on the network interfaces. </param>
        /// <param name="ipConfigurations"> Specifies the IP configurations of the network interface. </param>
        /// <param name="dscpConfiguration"> Gets or sets the dscp configuration. </param>
        /// <param name="auxiliaryMode"> Specifies whether the Auxiliary mode is enabled for the Network Interface resource. </param>
        /// <param name="auxiliarySku"> Specifies whether the Auxiliary sku is enabled for the Network Interface resource. </param>
        internal VirtualMachineNetworkInterfaceConfiguration(string name, bool? primary, ComputeDeleteOption? deleteOption, bool? enableAcceleratedNetworking, bool? isTcpStateTrackingDisabled, bool? enableFpga, bool? enableIPForwarding, WritableSubResource networkSecurityGroup, VirtualMachineNetworkInterfaceDnsSettingsConfiguration dnsSettings, IList<VirtualMachineNetworkInterfaceIPConfiguration> ipConfigurations, WritableSubResource dscpConfiguration, ComputeNetworkInterfaceAuxiliaryMode? auxiliaryMode, ComputeNetworkInterfaceAuxiliarySku? auxiliarySku)
        {
            Name = name;
            Primary = primary;
            DeleteOption = deleteOption;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            IsTcpStateTrackingDisabled = isTcpStateTrackingDisabled;
            EnableFpga = enableFpga;
            EnableIPForwarding = enableIPForwarding;
            NetworkSecurityGroup = networkSecurityGroup;
            DnsSettings = dnsSettings;
            IPConfigurations = ipConfigurations;
            DscpConfiguration = dscpConfiguration;
            AuxiliaryMode = auxiliaryMode;
            AuxiliarySku = auxiliarySku;
        }

        /// <summary> The network interface configuration name. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the primary network interface in case the virtual machine has more than 1 network interface. </summary>
        public bool? Primary { get; set; }
        /// <summary> Specify what happens to the network interface when the VM is deleted. </summary>
        public ComputeDeleteOption? DeleteOption { get; set; }
        /// <summary> Specifies whether the network interface is accelerated networking-enabled. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
        /// <summary> Specifies whether the network interface is disabled for tcp state tracking. </summary>
        public bool? IsTcpStateTrackingDisabled { get; set; }
        /// <summary> Specifies whether the network interface is FPGA networking-enabled. </summary>
        public bool? EnableFpga { get; set; }
        /// <summary> Whether IP forwarding enabled on this NIC. </summary>
        public bool? EnableIPForwarding { get; set; }
        /// <summary> The network security group. </summary>
        internal WritableSubResource NetworkSecurityGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier NetworkSecurityGroupId
        {
            get => NetworkSecurityGroup is null ? default : NetworkSecurityGroup.Id;
            set
            {
                if (NetworkSecurityGroup is null)
                    NetworkSecurityGroup = new WritableSubResource();
                NetworkSecurityGroup.Id = value;
            }
        }

        /// <summary> The dns settings to be applied on the network interfaces. </summary>
        internal VirtualMachineNetworkInterfaceDnsSettingsConfiguration DnsSettings { get; set; }
        /// <summary> List of DNS servers IP addresses. </summary>
        public IList<string> DnsServers
        {
            get
            {
                if (DnsSettings is null)
                    DnsSettings = new VirtualMachineNetworkInterfaceDnsSettingsConfiguration();
                return DnsSettings.DnsServers;
            }
        }

        /// <summary> Specifies the IP configurations of the network interface. </summary>
        public IList<VirtualMachineNetworkInterfaceIPConfiguration> IPConfigurations { get; }
        /// <summary> Gets or sets the dscp configuration. </summary>
        internal WritableSubResource DscpConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DscpConfigurationId
        {
            get => DscpConfiguration is null ? default : DscpConfiguration.Id;
            set
            {
                if (DscpConfiguration is null)
                    DscpConfiguration = new WritableSubResource();
                DscpConfiguration.Id = value;
            }
        }

        /// <summary> Specifies whether the Auxiliary mode is enabled for the Network Interface resource. </summary>
        public ComputeNetworkInterfaceAuxiliaryMode? AuxiliaryMode { get; set; }
        /// <summary> Specifies whether the Auxiliary sku is enabled for the Network Interface resource. </summary>
        public ComputeNetworkInterfaceAuxiliarySku? AuxiliarySku { get; set; }
    }
}