// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Create network mappings input. </summary>
    public partial class SiteRecoveryNetworkMappingCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of SiteRecoveryNetworkMappingCreateOrUpdateContent. </summary>
        /// <param name="properties"> Input properties for creating network mapping. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SiteRecoveryNetworkMappingCreateOrUpdateContent(SiteRecoveryCreateReplicationNetworkMappingProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Input properties for creating network mapping. </summary>
        public SiteRecoveryCreateReplicationNetworkMappingProperties Properties { get; }
    }
}