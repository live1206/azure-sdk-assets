// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Data flow template. </summary>
    public partial class MobileNetworkServiceDataFlowTemplate
    {
        /// <summary> Initializes a new instance of MobileNetworkServiceDataFlowTemplate. </summary>
        /// <param name="templateName"> The name of the data flow template. This must be unique within the parent data flow policy rule. You must not use any of the following reserved strings - `default`, `requested` or `service`. </param>
        /// <param name="direction"> The direction of this flow. </param>
        /// <param name="protocol"> A list of the allowed protocol(s) for this flow. If you want this flow to be able to use any protocol within the internet protocol suite, use the value `ip`. If you only want to allow a selection of protocols, you must use the corresponding IANA Assigned Internet Protocol Number for each protocol, as described in https://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml. For example, for UDP, you must use 17. If you use the value `ip` then you must leave the field `port` unspecified. </param>
        /// <param name="remoteIPList"> The remote IP address(es) to which UEs will connect for this flow. If you want to allow connections on any IP address, use the value `any`. Otherwise, you must provide each of the remote IP addresses to which the packet core instance will connect for this flow. You must provide each IP address in CIDR notation, including the netmask (for example, 192.0.2.54/24). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateName"/>, <paramref name="protocol"/> or <paramref name="remoteIPList"/> is null. </exception>
        public MobileNetworkServiceDataFlowTemplate(string templateName, MobileNetworkSdfDirectionS direction, IEnumerable<string> protocol, IEnumerable<string> remoteIPList)
        {
            Argument.AssertNotNull(templateName, nameof(templateName));
            Argument.AssertNotNull(protocol, nameof(protocol));
            Argument.AssertNotNull(remoteIPList, nameof(remoteIPList));

            TemplateName = templateName;
            Direction = direction;
            Protocol = protocol.ToList();
            RemoteIPList = remoteIPList.ToList();
            Ports = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of MobileNetworkServiceDataFlowTemplate. </summary>
        /// <param name="templateName"> The name of the data flow template. This must be unique within the parent data flow policy rule. You must not use any of the following reserved strings - `default`, `requested` or `service`. </param>
        /// <param name="direction"> The direction of this flow. </param>
        /// <param name="protocol"> A list of the allowed protocol(s) for this flow. If you want this flow to be able to use any protocol within the internet protocol suite, use the value `ip`. If you only want to allow a selection of protocols, you must use the corresponding IANA Assigned Internet Protocol Number for each protocol, as described in https://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml. For example, for UDP, you must use 17. If you use the value `ip` then you must leave the field `port` unspecified. </param>
        /// <param name="remoteIPList"> The remote IP address(es) to which UEs will connect for this flow. If you want to allow connections on any IP address, use the value `any`. Otherwise, you must provide each of the remote IP addresses to which the packet core instance will connect for this flow. You must provide each IP address in CIDR notation, including the netmask (for example, 192.0.2.54/24). </param>
        /// <param name="ports"> The port(s) to which UEs will connect for this flow. You can specify zero or more ports or port ranges. If you specify one or more ports or port ranges then you must specify a value other than `ip` in the `protocol` field. This is an optional setting. If you do not specify it then connections will be allowed on all ports. Port ranges must be specified as &lt;FirstPort&gt;-&lt;LastPort&gt;. For example: [`8080`, `8082-8085`]. </param>
        internal MobileNetworkServiceDataFlowTemplate(string templateName, MobileNetworkSdfDirectionS direction, IList<string> protocol, IList<string> remoteIPList, IList<string> ports)
        {
            TemplateName = templateName;
            Direction = direction;
            Protocol = protocol;
            RemoteIPList = remoteIPList;
            Ports = ports;
        }

        /// <summary> The name of the data flow template. This must be unique within the parent data flow policy rule. You must not use any of the following reserved strings - `default`, `requested` or `service`. </summary>
        public string TemplateName { get; set; }
        /// <summary> The direction of this flow. </summary>
        public MobileNetworkSdfDirectionS Direction { get; set; }
        /// <summary> A list of the allowed protocol(s) for this flow. If you want this flow to be able to use any protocol within the internet protocol suite, use the value `ip`. If you only want to allow a selection of protocols, you must use the corresponding IANA Assigned Internet Protocol Number for each protocol, as described in https://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml. For example, for UDP, you must use 17. If you use the value `ip` then you must leave the field `port` unspecified. </summary>
        public IList<string> Protocol { get; }
        /// <summary> The remote IP address(es) to which UEs will connect for this flow. If you want to allow connections on any IP address, use the value `any`. Otherwise, you must provide each of the remote IP addresses to which the packet core instance will connect for this flow. You must provide each IP address in CIDR notation, including the netmask (for example, 192.0.2.54/24). </summary>
        public IList<string> RemoteIPList { get; }
        /// <summary> The port(s) to which UEs will connect for this flow. You can specify zero or more ports or port ranges. If you specify one or more ports or port ranges then you must specify a value other than `ip` in the `protocol` field. This is an optional setting. If you do not specify it then connections will be allowed on all ports. Port ranges must be specified as &lt;FirstPort&gt;-&lt;LastPort&gt;. For example: [`8080`, `8082-8085`]. </summary>
        public IList<string> Ports { get; }
    }
}