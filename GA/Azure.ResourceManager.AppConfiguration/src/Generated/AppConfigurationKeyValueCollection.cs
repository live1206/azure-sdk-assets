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

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="AppConfigurationKeyValueResource" /> and their operations.
    /// Each <see cref="AppConfigurationKeyValueResource" /> in the collection will belong to the same instance of <see cref="AppConfigurationStoreResource" />.
    /// To get an <see cref="AppConfigurationKeyValueCollection" /> instance call the GetAppConfigurationKeyValues method from an instance of <see cref="AppConfigurationStoreResource" />.
    /// </summary>
    public partial class AppConfigurationKeyValueCollection : ArmCollection, IEnumerable<AppConfigurationKeyValueResource>, IAsyncEnumerable<AppConfigurationKeyValueResource>
    {
        private readonly ClientDiagnostics _appConfigurationKeyValueKeyValuesClientDiagnostics;
        private readonly KeyValuesRestOperations _appConfigurationKeyValueKeyValuesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationKeyValueCollection"/> class for mocking. </summary>
        protected AppConfigurationKeyValueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationKeyValueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppConfigurationKeyValueCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appConfigurationKeyValueKeyValuesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", AppConfigurationKeyValueResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppConfigurationKeyValueResource.ResourceType, out string appConfigurationKeyValueKeyValuesApiVersion);
            _appConfigurationKeyValueKeyValuesRestClient = new KeyValuesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appConfigurationKeyValueKeyValuesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppConfigurationStoreResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppConfigurationStoreResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a key-value.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KeyValues_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="data"> The parameters for creating a key-value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppConfigurationKeyValueResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string keyValueName, AppConfigurationKeyValueData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appConfigurationKeyValueKeyValuesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation<AppConfigurationKeyValueResource>(Response.FromValue(new AppConfigurationKeyValueResource(Client, response), response.GetRawResponse()));
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
        /// Creates a key-value.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KeyValues_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="data"> The parameters for creating a key-value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppConfigurationKeyValueResource> CreateOrUpdate(WaitUntil waitUntil, string keyValueName, AppConfigurationKeyValueData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appConfigurationKeyValueKeyValuesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, data, cancellationToken);
                var operation = new AppConfigurationArmOperation<AppConfigurationKeyValueResource>(Response.FromValue(new AppConfigurationKeyValueResource(Client, response), response.GetRawResponse()));
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
        /// Gets the properties of the specified key-value.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KeyValues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual async Task<Response<AppConfigurationKeyValueResource>> GetAsync(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.Get");
            scope.Start();
            try
            {
                var response = await _appConfigurationKeyValueKeyValuesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationKeyValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified key-value.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KeyValues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual Response<AppConfigurationKeyValueResource> Get(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.Get");
            scope.Start();
            try
            {
                var response = _appConfigurationKeyValueKeyValuesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationKeyValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the key-values for a given configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KeyValues_ListByConfigurationStore</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppConfigurationKeyValueResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppConfigurationKeyValueResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appConfigurationKeyValueKeyValuesRestClient.CreateListByConfigurationStoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appConfigurationKeyValueKeyValuesRestClient.CreateListByConfigurationStoreNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppConfigurationKeyValueResource(Client, AppConfigurationKeyValueData.DeserializeAppConfigurationKeyValueData(e)), _appConfigurationKeyValueKeyValuesClientDiagnostics, Pipeline, "AppConfigurationKeyValueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the key-values for a given configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KeyValues_ListByConfigurationStore</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppConfigurationKeyValueResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppConfigurationKeyValueResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appConfigurationKeyValueKeyValuesRestClient.CreateListByConfigurationStoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appConfigurationKeyValueKeyValuesRestClient.CreateListByConfigurationStoreNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppConfigurationKeyValueResource(Client, AppConfigurationKeyValueData.DeserializeAppConfigurationKeyValueData(e)), _appConfigurationKeyValueKeyValuesClientDiagnostics, Pipeline, "AppConfigurationKeyValueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KeyValues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appConfigurationKeyValueKeyValuesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KeyValues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual Response<bool> Exists(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.Exists");
            scope.Start();
            try
            {
                var response = _appConfigurationKeyValueKeyValuesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppConfigurationKeyValueResource> IEnumerable<AppConfigurationKeyValueResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppConfigurationKeyValueResource> IAsyncEnumerable<AppConfigurationKeyValueResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}