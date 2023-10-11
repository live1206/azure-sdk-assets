// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The DiagnoseVirtualNetworkResult. </summary>
    public partial class DiagnoseVirtualNetworkResult
    {
        /// <summary> Initializes a new instance of DiagnoseVirtualNetworkResult. </summary>
        internal DiagnoseVirtualNetworkResult()
        {
            Findings = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DiagnoseVirtualNetworkResult. </summary>
        /// <param name="findings"> The list of network connectivity diagnostic finding. </param>
        internal DiagnoseVirtualNetworkResult(IReadOnlyList<string> findings)
        {
            Findings = findings;
        }

        /// <summary> The list of network connectivity diagnostic finding. </summary>
        public IReadOnlyList<string> Findings { get; }
    }
}