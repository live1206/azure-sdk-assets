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
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteSlotInstanceExtension along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotInstanceExtensionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotInstanceExtensionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotInstanceResource" /> using the GetSiteSlotInstanceExtension method.
    /// </summary>
    public partial class SiteSlotInstanceExtensionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotInstanceExtensionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string instanceId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotInstanceExtensionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotInstanceExtensionWebAppsRestClient;
        private readonly MSDeployStatusData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceExtensionResource"/> class for mocking. </summary>
        protected SiteSlotInstanceExtensionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotInstanceExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotInstanceExtensionResource(ArmClient client, MSDeployStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotInstanceExtensionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotInstanceExtensionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotInstanceExtensionWebAppsApiVersion);
            _siteSlotInstanceExtensionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotInstanceExtensionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/instances/extensions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MSDeployStatusData Data
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
        /// Description for Get the status of the last MSDeploy operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceMsDeployStatusSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotInstanceExtensionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtensionResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceExtensionWebAppsRestClient.GetInstanceMsDeployStatusSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the status of the last MSDeploy operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceMsDeployStatusSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotInstanceExtensionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtensionResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceExtensionWebAppsRestClient.GetInstanceMsDeployStatusSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Invoke the MSDeploy web app extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateInstanceMSDeployOperationSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotInstanceExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, WebAppMSDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(msDeploy, nameof(msDeploy));

            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtensionResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceExtensionWebAppsRestClient.CreateInstanceMSDeployOperationSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotInstanceExtensionResource>(new SiteSlotInstanceExtensionOperationSource(Client), _siteSlotInstanceExtensionWebAppsClientDiagnostics, Pipeline, _siteSlotInstanceExtensionWebAppsRestClient.CreateCreateInstanceMSDeployOperationSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Invoke the MSDeploy web app extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateInstanceMSDeployOperationSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        public virtual ArmOperation<SiteSlotInstanceExtensionResource> CreateOrUpdate(WaitUntil waitUntil, WebAppMSDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(msDeploy, nameof(msDeploy));

            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtensionResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceExtensionWebAppsRestClient.CreateInstanceMSDeployOperationSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotInstanceExtensionResource>(new SiteSlotInstanceExtensionOperationSource(Client), _siteSlotInstanceExtensionWebAppsClientDiagnostics, Pipeline, _siteSlotInstanceExtensionWebAppsRestClient.CreateCreateInstanceMSDeployOperationSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy/log</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceMSDeployLogSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WebAppMSDeployLog>> GetInstanceMSDeployLogSlotAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtensionResource.GetInstanceMSDeployLogSlot");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceExtensionWebAppsRestClient.GetInstanceMSDeployLogSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy/log</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceMSDeployLogSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WebAppMSDeployLog> GetInstanceMSDeployLogSlot(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtensionResource.GetInstanceMSDeployLogSlot");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceExtensionWebAppsRestClient.GetInstanceMSDeployLogSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
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