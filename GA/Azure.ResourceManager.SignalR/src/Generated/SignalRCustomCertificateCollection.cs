// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SignalR
{
    /// <summary>
    /// A class representing a collection of <see cref="SignalRCustomCertificateResource" /> and their operations.
    /// Each <see cref="SignalRCustomCertificateResource" /> in the collection will belong to the same instance of <see cref="SignalRResource" />.
    /// To get a <see cref="SignalRCustomCertificateCollection" /> instance call the GetSignalRCustomCertificates method from an instance of <see cref="SignalRResource" />.
    /// </summary>
    public partial class SignalRCustomCertificateCollection : ArmCollection, IEnumerable<SignalRCustomCertificateResource>, IAsyncEnumerable<SignalRCustomCertificateResource>
    {
        private readonly ClientDiagnostics _signalRCustomCertificateClientDiagnostics;
        private readonly SignalRCustomCertificatesRestOperations _signalRCustomCertificateRestClient;

        /// <summary> Initializes a new instance of the <see cref="SignalRCustomCertificateCollection"/> class for mocking. </summary>
        protected SignalRCustomCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SignalRCustomCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SignalRCustomCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _signalRCustomCertificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SignalR", SignalRCustomCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SignalRCustomCertificateResource.ResourceType, out string signalRCustomCertificateApiVersion);
            _signalRCustomCertificateRestClient = new SignalRCustomCertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, signalRCustomCertificateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SignalRResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SignalRResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a custom certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/customCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRCustomCertificates_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> Custom certificate name. </param>
        /// <param name="data"> The SignalRCustomCertificate to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SignalRCustomCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateName, SignalRCustomCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _signalRCustomCertificateClientDiagnostics.CreateScope("SignalRCustomCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _signalRCustomCertificateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SignalRArmOperation<SignalRCustomCertificateResource>(new SignalRCustomCertificateOperationSource(Client), _signalRCustomCertificateClientDiagnostics, Pipeline, _signalRCustomCertificateRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a custom certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/customCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRCustomCertificates_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> Custom certificate name. </param>
        /// <param name="data"> The SignalRCustomCertificate to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SignalRCustomCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string certificateName, SignalRCustomCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _signalRCustomCertificateClientDiagnostics.CreateScope("SignalRCustomCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _signalRCustomCertificateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, cancellationToken);
                var operation = new SignalRArmOperation<SignalRCustomCertificateResource>(new SignalRCustomCertificateOperationSource(Client), _signalRCustomCertificateClientDiagnostics, Pipeline, _signalRCustomCertificateRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a custom certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/customCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRCustomCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Custom certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<SignalRCustomCertificateResource>> GetAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _signalRCustomCertificateClientDiagnostics.CreateScope("SignalRCustomCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _signalRCustomCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SignalRCustomCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a custom certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/customCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRCustomCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Custom certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<SignalRCustomCertificateResource> Get(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _signalRCustomCertificateClientDiagnostics.CreateScope("SignalRCustomCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _signalRCustomCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SignalRCustomCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all custom certificates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/customCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRCustomCertificates_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SignalRCustomCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SignalRCustomCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _signalRCustomCertificateRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _signalRCustomCertificateRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SignalRCustomCertificateResource(Client, SignalRCustomCertificateData.DeserializeSignalRCustomCertificateData(e)), _signalRCustomCertificateClientDiagnostics, Pipeline, "SignalRCustomCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all custom certificates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/customCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRCustomCertificates_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SignalRCustomCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SignalRCustomCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _signalRCustomCertificateRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _signalRCustomCertificateRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SignalRCustomCertificateResource(Client, SignalRCustomCertificateData.DeserializeSignalRCustomCertificateData(e)), _signalRCustomCertificateClientDiagnostics, Pipeline, "SignalRCustomCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/customCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRCustomCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Custom certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _signalRCustomCertificateClientDiagnostics.CreateScope("SignalRCustomCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _signalRCustomCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/customCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRCustomCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Custom certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _signalRCustomCertificateClientDiagnostics.CreateScope("SignalRCustomCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _signalRCustomCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SignalRCustomCertificateResource> IEnumerable<SignalRCustomCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SignalRCustomCertificateResource> IAsyncEnumerable<SignalRCustomCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}