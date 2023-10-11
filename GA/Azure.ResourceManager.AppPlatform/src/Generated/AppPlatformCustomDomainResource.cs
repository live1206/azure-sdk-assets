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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing an AppPlatformCustomDomain along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AppPlatformCustomDomainResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAppPlatformCustomDomainResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppPlatformAppResource" /> using the GetAppPlatformCustomDomain method.
    /// </summary>
    public partial class AppPlatformCustomDomainResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppPlatformCustomDomainResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string appName, string domainName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appPlatformCustomDomainCustomDomainsClientDiagnostics;
        private readonly CustomDomainsRestOperations _appPlatformCustomDomainCustomDomainsRestClient;
        private readonly AppPlatformCustomDomainData _data;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformCustomDomainResource"/> class for mocking. </summary>
        protected AppPlatformCustomDomainResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AppPlatformCustomDomainResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppPlatformCustomDomainResource(ArmClient client, AppPlatformCustomDomainData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformCustomDomainResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppPlatformCustomDomainResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformCustomDomainCustomDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appPlatformCustomDomainCustomDomainsApiVersion);
            _appPlatformCustomDomainCustomDomainsRestClient = new CustomDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformCustomDomainCustomDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/apps/domains";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppPlatformCustomDomainData Data
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
        /// Get the custom domain of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppPlatformCustomDomainResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainResource.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformCustomDomainCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the custom domain of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppPlatformCustomDomainResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainResource.Get");
            scope.Start();
            try
            {
                var response = _appPlatformCustomDomainCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the custom domain of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainResource.Delete");
            scope.Start();
            try
            {
                var response = await _appPlatformCustomDomainCustomDomainsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation(_appPlatformCustomDomainCustomDomainsClientDiagnostics, Pipeline, _appPlatformCustomDomainCustomDomainsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the custom domain of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainResource.Delete");
            scope.Start();
            try
            {
                var response = _appPlatformCustomDomainCustomDomainsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppPlatformArmOperation(_appPlatformCustomDomainCustomDomainsClientDiagnostics, Pipeline, _appPlatformCustomDomainCustomDomainsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update custom domain of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformCustomDomainResource>> UpdateAsync(WaitUntil waitUntil, AppPlatformCustomDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainResource.Update");
            scope.Start();
            try
            {
                var response = await _appPlatformCustomDomainCustomDomainsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformCustomDomainResource>(new AppPlatformCustomDomainOperationSource(Client), _appPlatformCustomDomainCustomDomainsClientDiagnostics, Pipeline, _appPlatformCustomDomainCustomDomainsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update custom domain of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformCustomDomainResource> Update(WaitUntil waitUntil, AppPlatformCustomDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainResource.Update");
            scope.Start();
            try
            {
                var response = _appPlatformCustomDomainCustomDomainsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformCustomDomainResource>(new AppPlatformCustomDomainOperationSource(Client), _appPlatformCustomDomainCustomDomainsClientDiagnostics, Pipeline, _appPlatformCustomDomainCustomDomainsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
