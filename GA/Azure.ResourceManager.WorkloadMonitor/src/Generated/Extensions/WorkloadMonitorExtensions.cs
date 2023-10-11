// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.WorkloadMonitor
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.WorkloadMonitor. </summary>
    public static partial class WorkloadMonitorExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }
        #region HealthMonitorResource
        /// <summary>
        /// Gets an object representing a <see cref="HealthMonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthMonitorResource.CreateResourceIdentifier" /> to create a <see cref="HealthMonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthMonitorResource" /> object. </returns>
        public static HealthMonitorResource GetHealthMonitorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                HealthMonitorResource.ValidateResourceId(id);
                return new HealthMonitorResource(client, id);
            }
            );
        }
        #endregion

        #region HealthMonitorStateChangeResource
        /// <summary>
        /// Gets an object representing a <see cref="HealthMonitorStateChangeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthMonitorStateChangeResource.CreateResourceIdentifier" /> to create a <see cref="HealthMonitorStateChangeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthMonitorStateChangeResource" /> object. </returns>
        public static HealthMonitorStateChangeResource GetHealthMonitorStateChangeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                HealthMonitorStateChangeResource.ValidateResourceId(id);
                return new HealthMonitorStateChangeResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of HealthMonitorResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="providerName"> The provider name (ex: Microsoft.Compute for virtual machines). </param>
        /// <param name="resourceCollectionName"> The resource collection name (ex: virtualMachines for virtual machines). </param>
        /// <param name="resourceName"> The name of the virtual machine. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <returns> An object representing collection of HealthMonitorResources and their operations over a HealthMonitorResource. </returns>
        public static HealthMonitorCollection GetHealthMonitors(this ResourceGroupResource resourceGroupResource, string providerName, string resourceCollectionName, string resourceName)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNullOrEmpty(resourceCollectionName, nameof(resourceCollectionName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetHealthMonitors(providerName, resourceCollectionName, resourceName);
        }

        /// <summary>
        /// Get the current health status of a monitor of a virtual machine. Optional parameter: $expand (retrieve the monitor's evidence and configuration).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="providerName"> The provider name (ex: Microsoft.Compute for virtual machines). </param>
        /// <param name="resourceCollectionName"> The resource collection name (ex: virtualMachines for virtual machines). </param>
        /// <param name="resourceName"> The name of the virtual machine. </param>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HealthMonitorResource>> GetHealthMonitorAsync(this ResourceGroupResource resourceGroupResource, string providerName, string resourceCollectionName, string resourceName, string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetHealthMonitors(providerName, resourceCollectionName, resourceName).GetAsync(monitorId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the current health status of a monitor of a virtual machine. Optional parameter: $expand (retrieve the monitor's evidence and configuration).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="providerName"> The provider name (ex: Microsoft.Compute for virtual machines). </param>
        /// <param name="resourceCollectionName"> The resource collection name (ex: virtualMachines for virtual machines). </param>
        /// <param name="resourceName"> The name of the virtual machine. </param>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<HealthMonitorResource> GetHealthMonitor(this ResourceGroupResource resourceGroupResource, string providerName, string resourceCollectionName, string resourceName, string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetHealthMonitors(providerName, resourceCollectionName, resourceName).Get(monitorId, expand, cancellationToken);
        }
    }
}