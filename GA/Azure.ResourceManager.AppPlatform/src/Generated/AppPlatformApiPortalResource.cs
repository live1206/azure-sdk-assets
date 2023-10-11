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
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing an AppPlatformApiPortal along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AppPlatformApiPortalResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAppPlatformApiPortalResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppPlatformServiceResource" /> using the GetAppPlatformApiPortal method.
    /// </summary>
    public partial class AppPlatformApiPortalResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppPlatformApiPortalResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiPortalName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appPlatformApiPortalApiPortalsClientDiagnostics;
        private readonly ApiPortalsRestOperations _appPlatformApiPortalApiPortalsRestClient;
        private readonly AppPlatformApiPortalData _data;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformApiPortalResource"/> class for mocking. </summary>
        protected AppPlatformApiPortalResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AppPlatformApiPortalResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppPlatformApiPortalResource(ArmClient client, AppPlatformApiPortalData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformApiPortalResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppPlatformApiPortalResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformApiPortalApiPortalsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appPlatformApiPortalApiPortalsApiVersion);
            _appPlatformApiPortalApiPortalsRestClient = new ApiPortalsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformApiPortalApiPortalsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/apiPortals";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppPlatformApiPortalData Data
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

        /// <summary> Gets a collection of AppPlatformApiPortalCustomDomainResources in the AppPlatformApiPortal. </summary>
        /// <returns> An object representing collection of AppPlatformApiPortalCustomDomainResources and their operations over a AppPlatformApiPortalCustomDomainResource. </returns>
        public virtual AppPlatformApiPortalCustomDomainCollection GetAppPlatformApiPortalCustomDomains()
        {
            return GetCachedClient(Client => new AppPlatformApiPortalCustomDomainCollection(Client, Id));
        }

        /// <summary>
        /// Get the API portal custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the API portal custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppPlatformApiPortalCustomDomainResource>> GetAppPlatformApiPortalCustomDomainAsync(string domainName, CancellationToken cancellationToken = default)
        {
            return await GetAppPlatformApiPortalCustomDomains().GetAsync(domainName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the API portal custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the API portal custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppPlatformApiPortalCustomDomainResource> GetAppPlatformApiPortalCustomDomain(string domainName, CancellationToken cancellationToken = default)
        {
            return GetAppPlatformApiPortalCustomDomains().Get(domainName, cancellationToken);
        }

        /// <summary>
        /// Get the API portal and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppPlatformApiPortalResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalResource.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalApiPortalsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformApiPortalResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the API portal and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppPlatformApiPortalResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalResource.Get");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalApiPortalsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformApiPortalResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the default API portal.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalResource.Delete");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalApiPortalsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation(_appPlatformApiPortalApiPortalsClientDiagnostics, Pipeline, _appPlatformApiPortalApiPortalsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete the default API portal.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalResource.Delete");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalApiPortalsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppPlatformArmOperation(_appPlatformApiPortalApiPortalsClientDiagnostics, Pipeline, _appPlatformApiPortalApiPortalsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create the default API portal or update the existing API portal.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The API portal for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformApiPortalResource>> UpdateAsync(WaitUntil waitUntil, AppPlatformApiPortalData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalResource.Update");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalApiPortalsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformApiPortalResource>(new AppPlatformApiPortalOperationSource(Client), _appPlatformApiPortalApiPortalsClientDiagnostics, Pipeline, _appPlatformApiPortalApiPortalsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create the default API portal or update the existing API portal.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The API portal for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformApiPortalResource> Update(WaitUntil waitUntil, AppPlatformApiPortalData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalResource.Update");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalApiPortalsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformApiPortalResource>(new AppPlatformApiPortalOperationSource(Client), _appPlatformApiPortalApiPortalsClientDiagnostics, Pipeline, _appPlatformApiPortalApiPortalsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Check the domains are valid as well as not in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/validateDomain</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_ValidateDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Custom domain payload to be validated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<AppPlatformCustomDomainValidateResult>> ValidateDomainAsync(AppPlatformCustomDomainValidateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalResource.ValidateDomain");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalApiPortalsRestClient.ValidateDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the domains are valid as well as not in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/validateDomain</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_ValidateDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Custom domain payload to be validated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<AppPlatformCustomDomainValidateResult> ValidateDomain(AppPlatformCustomDomainValidateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalResource.ValidateDomain");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalApiPortalsRestClient.ValidateDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
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