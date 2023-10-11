// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Parameters to reconcile to the AzureBlob source kind type. </summary>
    public partial class KubernetesAzureBlobUpdateContent
    {
        /// <summary> Initializes a new instance of KubernetesAzureBlobUpdateContent. </summary>
        public KubernetesAzureBlobUpdateContent()
        {
        }

        /// <summary> The URL to sync for the flux configuration Azure Blob storage account. </summary>
        public Uri Uri { get; set; }
        /// <summary> The Azure Blob container name to sync from the url endpoint for the flux configuration. </summary>
        public string ContainerName { get; set; }
        /// <summary> The maximum time to attempt to reconcile the cluster Azure Blob source with the remote. </summary>
        public long? TimeoutInSeconds { get; set; }
        /// <summary> The interval at which to re-reconcile the cluster Azure Blob source with the remote. </summary>
        public long? SyncIntervalInSeconds { get; set; }
        /// <summary> Parameters to authenticate using Service Principal. </summary>
        public KubernetesServicePrincipalUpdateContent ServicePrincipal { get; set; }
        /// <summary> The account key (shared key) to access the storage account. </summary>
        public string AccountKey { get; set; }
        /// <summary> The Shared Access token to access the storage container. </summary>
        public string SasToken { get; set; }
        /// <summary> Parameters to authenticate using a Managed Identity. </summary>
        internal KubernetesAzureBlobManagedIdentityUpdateContent ManagedIdentity { get; set; }
        /// <summary> The client Id for authenticating a Managed Identity. </summary>
        public string ManagedIdentityClientId
        {
            get => ManagedIdentity is null ? default : ManagedIdentity.ClientId;
            set
            {
                if (ManagedIdentity is null)
                    ManagedIdentity = new KubernetesAzureBlobManagedIdentityUpdateContent();
                ManagedIdentity.ClientId = value;
            }
        }

        /// <summary> Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided configuration secrets. </summary>
        public string LocalAuthRef { get; set; }
    }
}
