// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A Class representing a TenantResourceHealthEventImpactedResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TenantResourceHealthEventImpactedResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTenantResourceHealthEventImpactedResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResourceHealthEventResource" /> using the GetTenantResourceHealthEventImpactedResource method.
    /// </summary>
    public partial class TenantResourceHealthEventImpactedResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantResourceHealthEventImpactedResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string eventTrackingId, string impactedResourceName)
        {
            var resourceId = $"/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics;
        private readonly ImpactedResourcesRestOperations _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient;
        private readonly ResourceHealthEventImpactedResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceHealthEventImpactedResource"/> class for mocking. </summary>
        protected TenantResourceHealthEventImpactedResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantResourceHealthEventImpactedResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantResourceHealthEventImpactedResource(ArmClient client, ResourceHealthEventImpactedResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceHealthEventImpactedResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceHealthEventImpactedResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantResourceHealthEventImpactedResourceImpactedResourcesApiVersion);
            _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient = new ImpactedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantResourceHealthEventImpactedResourceImpactedResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ResourceHealth/events/impactedResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceHealthEventImpactedResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specific impacted resource in the tenant by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_GetByTenantId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantResourceHealthEventImpactedResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics.CreateScope("TenantResourceHealthEventImpactedResource.Get");
            scope.Start();
            try
            {
                var response = await _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient.GetByTenantIdAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantResourceHealthEventImpactedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specific impacted resource in the tenant by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_GetByTenantId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantResourceHealthEventImpactedResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics.CreateScope("TenantResourceHealthEventImpactedResource.Get");
            scope.Start();
            try
            {
                var response = _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient.GetByTenantId(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantResourceHealthEventImpactedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}