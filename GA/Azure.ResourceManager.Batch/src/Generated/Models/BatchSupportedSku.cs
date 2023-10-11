// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Describes a Batch supported SKU. </summary>
    public partial class BatchSupportedSku
    {
        /// <summary> Initializes a new instance of BatchSupportedSku. </summary>
        internal BatchSupportedSku()
        {
            Capabilities = new ChangeTrackingList<BatchSkuCapability>();
        }

        /// <summary> Initializes a new instance of BatchSupportedSku. </summary>
        /// <param name="name"> The name of the SKU. </param>
        /// <param name="familyName"> The family name of the SKU. </param>
        /// <param name="capabilities"> A collection of capabilities which this SKU supports. </param>
        internal BatchSupportedSku(string name, string familyName, IReadOnlyList<BatchSkuCapability> capabilities)
        {
            Name = name;
            FamilyName = familyName;
            Capabilities = capabilities;
        }

        /// <summary> The name of the SKU. </summary>
        public string Name { get; }
        /// <summary> The family name of the SKU. </summary>
        public string FamilyName { get; }
        /// <summary> A collection of capabilities which this SKU supports. </summary>
        public IReadOnlyList<BatchSkuCapability> Capabilities { get; }
    }
}