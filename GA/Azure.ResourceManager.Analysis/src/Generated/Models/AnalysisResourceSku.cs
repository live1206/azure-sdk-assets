// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> Represents the SKU name and Azure pricing tier for Analysis Services resource. </summary>
    public partial class AnalysisResourceSku
    {
        /// <summary> Initializes a new instance of AnalysisResourceSku. </summary>
        /// <param name="name"> Name of the SKU level. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AnalysisResourceSku(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of AnalysisResourceSku. </summary>
        /// <param name="name"> Name of the SKU level. </param>
        /// <param name="tier"> The name of the Azure pricing tier to which the SKU applies. </param>
        /// <param name="capacity"> The number of instances in the read only query pool. </param>
        internal AnalysisResourceSku(string name, AnalysisSkuTier? tier, int? capacity)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
        }

        /// <summary> Name of the SKU level. </summary>
        public string Name { get; set; }
        /// <summary> The name of the Azure pricing tier to which the SKU applies. </summary>
        public AnalysisSkuTier? Tier { get; set; }
        /// <summary> The number of instances in the read only query pool. </summary>
        public int? Capacity { get; set; }
    }
}
