// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> An object that represents SKU details for existing resources. </summary>
    public partial class AnalysisExistingSku
    {
        /// <summary> Initializes a new instance of AnalysisExistingSku. </summary>
        internal AnalysisExistingSku()
        {
        }

        /// <summary> Initializes a new instance of AnalysisExistingSku. </summary>
        /// <param name="sku"> The SKU in SKU details for existing resources. </param>
        /// <param name="resourceType"> The resource type. </param>
        internal AnalysisExistingSku(AnalysisResourceSku sku, ResourceType? resourceType)
        {
            Sku = sku;
            ResourceType = resourceType;
        }

        /// <summary> The SKU in SKU details for existing resources. </summary>
        public AnalysisResourceSku Sku { get; }
        /// <summary> The resource type. </summary>
        public ResourceType? ResourceType { get; }
    }
}