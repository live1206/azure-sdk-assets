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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationVariableResource" /> and their operations.
    /// Each <see cref="AutomationVariableResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get an <see cref="AutomationVariableCollection" /> instance call the GetAutomationVariables method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class AutomationVariableCollection : ArmCollection, IEnumerable<AutomationVariableResource>, IAsyncEnumerable<AutomationVariableResource>
    {
        private readonly ClientDiagnostics _automationVariableVariableClientDiagnostics;
        private readonly VariableRestOperations _automationVariableVariableRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationVariableCollection"/> class for mocking. </summary>
        protected AutomationVariableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationVariableCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationVariableCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationVariableVariableClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationVariableResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationVariableResource.ResourceType, out string automationVariableVariableApiVersion);
            _automationVariableVariableRestClient = new VariableRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationVariableVariableApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a variable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Variable_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="variableName"> The variable name. </param>
        /// <param name="content"> The parameters supplied to the create or update variable operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationVariableResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string variableName, AutomationVariableCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationVariableVariableClientDiagnostics.CreateScope("AutomationVariableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationVariableVariableRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationVariableResource>(Response.FromValue(new AutomationVariableResource(Client, response), response.GetRawResponse()));
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
        /// Create a variable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Variable_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="variableName"> The variable name. </param>
        /// <param name="content"> The parameters supplied to the create or update variable operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationVariableResource> CreateOrUpdate(WaitUntil waitUntil, string variableName, AutomationVariableCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationVariableVariableClientDiagnostics.CreateScope("AutomationVariableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationVariableVariableRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationVariableResource>(Response.FromValue(new AutomationVariableResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the variable identified by variable name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Variable_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="variableName"> The name of variable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> is null. </exception>
        public virtual async Task<Response<AutomationVariableResource>> GetAsync(string variableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));

            using var scope = _automationVariableVariableClientDiagnostics.CreateScope("AutomationVariableCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationVariableVariableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationVariableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the variable identified by variable name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Variable_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="variableName"> The name of variable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> is null. </exception>
        public virtual Response<AutomationVariableResource> Get(string variableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));

            using var scope = _automationVariableVariableClientDiagnostics.CreateScope("AutomationVariableCollection.Get");
            scope.Start();
            try
            {
                var response = _automationVariableVariableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationVariableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of variables.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Variable_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationVariableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationVariableResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationVariableVariableRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationVariableVariableRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutomationVariableResource(Client, AutomationVariableData.DeserializeAutomationVariableData(e)), _automationVariableVariableClientDiagnostics, Pipeline, "AutomationVariableCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of variables.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Variable_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationVariableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationVariableResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationVariableVariableRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationVariableVariableRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutomationVariableResource(Client, AutomationVariableData.DeserializeAutomationVariableData(e)), _automationVariableVariableClientDiagnostics, Pipeline, "AutomationVariableCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Variable_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="variableName"> The name of variable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string variableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));

            using var scope = _automationVariableVariableClientDiagnostics.CreateScope("AutomationVariableCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationVariableVariableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Variable_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="variableName"> The name of variable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> is null. </exception>
        public virtual Response<bool> Exists(string variableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));

            using var scope = _automationVariableVariableClientDiagnostics.CreateScope("AutomationVariableCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationVariableVariableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationVariableResource> IEnumerable<AutomationVariableResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationVariableResource> IAsyncEnumerable<AutomationVariableResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
