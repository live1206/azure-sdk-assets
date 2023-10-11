// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Collection of fabric details. </summary>
    internal partial class SiteRecoveryFabricListResult
    {
        /// <summary> Initializes a new instance of SiteRecoveryFabricListResult. </summary>
        internal SiteRecoveryFabricListResult()
        {
            Value = new ChangeTrackingList<SiteRecoveryFabricData>();
        }

        /// <summary> Initializes a new instance of SiteRecoveryFabricListResult. </summary>
        /// <param name="value"> The fabric details. </param>
        /// <param name="nextLink"> The value of next link. </param>
        internal SiteRecoveryFabricListResult(IReadOnlyList<SiteRecoveryFabricData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The fabric details. </summary>
        public IReadOnlyList<SiteRecoveryFabricData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}