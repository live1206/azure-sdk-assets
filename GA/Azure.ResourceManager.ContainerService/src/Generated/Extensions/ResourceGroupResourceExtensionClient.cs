// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ContainerServiceManagedClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerServiceManagedClusterResources and their operations over a ContainerServiceManagedClusterResource. </returns>
        public virtual ContainerServiceManagedClusterCollection GetContainerServiceManagedClusters()
        {
            return GetCachedClient(Client => new ContainerServiceManagedClusterCollection(Client, Id));
        }

        /// <summary> Gets a collection of AgentPoolSnapshotResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AgentPoolSnapshotResources and their operations over a AgentPoolSnapshotResource. </returns>
        public virtual AgentPoolSnapshotCollection GetAgentPoolSnapshots()
        {
            return GetCachedClient(Client => new AgentPoolSnapshotCollection(Client, Id));
        }

        /// <summary> Gets a collection of ManagedClusterSnapshotResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ManagedClusterSnapshotResources and their operations over a ManagedClusterSnapshotResource. </returns>
        public virtual ManagedClusterSnapshotCollection GetManagedClusterSnapshots()
        {
            return GetCachedClient(Client => new ManagedClusterSnapshotCollection(Client, Id));
        }

        /// <summary> Gets a collection of ContainerServiceFleetResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerServiceFleetResources and their operations over a ContainerServiceFleetResource. </returns>
        public virtual ContainerServiceFleetCollection GetContainerServiceFleets()
        {
            return GetCachedClient(Client => new ContainerServiceFleetCollection(Client, Id));
        }
    }
}