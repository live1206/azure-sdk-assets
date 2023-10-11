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
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataBoxEdge. </summary>
    public static partial class DataBoxEdgeExtensions
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

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }
        #region DataBoxEdgeDeviceResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeDeviceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeDeviceResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeDeviceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeDeviceResource" /> object. </returns>
        public static DataBoxEdgeDeviceResource GetDataBoxEdgeDeviceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeDeviceResource.ValidateResourceId(id);
                return new DataBoxEdgeDeviceResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeAlertResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeAlertResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeAlertResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeAlertResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeAlertResource" /> object. </returns>
        public static DataBoxEdgeAlertResource GetDataBoxEdgeAlertResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeAlertResource.ValidateResourceId(id);
                return new DataBoxEdgeAlertResource(client, id);
            }
            );
        }
        #endregion

        #region BandwidthScheduleResource
        /// <summary>
        /// Gets an object representing a <see cref="BandwidthScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BandwidthScheduleResource.CreateResourceIdentifier" /> to create a <see cref="BandwidthScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BandwidthScheduleResource" /> object. </returns>
        public static BandwidthScheduleResource GetBandwidthScheduleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BandwidthScheduleResource.ValidateResourceId(id);
                return new BandwidthScheduleResource(client, id);
            }
            );
        }
        #endregion

        #region DiagnosticProactiveLogCollectionSettingResource
        /// <summary>
        /// Gets an object representing a <see cref="DiagnosticProactiveLogCollectionSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiagnosticProactiveLogCollectionSettingResource.CreateResourceIdentifier" /> to create a <see cref="DiagnosticProactiveLogCollectionSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiagnosticProactiveLogCollectionSettingResource" /> object. </returns>
        public static DiagnosticProactiveLogCollectionSettingResource GetDiagnosticProactiveLogCollectionSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DiagnosticProactiveLogCollectionSettingResource.ValidateResourceId(id);
                return new DiagnosticProactiveLogCollectionSettingResource(client, id);
            }
            );
        }
        #endregion

        #region DiagnosticRemoteSupportSettingResource
        /// <summary>
        /// Gets an object representing a <see cref="DiagnosticRemoteSupportSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiagnosticRemoteSupportSettingResource.CreateResourceIdentifier" /> to create a <see cref="DiagnosticRemoteSupportSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiagnosticRemoteSupportSettingResource" /> object. </returns>
        public static DiagnosticRemoteSupportSettingResource GetDiagnosticRemoteSupportSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DiagnosticRemoteSupportSettingResource.ValidateResourceId(id);
                return new DiagnosticRemoteSupportSettingResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeJobResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeJobResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeJobResource" /> object. </returns>
        public static DataBoxEdgeJobResource GetDataBoxEdgeJobResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeJobResource.ValidateResourceId(id);
                return new DataBoxEdgeJobResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeOrderResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeOrderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeOrderResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeOrderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeOrderResource" /> object. </returns>
        public static DataBoxEdgeOrderResource GetDataBoxEdgeOrderResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeOrderResource.ValidateResourceId(id);
                return new DataBoxEdgeOrderResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeRoleResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeRoleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeRoleResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeRoleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeRoleResource" /> object. </returns>
        public static DataBoxEdgeRoleResource GetDataBoxEdgeRoleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeRoleResource.ValidateResourceId(id);
                return new DataBoxEdgeRoleResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeRoleAddonResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeRoleAddonResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeRoleAddonResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeRoleAddonResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeRoleAddonResource" /> object. </returns>
        public static DataBoxEdgeRoleAddonResource GetDataBoxEdgeRoleAddonResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeRoleAddonResource.ValidateResourceId(id);
                return new DataBoxEdgeRoleAddonResource(client, id);
            }
            );
        }
        #endregion

        #region MonitoringMetricConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="MonitoringMetricConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MonitoringMetricConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="MonitoringMetricConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MonitoringMetricConfigurationResource" /> object. </returns>
        public static MonitoringMetricConfigurationResource GetMonitoringMetricConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MonitoringMetricConfigurationResource.ValidateResourceId(id);
                return new MonitoringMetricConfigurationResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeShareResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeShareResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeShareResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeShareResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeShareResource" /> object. </returns>
        public static DataBoxEdgeShareResource GetDataBoxEdgeShareResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeShareResource.ValidateResourceId(id);
                return new DataBoxEdgeShareResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeStorageAccountCredentialResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeStorageAccountCredentialResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeStorageAccountCredentialResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeStorageAccountCredentialResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeStorageAccountCredentialResource" /> object. </returns>
        public static DataBoxEdgeStorageAccountCredentialResource GetDataBoxEdgeStorageAccountCredentialResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeStorageAccountCredentialResource.ValidateResourceId(id);
                return new DataBoxEdgeStorageAccountCredentialResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeStorageAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeStorageAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeStorageAccountResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeStorageAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeStorageAccountResource" /> object. </returns>
        public static DataBoxEdgeStorageAccountResource GetDataBoxEdgeStorageAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeStorageAccountResource.ValidateResourceId(id);
                return new DataBoxEdgeStorageAccountResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeStorageContainerResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeStorageContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeStorageContainerResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeStorageContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeStorageContainerResource" /> object. </returns>
        public static DataBoxEdgeStorageContainerResource GetDataBoxEdgeStorageContainerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeStorageContainerResource.ValidateResourceId(id);
                return new DataBoxEdgeStorageContainerResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeTriggerResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeTriggerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeTriggerResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeTriggerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeTriggerResource" /> object. </returns>
        public static DataBoxEdgeTriggerResource GetDataBoxEdgeTriggerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeTriggerResource.ValidateResourceId(id);
                return new DataBoxEdgeTriggerResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeUserResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeUserResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeUserResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeUserResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeUserResource" /> object. </returns>
        public static DataBoxEdgeUserResource GetDataBoxEdgeUserResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeUserResource.ValidateResourceId(id);
                return new DataBoxEdgeUserResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of DataBoxEdgeDeviceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataBoxEdgeDeviceResources and their operations over a DataBoxEdgeDeviceResource. </returns>
        public static DataBoxEdgeDeviceCollection GetDataBoxEdgeDevices(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetDataBoxEdgeDevices();
        }

        /// <summary>
        /// Gets the properties of the Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataBoxEdgeDeviceResource>> GetDataBoxEdgeDeviceAsync(this ResourceGroupResource resourceGroupResource, string deviceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetDataBoxEdgeDevices().GetAsync(deviceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DataBoxEdgeDeviceResource> GetDataBoxEdgeDevice(this ResourceGroupResource resourceGroupResource, string deviceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetDataBoxEdgeDevices().Get(deviceName, cancellationToken);
        }

        /// <summary>
        /// List all the available Skus and information related to them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/availableSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableSkus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableDataBoxEdgeSku" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AvailableDataBoxEdgeSku> GetAvailableSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetAvailableSkusAsync(cancellationToken);
        }

        /// <summary>
        /// List all the available Skus and information related to them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/availableSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableSkus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableDataBoxEdgeSku" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AvailableDataBoxEdgeSku> GetAvailableSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetAvailableSkus(cancellationToken);
        }

        /// <summary>
        /// Gets all the Data Box Edge/Data Box Gateway devices in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="expand"> Specify $expand=details to populate additional fields related to the resource or Specify $skipToken=&lt;token&gt; to populate the next page in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxEdgeDeviceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataBoxEdgeDeviceResource> GetDataBoxEdgeDevicesAsync(this SubscriptionResource subscriptionResource, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetDataBoxEdgeDevicesAsync(expand, cancellationToken);
        }

        /// <summary>
        /// Gets all the Data Box Edge/Data Box Gateway devices in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="expand"> Specify $expand=details to populate additional fields related to the resource or Specify $skipToken=&lt;token&gt; to populate the next page in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxEdgeDeviceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataBoxEdgeDeviceResource> GetDataBoxEdgeDevices(this SubscriptionResource subscriptionResource, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetDataBoxEdgeDevices(expand, cancellationToken);
        }
    }
}
