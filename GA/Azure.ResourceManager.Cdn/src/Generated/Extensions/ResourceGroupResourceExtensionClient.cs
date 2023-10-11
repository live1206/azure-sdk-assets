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
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private CdnManagementRestOperations _defaultRestClient;

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

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CdnManagementRestOperations DefaultRestClient => _defaultRestClient ??= new CdnManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ProfileResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ProfileResources and their operations over a ProfileResource. </returns>
        public virtual ProfileCollection GetProfiles()
        {
            return GetCachedClient(Client => new ProfileCollection(Client, Id));
        }

        /// <summary> Gets a collection of CdnWebApplicationFirewallPolicyResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of CdnWebApplicationFirewallPolicyResources and their operations over a CdnWebApplicationFirewallPolicyResource. </returns>
        public virtual CdnWebApplicationFirewallPolicyCollection GetCdnWebApplicationFirewallPolicies()
        {
            return GetCachedClient(Client => new CdnWebApplicationFirewallPolicyCollection(Client, Id));
        }

        /// <summary>
        /// Check the availability of a resource name. This is needed for resources where name is globally unique, such as a afdx endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/checkEndpointNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckEndpointNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EndpointNameAvailabilityResult>> CheckEndpointNameAvailabilityAsync(EndpointNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CheckEndpointNameAvailability");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckEndpointNameAvailabilityAsync(Id.SubscriptionId, Id.ResourceGroupName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This is needed for resources where name is globally unique, such as a afdx endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/checkEndpointNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckEndpointNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EndpointNameAvailabilityResult> CheckEndpointNameAvailability(EndpointNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CheckEndpointNameAvailability");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckEndpointNameAvailability(Id.SubscriptionId, Id.ResourceGroupName, content, cancellationToken);
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
