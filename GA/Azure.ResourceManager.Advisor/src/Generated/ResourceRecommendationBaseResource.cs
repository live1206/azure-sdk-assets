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

namespace Azure.ResourceManager.Advisor
{
    /// <summary>
    /// A Class representing a ResourceRecommendationBase along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ResourceRecommendationBaseResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetResourceRecommendationBaseResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetResourceRecommendationBase method.
    /// </summary>
    public partial class ResourceRecommendationBaseResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceRecommendationBaseResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri, string recommendationId)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceRecommendationBaseRecommendationsClientDiagnostics;
        private readonly RecommendationsRestOperations _resourceRecommendationBaseRecommendationsRestClient;
        private readonly ResourceRecommendationBaseData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceRecommendationBaseResource"/> class for mocking. </summary>
        protected ResourceRecommendationBaseResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceRecommendationBaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceRecommendationBaseResource(ArmClient client, ResourceRecommendationBaseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceRecommendationBaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceRecommendationBaseResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceRecommendationBaseRecommendationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Advisor", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceRecommendationBaseRecommendationsApiVersion);
            _resourceRecommendationBaseRecommendationsRestClient = new RecommendationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceRecommendationBaseRecommendationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Advisor/recommendations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceRecommendationBaseData Data
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

        /// <summary> Gets a collection of SuppressionContractResources in the ResourceRecommendationBase. </summary>
        /// <returns> An object representing collection of SuppressionContractResources and their operations over a SuppressionContractResource. </returns>
        public virtual SuppressionContractCollection GetSuppressionContracts()
        {
            return GetCachedClient(Client => new SuppressionContractCollection(Client, Id));
        }

        /// <summary>
        /// Obtains the details of a suppression.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the suppression. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SuppressionContractResource>> GetSuppressionContractAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetSuppressionContracts().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Obtains the details of a suppression.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the suppression. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SuppressionContractResource> GetSuppressionContract(string name, CancellationToken cancellationToken = default)
        {
            return GetSuppressionContracts().Get(name, cancellationToken);
        }

        /// <summary>
        /// Obtains details of a cached recommendation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceRecommendationBaseResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceRecommendationBaseRecommendationsClientDiagnostics.CreateScope("ResourceRecommendationBaseResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceRecommendationBaseRecommendationsRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceRecommendationBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Obtains details of a cached recommendation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceRecommendationBaseResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceRecommendationBaseRecommendationsClientDiagnostics.CreateScope("ResourceRecommendationBaseResource.Get");
            scope.Start();
            try
            {
                var response = _resourceRecommendationBaseRecommendationsRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceRecommendationBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}