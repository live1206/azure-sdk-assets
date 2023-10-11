// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of a network interface. </summary>
    public partial class DevTestLabNetworkInterface
    {
        /// <summary> Initializes a new instance of DevTestLabNetworkInterface. </summary>
        public DevTestLabNetworkInterface()
        {
        }

        /// <summary> Initializes a new instance of DevTestLabNetworkInterface. </summary>
        /// <param name="virtualNetworkId"> The resource ID of the virtual network. </param>
        /// <param name="subnetId"> The resource ID of the sub net. </param>
        /// <param name="publicIPAddressId"> The resource ID of the public IP address. </param>
        /// <param name="publicIPAddress"> The public IP address. </param>
        /// <param name="privateIPAddress"> The private IP address. </param>
        /// <param name="dnsName"> The DNS name. </param>
        /// <param name="rdpAuthority"> The RdpAuthority property is a server DNS host name or IP address followed by the service port number for RDP (Remote Desktop Protocol). </param>
        /// <param name="sshAuthority"> The SshAuthority property is a server DNS host name or IP address followed by the service port number for SSH. </param>
        /// <param name="sharedPublicIPAddressConfiguration"> The configuration for sharing a public IP address across multiple virtual machines. </param>
        internal DevTestLabNetworkInterface(ResourceIdentifier virtualNetworkId, ResourceIdentifier subnetId, ResourceIdentifier publicIPAddressId, string publicIPAddress, string privateIPAddress, string dnsName, string rdpAuthority, string sshAuthority, SharedPublicIPAddressConfiguration sharedPublicIPAddressConfiguration)
        {
            VirtualNetworkId = virtualNetworkId;
            SubnetId = subnetId;
            PublicIPAddressId = publicIPAddressId;
            PublicIPAddress = publicIPAddress;
            PrivateIPAddress = privateIPAddress;
            DnsName = dnsName;
            RdpAuthority = rdpAuthority;
            SshAuthority = sshAuthority;
            SharedPublicIPAddressConfiguration = sharedPublicIPAddressConfiguration;
        }

        /// <summary> The resource ID of the virtual network. </summary>
        public ResourceIdentifier VirtualNetworkId { get; set; }
        /// <summary> The resource ID of the sub net. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> The resource ID of the public IP address. </summary>
        public ResourceIdentifier PublicIPAddressId { get; set; }
        /// <summary> The public IP address. </summary>
        public string PublicIPAddress { get; set; }
        /// <summary> The private IP address. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The DNS name. </summary>
        public string DnsName { get; set; }
        /// <summary> The RdpAuthority property is a server DNS host name or IP address followed by the service port number for RDP (Remote Desktop Protocol). </summary>
        public string RdpAuthority { get; set; }
        /// <summary> The SshAuthority property is a server DNS host name or IP address followed by the service port number for SSH. </summary>
        public string SshAuthority { get; set; }
        /// <summary> The configuration for sharing a public IP address across multiple virtual machines. </summary>
        internal SharedPublicIPAddressConfiguration SharedPublicIPAddressConfiguration { get; set; }
        /// <summary> The incoming NAT rules. </summary>
        public IList<DevTestLabInboundNatRule> SharedPublicIPAddressInboundNatRules
        {
            get
            {
                if (SharedPublicIPAddressConfiguration is null)
                    SharedPublicIPAddressConfiguration = new SharedPublicIPAddressConfiguration();
                return SharedPublicIPAddressConfiguration.InboundNatRules;
            }
        }
    }
}