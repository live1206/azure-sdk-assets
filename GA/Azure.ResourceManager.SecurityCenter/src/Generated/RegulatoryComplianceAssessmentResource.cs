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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a RegulatoryComplianceAssessment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RegulatoryComplianceAssessmentResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRegulatoryComplianceAssessmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="RegulatoryComplianceControlResource" /> using the GetRegulatoryComplianceAssessment method.
    /// </summary>
    public partial class RegulatoryComplianceAssessmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RegulatoryComplianceAssessmentResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string regulatoryComplianceStandardName, string regulatoryComplianceControlName, string regulatoryComplianceAssessmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments/{regulatoryComplianceAssessmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _regulatoryComplianceAssessmentClientDiagnostics;
        private readonly RegulatoryComplianceAssessmentsRestOperations _regulatoryComplianceAssessmentRestClient;
        private readonly RegulatoryComplianceAssessmentData _data;

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceAssessmentResource"/> class for mocking. </summary>
        protected RegulatoryComplianceAssessmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RegulatoryComplianceAssessmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RegulatoryComplianceAssessmentResource(ArmClient client, RegulatoryComplianceAssessmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceAssessmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RegulatoryComplianceAssessmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _regulatoryComplianceAssessmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string regulatoryComplianceAssessmentApiVersion);
            _regulatoryComplianceAssessmentRestClient = new RegulatoryComplianceAssessmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, regulatoryComplianceAssessmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/regulatoryComplianceStandards/regulatoryComplianceControls/regulatoryComplianceAssessments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RegulatoryComplianceAssessmentData Data
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
        /// Supported regulatory compliance details and state for selected assessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments/{regulatoryComplianceAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceAssessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RegulatoryComplianceAssessmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _regulatoryComplianceAssessmentClientDiagnostics.CreateScope("RegulatoryComplianceAssessmentResource.Get");
            scope.Start();
            try
            {
                var response = await _regulatoryComplianceAssessmentRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Supported regulatory compliance details and state for selected assessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments/{regulatoryComplianceAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceAssessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RegulatoryComplianceAssessmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _regulatoryComplianceAssessmentClientDiagnostics.CreateScope("RegulatoryComplianceAssessmentResource.Get");
            scope.Start();
            try
            {
                var response = _regulatoryComplianceAssessmentRestClient.Get(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}