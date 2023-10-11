// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Describes The SKU capabilities object. </summary>
    public partial class KustoResourceSkuCapabilities
    {
        /// <summary> Initializes a new instance of KustoResourceSkuCapabilities. </summary>
        internal KustoResourceSkuCapabilities()
        {
        }

        /// <summary> Initializes a new instance of KustoResourceSkuCapabilities. </summary>
        /// <param name="name"> An invariant to describe the feature. </param>
        /// <param name="value"> An invariant if the feature is measured by quantity. </param>
        internal KustoResourceSkuCapabilities(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> An invariant to describe the feature. </summary>
        public string Name { get; }
        /// <summary> An invariant if the feature is measured by quantity. </summary>
        public string Value { get; }
    }
}