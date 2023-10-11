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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A Class representing an AuthorizationProviderOperationsMetadata along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AuthorizationProviderOperationsMetadataResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAuthorizationProviderOperationsMetadataResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetAuthorizationProviderOperationsMetadata method.
    /// </summary>
    public partial class AuthorizationProviderOperationsMetadataResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AuthorizationProviderOperationsMetadataResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceProviderNamespace)
        {
            var resourceId = $"/providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics;
        private readonly ProviderOperationsMetadataRestOperations _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient;
        private readonly AuthorizationProviderOperationsMetadataData _data;

        /// <summary> Initializes a new instance of the <see cref="AuthorizationProviderOperationsMetadataResource"/> class for mocking. </summary>
        protected AuthorizationProviderOperationsMetadataResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AuthorizationProviderOperationsMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AuthorizationProviderOperationsMetadataResource(ArmClient client, AuthorizationProviderOperationsMetadataData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AuthorizationProviderOperationsMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AuthorizationProviderOperationsMetadataResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string authorizationProviderOperationsMetadataProviderOperationsMetadataApiVersion);
            _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient = new ProviderOperationsMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, authorizationProviderOperationsMetadataProviderOperationsMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/providerOperations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AuthorizationProviderOperationsMetadataData Data
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
        /// Gets provider operations metadata for the specified resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderOperationsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AuthorizationProviderOperationsMetadataResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics.CreateScope("AuthorizationProviderOperationsMetadataResource.Get");
            scope.Start();
            try
            {
                var response = await _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient.GetAsync(Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationProviderOperationsMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets provider operations metadata for the specified resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderOperationsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AuthorizationProviderOperationsMetadataResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics.CreateScope("AuthorizationProviderOperationsMetadataResource.Get");
            scope.Start();
            try
            {
                var response = _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient.Get(Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationProviderOperationsMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
