// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> List of HybridIdentityMetadata. </summary>
    internal partial class HybridIdentityMetadataList
    {
        /// <summary> Initializes a new instance of HybridIdentityMetadataList. </summary>
        /// <param name="value"> Array of HybridIdentityMetadata. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal HybridIdentityMetadataList(IEnumerable<HybridIdentityMetadataData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of HybridIdentityMetadataList. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of HybridIdentityMetadata. </param>
        /// <param name="value"> Array of HybridIdentityMetadata. </param>
        internal HybridIdentityMetadataList(string nextLink, IReadOnlyList<HybridIdentityMetadataData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Url to follow for getting next page of HybridIdentityMetadata. </summary>
        public string NextLink { get; }
        /// <summary> Array of HybridIdentityMetadata. </summary>
        public IReadOnlyList<HybridIdentityMetadataData> Value { get; }
    }
}
