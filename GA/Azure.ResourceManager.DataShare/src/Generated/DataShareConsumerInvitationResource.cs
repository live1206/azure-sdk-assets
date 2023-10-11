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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A Class representing a DataShareConsumerInvitation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataShareConsumerInvitationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataShareConsumerInvitationResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetDataShareConsumerInvitation method.
    /// </summary>
    public partial class DataShareConsumerInvitationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataShareConsumerInvitationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(AzureLocation location, Guid invitationId)
        {
            var resourceId = $"/providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics;
        private readonly ConsumerInvitationsRestOperations _dataShareConsumerInvitationConsumerInvitationsRestClient;
        private readonly DataShareConsumerInvitationData _data;

        /// <summary> Initializes a new instance of the <see cref="DataShareConsumerInvitationResource"/> class for mocking. </summary>
        protected DataShareConsumerInvitationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataShareConsumerInvitationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataShareConsumerInvitationResource(ArmClient client, DataShareConsumerInvitationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataShareConsumerInvitationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataShareConsumerInvitationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataShareConsumerInvitationConsumerInvitationsApiVersion);
            _dataShareConsumerInvitationConsumerInvitationsRestClient = new ConsumerInvitationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataShareConsumerInvitationConsumerInvitationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataShare/locations/consumerInvitations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataShareConsumerInvitationData Data
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
        /// Get an invitation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerInvitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataShareConsumerInvitationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics.CreateScope("DataShareConsumerInvitationResource.Get");
            scope.Start();
            try
            {
                var response = await _dataShareConsumerInvitationConsumerInvitationsRestClient.GetAsync(new AzureLocation(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareConsumerInvitationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an invitation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerInvitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataShareConsumerInvitationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics.CreateScope("DataShareConsumerInvitationResource.Get");
            scope.Start();
            try
            {
                var response = _dataShareConsumerInvitationConsumerInvitationsRestClient.Get(new AzureLocation(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareConsumerInvitationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}