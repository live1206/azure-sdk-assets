// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> KubernetesClusterRestartNodeParameters represents the body of the request to restart the node of a Kubernetes cluster. </summary>
    public partial class KubernetesClusterRestartNodeContent
    {
        /// <summary> Initializes a new instance of KubernetesClusterRestartNodeContent. </summary>
        /// <param name="nodeName"> The name of the node to restart. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeName"/> is null. </exception>
        public KubernetesClusterRestartNodeContent(string nodeName)
        {
            Argument.AssertNotNull(nodeName, nameof(nodeName));

            NodeName = nodeName;
        }

        /// <summary> The name of the node to restart. </summary>
        public string NodeName { get; }
    }
}