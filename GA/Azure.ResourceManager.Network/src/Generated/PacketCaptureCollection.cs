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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="PacketCaptureResource" /> and their operations.
    /// Each <see cref="PacketCaptureResource" /> in the collection will belong to the same instance of <see cref="NetworkWatcherResource" />.
    /// To get a <see cref="PacketCaptureCollection" /> instance call the GetPacketCaptures method from an instance of <see cref="NetworkWatcherResource" />.
    /// </summary>
    public partial class PacketCaptureCollection : ArmCollection, IEnumerable<PacketCaptureResource>, IAsyncEnumerable<PacketCaptureResource>
    {
        private readonly ClientDiagnostics _packetCaptureClientDiagnostics;
        private readonly PacketCapturesRestOperations _packetCaptureRestClient;

        /// <summary> Initializes a new instance of the <see cref="PacketCaptureCollection"/> class for mocking. </summary>
        protected PacketCaptureCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PacketCaptureCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PacketCaptureCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _packetCaptureClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PacketCaptureResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PacketCaptureResource.ResourceType, out string packetCaptureApiVersion);
            _packetCaptureRestClient = new PacketCapturesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, packetCaptureApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkWatcherResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkWatcherResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create and start a packet capture on the specified VM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="content"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<PacketCaptureResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string packetCaptureName, PacketCaptureCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _packetCaptureRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, content, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<PacketCaptureResource>(new PacketCaptureOperationSource(Client), _packetCaptureClientDiagnostics, Pipeline, _packetCaptureRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create and start a packet capture on the specified VM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="content"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<PacketCaptureResource> CreateOrUpdate(WaitUntil waitUntil, string packetCaptureName, PacketCaptureCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _packetCaptureRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, content, cancellationToken);
                var operation = new NetworkArmOperation<PacketCaptureResource>(new PacketCaptureOperationSource(Client), _packetCaptureClientDiagnostics, Pipeline, _packetCaptureRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a packet capture session by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public virtual async Task<Response<PacketCaptureResource>> GetAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.Get");
            scope.Start();
            try
            {
                var response = await _packetCaptureRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PacketCaptureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a packet capture session by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public virtual Response<PacketCaptureResource> Get(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.Get");
            scope.Start();
            try
            {
                var response = _packetCaptureRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PacketCaptureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all packet capture sessions within the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PacketCaptureResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PacketCaptureResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _packetCaptureRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new PacketCaptureResource(Client, PacketCaptureData.DeserializePacketCaptureData(e)), _packetCaptureClientDiagnostics, Pipeline, "PacketCaptureCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all packet capture sessions within the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PacketCaptureResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PacketCaptureResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _packetCaptureRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new PacketCaptureResource(Client, PacketCaptureData.DeserializePacketCaptureData(e)), _packetCaptureClientDiagnostics, Pipeline, "PacketCaptureCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.Exists");
            scope.Start();
            try
            {
                var response = await _packetCaptureRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public virtual Response<bool> Exists(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.Exists");
            scope.Start();
            try
            {
                var response = _packetCaptureRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PacketCaptureResource> IEnumerable<PacketCaptureResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PacketCaptureResource> IAsyncEnumerable<PacketCaptureResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}