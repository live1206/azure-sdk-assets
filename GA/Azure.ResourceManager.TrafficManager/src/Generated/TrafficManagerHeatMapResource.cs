// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary>
    /// A Class representing a TrafficManagerHeatMap along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TrafficManagerHeatMapResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTrafficManagerHeatMapResource method.
    /// Otherwise you can get one from its parent resource <see cref="TrafficManagerProfileResource" /> using the GetTrafficManagerHeatMap method.
    /// </summary>
    public partial class TrafficManagerHeatMapResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TrafficManagerHeatMapResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, TrafficManagerHeatMapType heatMapType)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/heatMaps/{heatMapType}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _trafficManagerHeatMapHeatMapClientDiagnostics;
        private readonly HeatMapRestOperations _trafficManagerHeatMapHeatMapRestClient;
        private readonly TrafficManagerHeatMapData _data;

        /// <summary> Initializes a new instance of the <see cref="TrafficManagerHeatMapResource"/> class for mocking. </summary>
        protected TrafficManagerHeatMapResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TrafficManagerHeatMapResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TrafficManagerHeatMapResource(ArmClient client, TrafficManagerHeatMapData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TrafficManagerHeatMapResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TrafficManagerHeatMapResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _trafficManagerHeatMapHeatMapClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.TrafficManager", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string trafficManagerHeatMapHeatMapApiVersion);
            _trafficManagerHeatMapHeatMapRestClient = new HeatMapRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, trafficManagerHeatMapHeatMapApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/trafficmanagerprofiles/heatMaps";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TrafficManagerHeatMapData Data
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
        /// Gets latest heatmap for Traffic Manager profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/heatMaps/{heatMapType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HeatMap_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topLeft"> The top left latitude,longitude pair of the rectangular viewport to query for. </param>
        /// <param name="botRight"> The bottom right latitude,longitude pair of the rectangular viewport to query for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TrafficManagerHeatMapResource>> GetAsync(IEnumerable<double> topLeft = null, IEnumerable<double> botRight = null, CancellationToken cancellationToken = default)
        {
            using var scope = _trafficManagerHeatMapHeatMapClientDiagnostics.CreateScope("TrafficManagerHeatMapResource.Get");
            scope.Start();
            try
            {
                var response = await _trafficManagerHeatMapHeatMapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, topLeft, botRight, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TrafficManagerHeatMapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets latest heatmap for Traffic Manager profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/heatMaps/{heatMapType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HeatMap_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topLeft"> The top left latitude,longitude pair of the rectangular viewport to query for. </param>
        /// <param name="botRight"> The bottom right latitude,longitude pair of the rectangular viewport to query for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TrafficManagerHeatMapResource> Get(IEnumerable<double> topLeft = null, IEnumerable<double> botRight = null, CancellationToken cancellationToken = default)
        {
            using var scope = _trafficManagerHeatMapHeatMapClientDiagnostics.CreateScope("TrafficManagerHeatMapResource.Get");
            scope.Start();
            try
            {
                var response = _trafficManagerHeatMapHeatMapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, topLeft, botRight, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TrafficManagerHeatMapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}