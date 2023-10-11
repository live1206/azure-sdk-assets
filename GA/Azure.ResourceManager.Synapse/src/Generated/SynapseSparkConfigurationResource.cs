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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapseSparkConfiguration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SynapseSparkConfigurationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSynapseSparkConfigurationResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseWorkspaceResource" /> using the GetSynapseSparkConfiguration method.
    /// </summary>
    public partial class SynapseSparkConfigurationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseSparkConfigurationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sparkConfigurationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations/{sparkConfigurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseSparkConfigurationSparkConfigurationClientDiagnostics;
        private readonly SparkConfigurationRestOperations _synapseSparkConfigurationSparkConfigurationRestClient;
        private readonly SynapseSparkConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="SynapseSparkConfigurationResource"/> class for mocking. </summary>
        protected SynapseSparkConfigurationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SynapseSparkConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseSparkConfigurationResource(ArmClient client, SynapseSparkConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseSparkConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseSparkConfigurationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseSparkConfigurationSparkConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseSparkConfigurationSparkConfigurationApiVersion);
            _synapseSparkConfigurationSparkConfigurationRestClient = new SparkConfigurationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseSparkConfigurationSparkConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sparkconfigurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseSparkConfigurationData Data
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
        /// Get SparkConfiguration by name in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations/{sparkConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SparkConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseSparkConfigurationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSparkConfigurationSparkConfigurationClientDiagnostics.CreateScope("SynapseSparkConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseSparkConfigurationSparkConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSparkConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get SparkConfiguration by name in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations/{sparkConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SparkConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseSparkConfigurationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSparkConfigurationSparkConfigurationClientDiagnostics.CreateScope("SynapseSparkConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = _synapseSparkConfigurationSparkConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSparkConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
