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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementEmailTemplateResource" /> and their operations.
    /// Each <see cref="ApiManagementEmailTemplateResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementEmailTemplateCollection" /> instance call the GetApiManagementEmailTemplates method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementEmailTemplateCollection : ArmCollection, IEnumerable<ApiManagementEmailTemplateResource>, IAsyncEnumerable<ApiManagementEmailTemplateResource>
    {
        private readonly ClientDiagnostics _apiManagementEmailTemplateEmailTemplateClientDiagnostics;
        private readonly EmailTemplateRestOperations _apiManagementEmailTemplateEmailTemplateRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementEmailTemplateCollection"/> class for mocking. </summary>
        protected ApiManagementEmailTemplateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementEmailTemplateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementEmailTemplateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementEmailTemplateEmailTemplateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementEmailTemplateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementEmailTemplateResource.ResourceType, out string apiManagementEmailTemplateEmailTemplateApiVersion);
            _apiManagementEmailTemplateEmailTemplateRestClient = new EmailTemplateRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementEmailTemplateEmailTemplateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates an Email Template.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/templates/{templateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailTemplate_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="templateName"> Email Template Name Identifier. </param>
        /// <param name="content"> Email Template update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementEmailTemplateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, TemplateName templateName, ApiManagementEmailTemplateCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementEmailTemplateEmailTemplateClientDiagnostics.CreateScope("ApiManagementEmailTemplateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementEmailTemplateEmailTemplateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateName, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementEmailTemplateResource>(Response.FromValue(new ApiManagementEmailTemplateResource(Client, response), response.GetRawResponse()));
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
        /// Updates an Email Template.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/templates/{templateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailTemplate_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="templateName"> Email Template Name Identifier. </param>
        /// <param name="content"> Email Template update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiManagementEmailTemplateResource> CreateOrUpdate(WaitUntil waitUntil, TemplateName templateName, ApiManagementEmailTemplateCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementEmailTemplateEmailTemplateClientDiagnostics.CreateScope("ApiManagementEmailTemplateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementEmailTemplateEmailTemplateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateName, content, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementEmailTemplateResource>(Response.FromValue(new ApiManagementEmailTemplateResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the email template specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/templates/{templateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailTemplate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateName"> Email Template Name Identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementEmailTemplateResource>> GetAsync(TemplateName templateName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementEmailTemplateEmailTemplateClientDiagnostics.CreateScope("ApiManagementEmailTemplateCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementEmailTemplateEmailTemplateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementEmailTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the email template specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/templates/{templateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailTemplate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateName"> Email Template Name Identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementEmailTemplateResource> Get(TemplateName templateName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementEmailTemplateEmailTemplateClientDiagnostics.CreateScope("ApiManagementEmailTemplateCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementEmailTemplateEmailTemplateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementEmailTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all email templates
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/templates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailTemplate_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementEmailTemplateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementEmailTemplateResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementEmailTemplateEmailTemplateRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementEmailTemplateEmailTemplateRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementEmailTemplateResource(Client, ApiManagementEmailTemplateData.DeserializeApiManagementEmailTemplateData(e)), _apiManagementEmailTemplateEmailTemplateClientDiagnostics, Pipeline, "ApiManagementEmailTemplateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all email templates
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/templates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailTemplate_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementEmailTemplateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementEmailTemplateResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementEmailTemplateEmailTemplateRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementEmailTemplateEmailTemplateRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementEmailTemplateResource(Client, ApiManagementEmailTemplateData.DeserializeApiManagementEmailTemplateData(e)), _apiManagementEmailTemplateEmailTemplateClientDiagnostics, Pipeline, "ApiManagementEmailTemplateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/templates/{templateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailTemplate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateName"> Email Template Name Identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(TemplateName templateName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementEmailTemplateEmailTemplateClientDiagnostics.CreateScope("ApiManagementEmailTemplateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementEmailTemplateEmailTemplateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/templates/{templateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailTemplate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateName"> Email Template Name Identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(TemplateName templateName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementEmailTemplateEmailTemplateClientDiagnostics.CreateScope("ApiManagementEmailTemplateCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementEmailTemplateEmailTemplateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementEmailTemplateResource> IEnumerable<ApiManagementEmailTemplateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementEmailTemplateResource> IAsyncEnumerable<ApiManagementEmailTemplateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}