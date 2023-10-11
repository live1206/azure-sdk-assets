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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedInstanceServerConfigurationOption along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ManagedInstanceServerConfigurationOptionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetManagedInstanceServerConfigurationOptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedInstanceResource" /> using the GetManagedInstanceServerConfigurationOption method.
    /// </summary>
    public partial class ManagedInstanceServerConfigurationOptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstanceServerConfigurationOptionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, ManagedInstanceServerConfigurationOptionName serverConfigurationOptionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics;
        private readonly ServerConfigurationOptionsRestOperations _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient;
        private readonly ManagedInstanceServerConfigurationOptionData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceServerConfigurationOptionResource"/> class for mocking. </summary>
        protected ManagedInstanceServerConfigurationOptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceServerConfigurationOptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstanceServerConfigurationOptionResource(ArmClient client, ManagedInstanceServerConfigurationOptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceServerConfigurationOptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceServerConfigurationOptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedInstanceServerConfigurationOptionServerConfigurationOptionsApiVersion);
            _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient = new ServerConfigurationOptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceServerConfigurationOptionServerConfigurationOptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/serverConfigurationOptions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedInstanceServerConfigurationOptionData Data
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
        /// Gets managed instance server configuration option.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceServerConfigurationOptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionResource.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceServerConfigurationOptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets managed instance server configuration option.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceServerConfigurationOptionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionResource.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceServerConfigurationOptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates managed instance server configuration option.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Server configuration option parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstanceServerConfigurationOptionResource>> UpdateAsync(WaitUntil waitUntil, ManagedInstanceServerConfigurationOptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionResource.Update");
            scope.Start();
            try
            {
                var response = await _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceServerConfigurationOptionResource>(new ManagedInstanceServerConfigurationOptionOperationSource(Client), _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics, Pipeline, _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates managed instance server configuration option.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Server configuration option parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceServerConfigurationOptionResource> Update(WaitUntil waitUntil, ManagedInstanceServerConfigurationOptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionResource.Update");
            scope.Start();
            try
            {
                var response = _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceServerConfigurationOptionResource>(new ManagedInstanceServerConfigurationOptionOperationSource(Client), _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics, Pipeline, _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}