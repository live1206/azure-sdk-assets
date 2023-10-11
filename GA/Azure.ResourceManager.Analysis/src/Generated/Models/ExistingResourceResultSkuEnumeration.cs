// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> An object that represents enumerating SKUs for existing resources. </summary>
    internal partial class ExistingResourceResultSkuEnumeration
    {
        /// <summary> Initializes a new instance of ExistingResourceResultSkuEnumeration. </summary>
        internal ExistingResourceResultSkuEnumeration()
        {
            Value = new ChangeTrackingList<AnalysisExistingSku>();
        }

        /// <summary> Initializes a new instance of ExistingResourceResultSkuEnumeration. </summary>
        /// <param name="value"> The collection of available SKUs for existing resources. </param>
        internal ExistingResourceResultSkuEnumeration(IReadOnlyList<AnalysisExistingSku> value)
        {
            Value = value;
        }

        /// <summary> The collection of available SKUs for existing resources. </summary>
        public IReadOnlyList<AnalysisExistingSku> Value { get; }
    }
}