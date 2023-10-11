// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiManagementGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ApiManagementGroupResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetApiManagementGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource" /> using the GetApiManagementGroup method.
    /// </summary>
    public partial class ApiManagementGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiManagementGroupResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string groupId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiManagementGroupGroupClientDiagnostics;
        private readonly GroupRestOperations _apiManagementGroupGroupRestClient;
        private readonly ClientDiagnostics _groupUserClientDiagnostics;
        private readonly GroupUserRestOperations _groupUserRestClient;
        private readonly ApiManagementGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGroupResource"/> class for mocking. </summary>
        protected ApiManagementGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApiManagementGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiManagementGroupResource(ArmClient client, ApiManagementGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiManagementGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementGroupGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiManagementGroupGroupApiVersion);
            _apiManagementGroupGroupRestClient = new GroupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementGroupGroupApiVersion);
            _groupUserClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _groupUserRestClient = new GroupUserRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/groups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApiManagementGroupData Data
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
        /// Gets the details of the group specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Group_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGroupGroupClientDiagnostics.CreateScope("ApiManagementGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementGroupGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the group specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Group_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGroupGroupClientDiagnostics.CreateScope("ApiManagementGroupResource.Get");
            scope.Start();
            try
            {
                var response = _apiManagementGroupGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes specific group of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Group_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGroupGroupClientDiagnostics.CreateScope("ApiManagementGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _apiManagementGroupGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation(response);
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
        /// Deletes specific group of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Group_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGroupGroupClientDiagnostics.CreateScope("ApiManagementGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _apiManagementGroupGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation(response);
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
        /// Updates the details of the group specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Group_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<ApiManagementGroupResource>> UpdateAsync(ETag ifMatch, ApiManagementGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _apiManagementGroupGroupClientDiagnostics.CreateScope("ApiManagementGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _apiManagementGroupGroupRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ApiManagementGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the details of the group specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Group_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<ApiManagementGroupResource> Update(ETag ifMatch, ApiManagementGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _apiManagementGroupGroupClientDiagnostics.CreateScope("ApiManagementGroupResource.Update");
            scope.Start();
            try
            {
                var response = _apiManagementGroupGroupRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, patch, cancellationToken);
                return Response.FromValue(new ApiManagementGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of user entities associated with the group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupUser_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| firstName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| lastName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| email | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| registrationDate | filter | ge, le, eq, ne, gt, lt |     |&lt;/br&gt;| note | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementGroupUserData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementGroupUserData> GetGroupUsersAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _groupUserRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _groupUserRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ApiManagementGroupUserData.DeserializeApiManagementGroupUserData, _groupUserClientDiagnostics, Pipeline, "ApiManagementGroupResource.GetGroupUsers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of user entities associated with the group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupUser_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| firstName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| lastName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| email | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| registrationDate | filter | ge, le, eq, ne, gt, lt |     |&lt;/br&gt;| note | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementGroupUserData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementGroupUserData> GetGroupUsers(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _groupUserRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _groupUserRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ApiManagementGroupUserData.DeserializeApiManagementGroupUserData, _groupUserClientDiagnostics, Pipeline, "ApiManagementGroupResource.GetGroupUsers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks that user entity specified by identifier is associated with the group entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupUser_CheckEntityExists</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response<bool>> CheckGroupUserEntityExistsAsync(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("ApiManagementGroupResource.CheckGroupUserEntityExists");
            scope.Start();
            try
            {
                var response = await _groupUserRestClient.CheckEntityExistsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that user entity specified by identifier is associated with the group entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupUser_CheckEntityExists</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual Response<bool> CheckGroupUserEntityExists(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("ApiManagementGroupResource.CheckGroupUserEntityExists");
            scope.Start();
            try
            {
                var response = _groupUserRestClient.CheckEntityExists(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add existing user to existing group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupUser_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementGroupUserData>> CreateGroupUserAsync(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("ApiManagementGroupResource.CreateGroupUser");
            scope.Start();
            try
            {
                var response = await _groupUserRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add existing user to existing group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupUser_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual Response<ApiManagementGroupUserData> CreateGroupUser(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("ApiManagementGroupResource.CreateGroupUser");
            scope.Start();
            try
            {
                var response = _groupUserRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove existing user from existing group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupUser_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response> DeleteGroupUserAsync(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("ApiManagementGroupResource.DeleteGroupUser");
            scope.Start();
            try
            {
                var response = await _groupUserRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove existing user from existing group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupUser_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual Response DeleteGroupUser(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("ApiManagementGroupResource.DeleteGroupUser");
            scope.Start();
            try
            {
                var response = _groupUserRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the group specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Group_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGroupGroupClientDiagnostics.CreateScope("ApiManagementGroupResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _apiManagementGroupGroupRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the group specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Group_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGroupGroupClientDiagnostics.CreateScope("ApiManagementGroupResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _apiManagementGroupGroupRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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