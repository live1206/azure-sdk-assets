// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Parameters to reconcile to the GitRepository source kind type. </summary>
    public partial class KubernetesGitRepository
    {
        /// <summary> Initializes a new instance of KubernetesGitRepository. </summary>
        public KubernetesGitRepository()
        {
        }

        /// <summary> Initializes a new instance of KubernetesGitRepository. </summary>
        /// <param name="uri"> The URL to sync for the flux configuration git repository. </param>
        /// <param name="timeoutInSeconds"> The maximum time to attempt to reconcile the cluster git repository source with the remote. </param>
        /// <param name="syncIntervalInSeconds"> The interval at which to re-reconcile the cluster git repository source with the remote. </param>
        /// <param name="repositoryRef"> The source reference for the GitRepository object. </param>
        /// <param name="sshKnownHosts"> Base64-encoded known_hosts value containing public SSH keys required to access private git repositories over SSH. </param>
        /// <param name="httpsUser"> Plaintext HTTPS username used to access private git repositories over HTTPS. </param>
        /// <param name="httpsCACert"> Base64-encoded HTTPS certificate authority contents used to access git private git repositories over HTTPS. </param>
        /// <param name="localAuthRef"> Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided configuration secrets. </param>
        internal KubernetesGitRepository(Uri uri, long? timeoutInSeconds, long? syncIntervalInSeconds, KubernetesGitRepositoryRef repositoryRef, string sshKnownHosts, string httpsUser, string httpsCACert, string localAuthRef)
        {
            Uri = uri;
            TimeoutInSeconds = timeoutInSeconds;
            SyncIntervalInSeconds = syncIntervalInSeconds;
            RepositoryRef = repositoryRef;
            SshKnownHosts = sshKnownHosts;
            HttpsUser = httpsUser;
            HttpsCACert = httpsCACert;
            LocalAuthRef = localAuthRef;
        }

        /// <summary> The URL to sync for the flux configuration git repository. </summary>
        public Uri Uri { get; set; }
        /// <summary> The maximum time to attempt to reconcile the cluster git repository source with the remote. </summary>
        public long? TimeoutInSeconds { get; set; }
        /// <summary> The interval at which to re-reconcile the cluster git repository source with the remote. </summary>
        public long? SyncIntervalInSeconds { get; set; }
        /// <summary> The source reference for the GitRepository object. </summary>
        public KubernetesGitRepositoryRef RepositoryRef { get; set; }
        /// <summary> Base64-encoded known_hosts value containing public SSH keys required to access private git repositories over SSH. </summary>
        public string SshKnownHosts { get; set; }
        /// <summary> Plaintext HTTPS username used to access private git repositories over HTTPS. </summary>
        public string HttpsUser { get; set; }
        /// <summary> Base64-encoded HTTPS certificate authority contents used to access git private git repositories over HTTPS. </summary>
        public string HttpsCACert { get; set; }
        /// <summary> Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided configuration secrets. </summary>
        public string LocalAuthRef { get; set; }
    }
}
