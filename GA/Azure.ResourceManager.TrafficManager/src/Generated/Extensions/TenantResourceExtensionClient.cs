// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _trafficManagerProfileProfilesClientDiagnostics;
        private ProfilesRestOperations _trafficManagerProfileProfilesRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class for mocking. </summary>
        protected TenantResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics TrafficManagerProfileProfilesClientDiagnostics => _trafficManagerProfileProfilesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.TrafficManager", TrafficManagerProfileResource.ResourceType.Namespace, Diagnostics);
        private ProfilesRestOperations TrafficManagerProfileProfilesRestClient => _trafficManagerProfileProfilesRestClient ??= new ProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(TrafficManagerProfileResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets an object representing a TrafficManagerGeographicHierarchyResource along with the instance operations that can be performed on it in the TenantResource. </summary>
        /// <returns> Returns a <see cref="TrafficManagerGeographicHierarchyResource" /> object. </returns>
        public virtual TrafficManagerGeographicHierarchyResource GetTrafficManagerGeographicHierarchy()
        {
            return new TrafficManagerGeographicHierarchyResource(Client, Id.AppendProviderResource("Microsoft.Network", "trafficManagerGeographicHierarchies", "default"));
        }

        /// <summary>
        /// Checks the availability of a Traffic Manager Relative DNS name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Network/checkTrafficManagerNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CheckTrafficManagerRelativeDnsNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The Traffic Manager name parameters supplied to the CheckTrafficManagerNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TrafficManagerNameAvailabilityResult>> CheckTrafficManagerRelativeDnsNameAvailabilityAsync(TrafficManagerRelativeDnsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = TrafficManagerProfileProfilesClientDiagnostics.CreateScope("TenantResourceExtensionClient.CheckTrafficManagerRelativeDnsNameAvailability");
            scope.Start();
            try
            {
                var response = await TrafficManagerProfileProfilesRestClient.CheckTrafficManagerRelativeDnsNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks the availability of a Traffic Manager Relative DNS name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Network/checkTrafficManagerNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CheckTrafficManagerRelativeDnsNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The Traffic Manager name parameters supplied to the CheckTrafficManagerNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TrafficManagerNameAvailabilityResult> CheckTrafficManagerRelativeDnsNameAvailability(TrafficManagerRelativeDnsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = TrafficManagerProfileProfilesClientDiagnostics.CreateScope("TenantResourceExtensionClient.CheckTrafficManagerRelativeDnsNameAvailability");
            scope.Start();
            try
            {
                var response = TrafficManagerProfileProfilesRestClient.CheckTrafficManagerRelativeDnsNameAvailability(content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}