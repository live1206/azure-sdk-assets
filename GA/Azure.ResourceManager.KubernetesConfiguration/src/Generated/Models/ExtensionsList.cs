// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KubernetesConfiguration;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Result of the request to list Extensions.  It contains a list of Extension objects and a URL link to get the next set of results. </summary>
    internal partial class ExtensionsList
    {
        /// <summary> Initializes a new instance of ExtensionsList. </summary>
        internal ExtensionsList()
        {
            Value = new ChangeTrackingList<KubernetesClusterExtensionData>();
        }

        /// <summary> Initializes a new instance of ExtensionsList. </summary>
        /// <param name="value"> List of Extensions within a Kubernetes cluster. </param>
        /// <param name="nextLink"> URL to get the next set of extension objects, if any. </param>
        internal ExtensionsList(IReadOnlyList<KubernetesClusterExtensionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Extensions within a Kubernetes cluster. </summary>
        public IReadOnlyList<KubernetesClusterExtensionData> Value { get; }
        /// <summary> URL to get the next set of extension objects, if any. </summary>
        public string NextLink { get; }
    }
}