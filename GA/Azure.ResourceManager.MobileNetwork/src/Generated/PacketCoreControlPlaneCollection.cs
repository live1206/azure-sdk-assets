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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="PacketCoreControlPlaneResource" /> and their operations.
    /// Each <see cref="PacketCoreControlPlaneResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="PacketCoreControlPlaneCollection" /> instance call the GetPacketCoreControlPlanes method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class PacketCoreControlPlaneCollection : ArmCollection, IEnumerable<PacketCoreControlPlaneResource>, IAsyncEnumerable<PacketCoreControlPlaneResource>
    {
        private readonly ClientDiagnostics _packetCoreControlPlaneClientDiagnostics;
        private readonly PacketCoreControlPlanesRestOperations _packetCoreControlPlaneRestClient;

        /// <summary> Initializes a new instance of the <see cref="PacketCoreControlPlaneCollection"/> class for mocking. </summary>
        protected PacketCoreControlPlaneCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PacketCoreControlPlaneCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PacketCoreControlPlaneCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _packetCoreControlPlaneClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", PacketCoreControlPlaneResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PacketCoreControlPlaneResource.ResourceType, out string packetCoreControlPlaneApiVersion);
            _packetCoreControlPlaneRestClient = new PacketCoreControlPlanesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, packetCoreControlPlaneApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a packet core control plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="data"> Parameters supplied to the create or update packet core control plane operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreControlPlaneName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PacketCoreControlPlaneResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string packetCoreControlPlaneName, PacketCoreControlPlaneData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _packetCoreControlPlaneClientDiagnostics.CreateScope("PacketCoreControlPlaneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _packetCoreControlPlaneRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, packetCoreControlPlaneName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<PacketCoreControlPlaneResource>(new PacketCoreControlPlaneOperationSource(Client), _packetCoreControlPlaneClientDiagnostics, Pipeline, _packetCoreControlPlaneRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, packetCoreControlPlaneName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a packet core control plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="data"> Parameters supplied to the create or update packet core control plane operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreControlPlaneName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PacketCoreControlPlaneResource> CreateOrUpdate(WaitUntil waitUntil, string packetCoreControlPlaneName, PacketCoreControlPlaneData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _packetCoreControlPlaneClientDiagnostics.CreateScope("PacketCoreControlPlaneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _packetCoreControlPlaneRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, packetCoreControlPlaneName, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<PacketCoreControlPlaneResource>(new PacketCoreControlPlaneOperationSource(Client), _packetCoreControlPlaneClientDiagnostics, Pipeline, _packetCoreControlPlaneRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, packetCoreControlPlaneName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified packet core control plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        public virtual async Task<Response<PacketCoreControlPlaneResource>> GetAsync(string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var scope = _packetCoreControlPlaneClientDiagnostics.CreateScope("PacketCoreControlPlaneCollection.Get");
            scope.Start();
            try
            {
                var response = await _packetCoreControlPlaneRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, packetCoreControlPlaneName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PacketCoreControlPlaneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified packet core control plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        public virtual Response<PacketCoreControlPlaneResource> Get(string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var scope = _packetCoreControlPlaneClientDiagnostics.CreateScope("PacketCoreControlPlaneCollection.Get");
            scope.Start();
            try
            {
                var response = _packetCoreControlPlaneRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, packetCoreControlPlaneName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PacketCoreControlPlaneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the packet core control planes in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PacketCoreControlPlaneResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PacketCoreControlPlaneResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _packetCoreControlPlaneRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _packetCoreControlPlaneRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PacketCoreControlPlaneResource(Client, PacketCoreControlPlaneData.DeserializePacketCoreControlPlaneData(e)), _packetCoreControlPlaneClientDiagnostics, Pipeline, "PacketCoreControlPlaneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the packet core control planes in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PacketCoreControlPlaneResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PacketCoreControlPlaneResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _packetCoreControlPlaneRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _packetCoreControlPlaneRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PacketCoreControlPlaneResource(Client, PacketCoreControlPlaneData.DeserializePacketCoreControlPlaneData(e)), _packetCoreControlPlaneClientDiagnostics, Pipeline, "PacketCoreControlPlaneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var scope = _packetCoreControlPlaneClientDiagnostics.CreateScope("PacketCoreControlPlaneCollection.Exists");
            scope.Start();
            try
            {
                var response = await _packetCoreControlPlaneRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, packetCoreControlPlaneName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        public virtual Response<bool> Exists(string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var scope = _packetCoreControlPlaneClientDiagnostics.CreateScope("PacketCoreControlPlaneCollection.Exists");
            scope.Start();
            try
            {
                var response = _packetCoreControlPlaneRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, packetCoreControlPlaneName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PacketCoreControlPlaneResource> IEnumerable<PacketCoreControlPlaneResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PacketCoreControlPlaneResource> IAsyncEnumerable<PacketCoreControlPlaneResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}