// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The network endpoint. </summary>
    public partial class IntegrationServiceEnvironmentNetworkEndpoint
    {
        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentNetworkEndpoint. </summary>
        internal IntegrationServiceEnvironmentNetworkEndpoint()
        {
            Ports = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentNetworkEndpoint. </summary>
        /// <param name="accessibility"> The accessibility state. </param>
        /// <param name="domainName"> The domain name. </param>
        /// <param name="ports"> The ports. </param>
        internal IntegrationServiceEnvironmentNetworkEndpoint(IntegrationServiceEnvironmentNetworkEndPointAccessibilityState? accessibility, string domainName, IReadOnlyList<string> ports)
        {
            Accessibility = accessibility;
            DomainName = domainName;
            Ports = ports;
        }

        /// <summary> The accessibility state. </summary>
        public IntegrationServiceEnvironmentNetworkEndPointAccessibilityState? Accessibility { get; }
        /// <summary> The domain name. </summary>
        public string DomainName { get; }
        /// <summary> The ports. </summary>
        public IReadOnlyList<string> Ports { get; }
    }
}