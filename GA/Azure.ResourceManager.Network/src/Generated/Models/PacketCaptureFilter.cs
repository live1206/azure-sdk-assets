// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Filter that is applied to packet capture request. Multiple filters can be applied. </summary>
    public partial class PacketCaptureFilter
    {
        /// <summary> Initializes a new instance of PacketCaptureFilter. </summary>
        public PacketCaptureFilter()
        {
        }

        /// <summary> Initializes a new instance of PacketCaptureFilter. </summary>
        /// <param name="protocol"> Protocol to be filtered on. </param>
        /// <param name="localIPAddress"> Local IP Address to be filtered on. Notation: "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5"? for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. </param>
        /// <param name="remoteIPAddress"> Local IP Address to be filtered on. Notation: "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. </param>
        /// <param name="localPort"> Local port to be filtered on. Notation: "80" for single port entry."80-85" for range. "80;443;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. </param>
        /// <param name="remotePort"> Remote port to be filtered on. Notation: "80" for single port entry."80-85" for range. "80;443;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. </param>
        internal PacketCaptureFilter(PcProtocol? protocol, string localIPAddress, string remoteIPAddress, string localPort, string remotePort)
        {
            Protocol = protocol;
            LocalIPAddress = localIPAddress;
            RemoteIPAddress = remoteIPAddress;
            LocalPort = localPort;
            RemotePort = remotePort;
        }

        /// <summary> Protocol to be filtered on. </summary>
        public PcProtocol? Protocol { get; set; }
        /// <summary> Local IP Address to be filtered on. Notation: "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5"? for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. </summary>
        public string LocalIPAddress { get; set; }
        /// <summary> Local IP Address to be filtered on. Notation: "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. </summary>
        public string RemoteIPAddress { get; set; }
        /// <summary> Local port to be filtered on. Notation: "80" for single port entry."80-85" for range. "80;443;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. </summary>
        public string LocalPort { get; set; }
        /// <summary> Remote port to be filtered on. Notation: "80" for single port entry."80-85" for range. "80;443;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. </summary>
        public string RemotePort { get; set; }
    }
}