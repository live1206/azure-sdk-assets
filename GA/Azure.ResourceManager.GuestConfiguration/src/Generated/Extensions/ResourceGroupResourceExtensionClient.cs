// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics;
        private GuestConfigurationAssignmentsRestOperations _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient;

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

        private ClientDiagnostics GuestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics => _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", GuestConfigurationVmAssignmentResource.ResourceType.Namespace, Diagnostics);
        private GuestConfigurationAssignmentsRestOperations GuestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient => _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient ??= new GuestConfigurationAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(GuestConfigurationVmAssignmentResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }
    }
}