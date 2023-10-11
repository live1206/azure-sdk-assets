// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Automanage
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

        /// <summary> Gets a collection of AutomanageVmConfigurationProfileAssignmentResources in the ArmResource. </summary>
        /// <returns> An object representing collection of AutomanageVmConfigurationProfileAssignmentResources and their operations over a AutomanageVmConfigurationProfileAssignmentResource. </returns>
        public virtual AutomanageVmConfigurationProfileAssignmentCollection GetAutomanageVmConfigurationProfileAssignments()
        {
            return GetCachedClient(Client => new AutomanageVmConfigurationProfileAssignmentCollection(Client, Id));
        }

        /// <summary> Gets a collection of AutomanageHcrpConfigurationProfileAssignmentResources in the ArmResource. </summary>
        /// <returns> An object representing collection of AutomanageHcrpConfigurationProfileAssignmentResources and their operations over a AutomanageHcrpConfigurationProfileAssignmentResource. </returns>
        public virtual AutomanageHcrpConfigurationProfileAssignmentCollection GetAutomanageHcrpConfigurationProfileAssignments()
        {
            return GetCachedClient(Client => new AutomanageHcrpConfigurationProfileAssignmentCollection(Client, Id));
        }

        /// <summary> Gets a collection of AutomanageHciClusterConfigurationProfileAssignmentResources in the ArmResource. </summary>
        /// <returns> An object representing collection of AutomanageHciClusterConfigurationProfileAssignmentResources and their operations over a AutomanageHciClusterConfigurationProfileAssignmentResource. </returns>
        public virtual AutomanageHciClusterConfigurationProfileAssignmentCollection GetAutomanageHciClusterConfigurationProfileAssignments()
        {
            return GetCachedClient(Client => new AutomanageHciClusterConfigurationProfileAssignmentCollection(Client, Id));
        }
    }
}
