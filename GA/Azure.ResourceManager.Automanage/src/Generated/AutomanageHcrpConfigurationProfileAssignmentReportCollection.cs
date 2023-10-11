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

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomanageHcrpConfigurationProfileAssignmentReportResource" /> and their operations.
    /// Each <see cref="AutomanageHcrpConfigurationProfileAssignmentReportResource" /> in the collection will belong to the same instance of <see cref="AutomanageHcrpConfigurationProfileAssignmentResource" />.
    /// To get an <see cref="AutomanageHcrpConfigurationProfileAssignmentReportCollection" /> instance call the GetAutomanageHcrpConfigurationProfileAssignmentReports method from an instance of <see cref="AutomanageHcrpConfigurationProfileAssignmentResource" />.
    /// </summary>
    public partial class AutomanageHcrpConfigurationProfileAssignmentReportCollection : ArmCollection, IEnumerable<AutomanageHcrpConfigurationProfileAssignmentReportResource>, IAsyncEnumerable<AutomanageHcrpConfigurationProfileAssignmentReportResource>
    {
        private readonly ClientDiagnostics _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsClientDiagnostics;
        private readonly HcrpReportsRestOperations _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomanageHcrpConfigurationProfileAssignmentReportCollection"/> class for mocking. </summary>
        protected AutomanageHcrpConfigurationProfileAssignmentReportCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageHcrpConfigurationProfileAssignmentReportCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomanageHcrpConfigurationProfileAssignmentReportCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageHcrpConfigurationProfileAssignmentReportResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomanageHcrpConfigurationProfileAssignmentReportResource.ResourceType, out string automanageHcrpConfigurationProfileAssignmentReportHCRPReportsApiVersion);
            _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsRestClient = new HcrpReportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageHcrpConfigurationProfileAssignmentReportHCRPReportsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != "Microsoft.Automanage/configurationProfileAssignments")
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, "Microsoft.Automanage/configurationProfileAssignments"), nameof(id));
        }

        /// <summary>
        /// Get information about a report associated with a configuration profile assignment run
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HCRPReports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> The report name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual async Task<Response<AutomanageHcrpConfigurationProfileAssignmentReportResource>> GetAsync(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentReportCollection.Get");
            scope.Start();
            try
            {
                var response = await _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageHcrpConfigurationProfileAssignmentReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a report associated with a configuration profile assignment run
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HCRPReports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> The report name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual Response<AutomanageHcrpConfigurationProfileAssignmentReportResource> Get(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentReportCollection.Get");
            scope.Start();
            try
            {
                var response = _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageHcrpConfigurationProfileAssignmentReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of reports within a given configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HCRPReports_ListByConfigurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomanageHcrpConfigurationProfileAssignmentReportResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomanageHcrpConfigurationProfileAssignmentReportResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsRestClient.CreateListByConfigurationProfileAssignmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AutomanageHcrpConfigurationProfileAssignmentReportResource(Client, AutomanageConfigurationProfileAssignmentReportData.DeserializeAutomanageConfigurationProfileAssignmentReportData(e)), _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsClientDiagnostics, Pipeline, "AutomanageHcrpConfigurationProfileAssignmentReportCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of reports within a given configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HCRPReports_ListByConfigurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomanageHcrpConfigurationProfileAssignmentReportResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomanageHcrpConfigurationProfileAssignmentReportResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsRestClient.CreateListByConfigurationProfileAssignmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new AutomanageHcrpConfigurationProfileAssignmentReportResource(Client, AutomanageConfigurationProfileAssignmentReportData.DeserializeAutomanageConfigurationProfileAssignmentReportData(e)), _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsClientDiagnostics, Pipeline, "AutomanageHcrpConfigurationProfileAssignmentReportCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HCRPReports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> The report name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentReportCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HCRPReports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> The report name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual Response<bool> Exists(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentReportCollection.Exists");
            scope.Start();
            try
            {
                var response = _automanageHcrpConfigurationProfileAssignmentReportHCRPReportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomanageHcrpConfigurationProfileAssignmentReportResource> IEnumerable<AutomanageHcrpConfigurationProfileAssignmentReportResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomanageHcrpConfigurationProfileAssignmentReportResource> IAsyncEnumerable<AutomanageHcrpConfigurationProfileAssignmentReportResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}