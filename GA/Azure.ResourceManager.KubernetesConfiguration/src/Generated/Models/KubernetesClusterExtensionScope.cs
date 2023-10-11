// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Scope of the extension. It can be either Cluster or Namespace; but not both. </summary>
    public partial class KubernetesClusterExtensionScope
    {
        /// <summary> Initializes a new instance of KubernetesClusterExtensionScope. </summary>
        public KubernetesClusterExtensionScope()
        {
        }

        /// <summary> Initializes a new instance of KubernetesClusterExtensionScope. </summary>
        /// <param name="cluster"> Specifies that the scope of the extension is Cluster. </param>
        /// <param name="namespace"> Specifies that the scope of the extension is Namespace. </param>
        internal KubernetesClusterExtensionScope(ScopeCluster cluster, ScopeNamespace @namespace)
        {
            Cluster = cluster;
            Namespace = @namespace;
        }

        /// <summary> Specifies that the scope of the extension is Cluster. </summary>
        internal ScopeCluster Cluster { get; set; }
        /// <summary> Namespace where the extension Release must be placed, for a Cluster scoped extension.  If this namespace does not exist, it will be created. </summary>
        public string ClusterReleaseNamespace
        {
            get => Cluster is null ? default : Cluster.ReleaseNamespace;
            set
            {
                if (Cluster is null)
                    Cluster = new ScopeCluster();
                Cluster.ReleaseNamespace = value;
            }
        }

        /// <summary> Specifies that the scope of the extension is Namespace. </summary>
        internal ScopeNamespace Namespace { get; set; }
        /// <summary> Namespace where the extension will be created for an Namespace scoped extension.  If this namespace does not exist, it will be created. </summary>
        public string TargetNamespace
        {
            get => Namespace is null ? default : Namespace.TargetNamespace;
            set
            {
                if (Namespace is null)
                    Namespace = new ScopeNamespace();
                Namespace.TargetNamespace = value;
            }
        }
    }
}
