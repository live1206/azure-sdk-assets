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
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A Class representing a SphereCertificate along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SphereCertificateResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSphereCertificateResource method.
    /// Otherwise you can get one from its parent resource <see cref="SphereCatalogResource" /> using the GetSphereCertificate method.
    /// </summary>
    public partial class SphereCertificateResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SphereCertificateResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sphereCertificateCertificatesClientDiagnostics;
        private readonly CertificatesRestOperations _sphereCertificateCertificatesRestClient;
        private readonly SphereCertificateData _data;

        /// <summary> Initializes a new instance of the <see cref="SphereCertificateResource"/> class for mocking. </summary>
        protected SphereCertificateResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SphereCertificateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SphereCertificateResource(ArmClient client, SphereCertificateData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SphereCertificateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SphereCertificateResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sphereCertificateCertificatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sphere", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sphereCertificateCertificatesApiVersion);
            _sphereCertificateCertificatesRestClient = new CertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sphereCertificateCertificatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AzureSphere/catalogs/certificates";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SphereCertificateData Data
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
        /// Get a Certificate
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SphereCertificateResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sphereCertificateCertificatesClientDiagnostics.CreateScope("SphereCertificateResource.Get");
            scope.Start();
            try
            {
                var response = await _sphereCertificateCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Certificate
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SphereCertificateResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sphereCertificateCertificatesClientDiagnostics.CreateScope("SphereCertificateResource.Get");
            scope.Start();
            try
            {
                var response = _sphereCertificateCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves cert chain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}/retrieveCertChain</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_RetrieveCertChain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SphereCertificateChainResult>> RetrieveCertChainAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sphereCertificateCertificatesClientDiagnostics.CreateScope("SphereCertificateResource.RetrieveCertChain");
            scope.Start();
            try
            {
                var response = await _sphereCertificateCertificatesRestClient.RetrieveCertChainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves cert chain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}/retrieveCertChain</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_RetrieveCertChain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SphereCertificateChainResult> RetrieveCertChain(CancellationToken cancellationToken = default)
        {
            using var scope = _sphereCertificateCertificatesClientDiagnostics.CreateScope("SphereCertificateResource.RetrieveCertChain");
            scope.Start();
            try
            {
                var response = _sphereCertificateCertificatesRestClient.RetrieveCertChain(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the proof of possession nonce.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}/retrieveProofOfPossessionNonce</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_RetrieveProofOfPossessionNonce</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Proof of possession nonce request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<ProofOfPossessionNonceResponse>> RetrieveProofOfPossessionNonceAsync(ProofOfPossessionNonceContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _sphereCertificateCertificatesClientDiagnostics.CreateScope("SphereCertificateResource.RetrieveProofOfPossessionNonce");
            scope.Start();
            try
            {
                var response = await _sphereCertificateCertificatesRestClient.RetrieveProofOfPossessionNonceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the proof of possession nonce.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}/retrieveProofOfPossessionNonce</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_RetrieveProofOfPossessionNonce</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Proof of possession nonce request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<ProofOfPossessionNonceResponse> RetrieveProofOfPossessionNonce(ProofOfPossessionNonceContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _sphereCertificateCertificatesClientDiagnostics.CreateScope("SphereCertificateResource.RetrieveProofOfPossessionNonce");
            scope.Start();
            try
            {
                var response = _sphereCertificateCertificatesRestClient.RetrieveProofOfPossessionNonce(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
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