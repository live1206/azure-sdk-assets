// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceLinker
{
    /// <summary>
    /// A class representing a collection of <see cref="LinkerResource" /> and their operations.
    /// Each <see cref="LinkerResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="LinkerResourceCollection" /> instance call the GetLinkerResources method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class LinkerResourceCollection : ArmCollection, IEnumerable<LinkerResource>, IAsyncEnumerable<LinkerResource>
    {
        private readonly ClientDiagnostics _linkerResourceLinkerClientDiagnostics;
        private readonly LinkerRestOperations _linkerResourceLinkerRestClient;

        /// <summary> Initializes a new instance of the <see cref="LinkerResourceCollection"/> class for mocking. </summary>
        protected LinkerResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LinkerResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LinkerResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _linkerResourceLinkerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceLinker", LinkerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LinkerResource.ResourceType, out string linkerResourceLinkerApiVersion);
            _linkerResourceLinkerRestClient = new LinkerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, linkerResourceLinkerApiVersion);
        }

        /// <summary>
        /// Create or update linker resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="data"> Linker details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LinkerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string linkerName, LinkerResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkerName, nameof(linkerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _linkerResourceLinkerRestClient.CreateOrUpdateAsync(Id, linkerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceLinkerArmOperation<LinkerResource>(new LinkerResourceOperationSource(Client), _linkerResourceLinkerClientDiagnostics, Pipeline, _linkerResourceLinkerRestClient.CreateCreateOrUpdateRequest(Id, linkerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update linker resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="data"> Linker details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LinkerResource> CreateOrUpdate(WaitUntil waitUntil, string linkerName, LinkerResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkerName, nameof(linkerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _linkerResourceLinkerRestClient.CreateOrUpdate(Id, linkerName, data, cancellationToken);
                var operation = new ServiceLinkerArmOperation<LinkerResource>(new LinkerResourceOperationSource(Client), _linkerResourceLinkerClientDiagnostics, Pipeline, _linkerResourceLinkerRestClient.CreateCreateOrUpdateRequest(Id, linkerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns Linker resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkerName"/> is null. </exception>
        public virtual async Task<Response<LinkerResource>> GetAsync(string linkerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkerName, nameof(linkerName));

            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _linkerResourceLinkerRestClient.GetAsync(Id, linkerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LinkerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns Linker resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkerName"/> is null. </exception>
        public virtual Response<LinkerResource> Get(string linkerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkerName, nameof(linkerName));

            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _linkerResourceLinkerRestClient.Get(Id, linkerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LinkerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns list of Linkers which connects to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LinkerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LinkerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _linkerResourceLinkerRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _linkerResourceLinkerRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LinkerResource(Client, LinkerResourceData.DeserializeLinkerResourceData(e)), _linkerResourceLinkerClientDiagnostics, Pipeline, "LinkerResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of Linkers which connects to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LinkerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LinkerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _linkerResourceLinkerRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _linkerResourceLinkerRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LinkerResource(Client, LinkerResourceData.DeserializeLinkerResourceData(e)), _linkerResourceLinkerClientDiagnostics, Pipeline, "LinkerResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string linkerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkerName, nameof(linkerName));

            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _linkerResourceLinkerRestClient.GetAsync(Id, linkerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkerName"/> is null. </exception>
        public virtual Response<bool> Exists(string linkerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkerName, nameof(linkerName));

            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _linkerResourceLinkerRestClient.Get(Id, linkerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LinkerResource> IEnumerable<LinkerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LinkerResource> IAsyncEnumerable<LinkerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}