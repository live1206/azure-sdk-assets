// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Object reference to a Kubernetes object on a cluster. </summary>
    public partial class KubernetesObjectReference
    {
        /// <summary> Initializes a new instance of KubernetesObjectReference. </summary>
        internal KubernetesObjectReference()
        {
        }

        /// <summary> Initializes a new instance of KubernetesObjectReference. </summary>
        /// <param name="name"> Name of the object. </param>
        /// <param name="namespace"> Namespace of the object. </param>
        internal KubernetesObjectReference(string name, string @namespace)
        {
            Name = name;
            Namespace = @namespace;
        }

        /// <summary> Name of the object. </summary>
        public string Name { get; }
        /// <summary> Namespace of the object. </summary>
        public string Namespace { get; }
    }
}
