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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteSlotDiagnosticDetectorResource" /> and their operations.
    /// Each <see cref="SiteSlotDiagnosticDetectorResource" /> in the collection will belong to the same instance of <see cref="SiteSlotDiagnosticResource" />.
    /// To get a <see cref="SiteSlotDiagnosticDetectorCollection" /> instance call the GetSiteSlotDiagnosticDetectors method from an instance of <see cref="SiteSlotDiagnosticResource" />.
    /// </summary>
    public partial class SiteSlotDiagnosticDetectorCollection : ArmCollection, IEnumerable<SiteSlotDiagnosticDetectorResource>, IAsyncEnumerable<SiteSlotDiagnosticDetectorResource>
    {
        private readonly ClientDiagnostics _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteSlotDiagnosticDetectorDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticDetectorCollection"/> class for mocking. </summary>
        protected SiteSlotDiagnosticDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotDiagnosticDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotDiagnosticDetectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotDiagnosticDetectorResource.ResourceType, out string siteSlotDiagnosticDetectorDiagnosticsApiVersion);
            _siteSlotDiagnosticDetectorDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotDiagnosticDetectorDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotDiagnosticResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotDiagnosticResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get Detector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetectorSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotDiagnosticDetectorResource>> GetAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Detector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetectorSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<SiteSlotDiagnosticDetectorResource> Get(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Detectors
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteDetectorsSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDiagnosticDetectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDiagnosticDetectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotDiagnosticDetectorDiagnosticsRestClient.CreateListSiteDetectorsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotDiagnosticDetectorDiagnosticsRestClient.CreateListSiteDetectorsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteSlotDiagnosticDetectorResource(Client, DetectorDefinitionResourceData.DeserializeDetectorDefinitionResourceData(e)), _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics, Pipeline, "SiteSlotDiagnosticDetectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get Detectors
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteDetectorsSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDiagnosticDetectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDiagnosticDetectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotDiagnosticDetectorDiagnosticsRestClient.CreateListSiteDetectorsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotDiagnosticDetectorDiagnosticsRestClient.CreateListSiteDetectorsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteSlotDiagnosticDetectorResource(Client, DetectorDefinitionResourceData.DeserializeDetectorDefinitionResourceData(e)), _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics, Pipeline, "SiteSlotDiagnosticDetectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetectorSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetectorSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotDiagnosticDetectorResource> IEnumerable<SiteSlotDiagnosticDetectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDiagnosticDetectorResource> IAsyncEnumerable<SiteSlotDiagnosticDetectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}