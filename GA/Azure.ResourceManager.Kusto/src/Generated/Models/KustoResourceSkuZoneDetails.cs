// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Describes The zonal capabilities of a SKU. </summary>
    public partial class KustoResourceSkuZoneDetails
    {
        /// <summary> Initializes a new instance of KustoResourceSkuZoneDetails. </summary>
        internal KustoResourceSkuZoneDetails()
        {
            Name = new ChangeTrackingList<string>();
            Capabilities = new ChangeTrackingList<KustoResourceSkuCapabilities>();
        }

        /// <summary> Initializes a new instance of KustoResourceSkuZoneDetails. </summary>
        /// <param name="name"> The set of zones that the SKU is available in with the specified capabilities. </param>
        /// <param name="capabilities"> A list of capabilities that are available for the SKU in the specified list of zones. </param>
        internal KustoResourceSkuZoneDetails(IReadOnlyList<string> name, IReadOnlyList<KustoResourceSkuCapabilities> capabilities)
        {
            Name = name;
            Capabilities = capabilities;
        }

        /// <summary> The set of zones that the SKU is available in with the specified capabilities. </summary>
        public IReadOnlyList<string> Name { get; }
        /// <summary> A list of capabilities that are available for the SKU in the specified list of zones. </summary>
        public IReadOnlyList<KustoResourceSkuCapabilities> Capabilities { get; }
    }
}