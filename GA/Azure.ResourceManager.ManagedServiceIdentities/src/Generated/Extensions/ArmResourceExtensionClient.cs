// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    /// <summary> A class to add extension methods to ArmResource. </summary>
    internal partial class ArmResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ArmResourceExtensionClient"/> class for mocking. </summary>
        protected ArmResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArmResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ArmResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets an object representing a SystemAssignedIdentityResource along with the instance operations that can be performed on it in the ArmResource. </summary>
        /// <returns> Returns a <see cref="SystemAssignedIdentityResource" /> object. </returns>
        public virtual SystemAssignedIdentityResource GetSystemAssignedIdentity()
        {
            return new SystemAssignedIdentityResource(Client, Id.AppendProviderResource("Microsoft.ManagedIdentity", "identities", "default"));
        }
    }
}