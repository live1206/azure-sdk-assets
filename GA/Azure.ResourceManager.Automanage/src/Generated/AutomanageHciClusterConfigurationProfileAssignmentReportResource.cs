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

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A Class representing an AutomanageHciClusterConfigurationProfileAssignmentReport along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AutomanageHciClusterConfigurationProfileAssignmentReportResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAutomanageHciClusterConfigurationProfileAssignmentReportResource method.
    /// Otherwise you can get one from its parent resource <see cref="AutomanageHciClusterConfigurationProfileAssignmentResource" /> using the GetAutomanageHciClusterConfigurationProfileAssignmentReport method.
    /// </summary>
    public partial class AutomanageHciClusterConfigurationProfileAssignmentReportResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutomanageHciClusterConfigurationProfileAssignmentReportResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName, string configurationProfileAssignmentName, string reportName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _automanageHciClusterConfigurationProfileAssignmentReportHCIReportsClientDiagnostics;
        private readonly HCIReportsRestOperations _automanageHciClusterConfigurationProfileAssignmentReportHCIReportsRestClient;
        private readonly AutomanageConfigurationProfileAssignmentReportData _data;

        /// <summary> Initializes a new instance of the <see cref="AutomanageHciClusterConfigurationProfileAssignmentReportResource"/> class for mocking. </summary>
        protected AutomanageHciClusterConfigurationProfileAssignmentReportResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AutomanageHciClusterConfigurationProfileAssignmentReportResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutomanageHciClusterConfigurationProfileAssignmentReportResource(ArmClient client, AutomanageConfigurationProfileAssignmentReportData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageHciClusterConfigurationProfileAssignmentReportResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutomanageHciClusterConfigurationProfileAssignmentReportResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageHciClusterConfigurationProfileAssignmentReportHCIReportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string automanageHciClusterConfigurationProfileAssignmentReportHCIReportsApiVersion);
            _automanageHciClusterConfigurationProfileAssignmentReportHCIReportsRestClient = new HCIReportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageHciClusterConfigurationProfileAssignmentReportHCIReportsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Automanage/configurationProfileAssignments/reports";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutomanageConfigurationProfileAssignmentReportData Data
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
        /// Get information about a report associated with a configuration profile assignment run
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HCIReports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutomanageHciClusterConfigurationProfileAssignmentReportResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _automanageHciClusterConfigurationProfileAssignmentReportHCIReportsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentReportResource.Get");
            scope.Start();
            try
            {
                var response = await _automanageHciClusterConfigurationProfileAssignmentReportHCIReportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageHciClusterConfigurationProfileAssignmentReportResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HCIReports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutomanageHciClusterConfigurationProfileAssignmentReportResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _automanageHciClusterConfigurationProfileAssignmentReportHCIReportsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentReportResource.Get");
            scope.Start();
            try
            {
                var response = _automanageHciClusterConfigurationProfileAssignmentReportHCIReportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageHciClusterConfigurationProfileAssignmentReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}