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

namespace Azure.ResourceManager.HybridConnectivity
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HybridConnectivity. </summary>
    public static partial class HybridConnectivityExtensions
    {
        private static ArmResourceExtensionClient GetArmResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ArmResourceExtensionClient(client, resource.Id);
            });
        }

        private static ArmResourceExtensionClient GetArmResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ArmResourceExtensionClient(client, scope);
            });
        }
        #region EndpointResource
        /// <summary>
        /// Gets an object representing an <see cref="EndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EndpointResource.CreateResourceIdentifier" /> to create an <see cref="EndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EndpointResource" /> object. </returns>
        public static EndpointResource GetEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EndpointResource.ValidateResourceId(id);
                return new EndpointResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of EndpointResources in the ArmResource. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of EndpointResources and their operations over a EndpointResource. </returns>
        public static EndpointResourceCollection GetEndpointResources(this ArmClient client, ResourceIdentifier scope)
        {
            return GetArmResourceExtensionClient(client, scope).GetEndpointResources();
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<EndpointResource>> GetEndpointResourceAsync(this ArmClient client, ResourceIdentifier scope, string endpointName, CancellationToken cancellationToken = default)
        {
            return await client.GetEndpointResources(scope).GetAsync(endpointName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<EndpointResource> GetEndpointResource(this ArmClient client, ResourceIdentifier scope, string endpointName, CancellationToken cancellationToken = default)
        {
            return client.GetEndpointResources(scope).Get(endpointName, cancellationToken);
        }
    }
}