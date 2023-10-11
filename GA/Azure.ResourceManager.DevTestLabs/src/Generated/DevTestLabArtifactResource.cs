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
using Azure.ResourceManager.DevTestLabs.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A Class representing a DevTestLabArtifact along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DevTestLabArtifactResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDevTestLabArtifactResource method.
    /// Otherwise you can get one from its parent resource <see cref="DevTestLabArtifactSourceResource" /> using the GetDevTestLabArtifact method.
    /// </summary>
    public partial class DevTestLabArtifactResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DevTestLabArtifactResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string labName, string artifactSourceName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/artifacts/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _devTestLabArtifactArtifactsClientDiagnostics;
        private readonly ArtifactsRestOperations _devTestLabArtifactArtifactsRestClient;
        private readonly DevTestLabArtifactData _data;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabArtifactResource"/> class for mocking. </summary>
        protected DevTestLabArtifactResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DevTestLabArtifactResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DevTestLabArtifactResource(ArmClient client, DevTestLabArtifactData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabArtifactResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DevTestLabArtifactResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabArtifactArtifactsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string devTestLabArtifactArtifactsApiVersion);
            _devTestLabArtifactArtifactsRestClient = new ArtifactsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabArtifactArtifactsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevTestLab/labs/artifactsources/artifacts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DevTestLabArtifactData Data
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
        /// Get artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/artifacts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=title)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DevTestLabArtifactResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _devTestLabArtifactArtifactsClientDiagnostics.CreateScope("DevTestLabArtifactResource.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabArtifactArtifactsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabArtifactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/artifacts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=title)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DevTestLabArtifactResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _devTestLabArtifactArtifactsClientDiagnostics.CreateScope("DevTestLabArtifactResource.Get");
            scope.Start();
            try
            {
                var response = _devTestLabArtifactArtifactsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabArtifactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Generates an ARM template for the given artifact, uploads the required files to a storage account, and validates the generated artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/artifacts/{name}/generateArmTemplate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_GenerateArmTemplate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters for generating an ARM template for deploying artifacts. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<DevTestLabArmTemplateInfo>> GenerateArmTemplateAsync(DevTestLabArtifactGenerateArmTemplateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _devTestLabArtifactArtifactsClientDiagnostics.CreateScope("DevTestLabArtifactResource.GenerateArmTemplate");
            scope.Start();
            try
            {
                var response = await _devTestLabArtifactArtifactsRestClient.GenerateArmTemplateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Generates an ARM template for the given artifact, uploads the required files to a storage account, and validates the generated artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/artifacts/{name}/generateArmTemplate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_GenerateArmTemplate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters for generating an ARM template for deploying artifacts. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<DevTestLabArmTemplateInfo> GenerateArmTemplate(DevTestLabArtifactGenerateArmTemplateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _devTestLabArtifactArtifactsClientDiagnostics.CreateScope("DevTestLabArtifactResource.GenerateArmTemplate");
            scope.Start();
            try
            {
                var response = _devTestLabArtifactArtifactsRestClient.GenerateArmTemplate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
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