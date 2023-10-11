// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List namespace topics operation. </summary>
    internal partial class NamespaceTopicsListResult
    {
        /// <summary> Initializes a new instance of NamespaceTopicsListResult. </summary>
        internal NamespaceTopicsListResult()
        {
            Value = new ChangeTrackingList<NamespaceTopicData>();
        }

        /// <summary> Initializes a new instance of NamespaceTopicsListResult. </summary>
        /// <param name="value"> A collection of namespace topics. </param>
        /// <param name="nextLink"> A link for the next page of namespace topics. </param>
        internal NamespaceTopicsListResult(IReadOnlyList<NamespaceTopicData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of namespace topics. </summary>
        public IReadOnlyList<NamespaceTopicData> Value { get; }
        /// <summary> A link for the next page of namespace topics. </summary>
        public string NextLink { get; }
    }
}