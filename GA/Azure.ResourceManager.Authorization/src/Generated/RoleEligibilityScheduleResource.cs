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

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A Class representing a RoleEligibilitySchedule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RoleEligibilityScheduleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRoleEligibilityScheduleResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetRoleEligibilitySchedule method.
    /// </summary>
    public partial class RoleEligibilityScheduleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RoleEligibilityScheduleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string roleEligibilityScheduleName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _roleEligibilityScheduleClientDiagnostics;
        private readonly RoleEligibilitySchedulesRestOperations _roleEligibilityScheduleRestClient;
        private readonly RoleEligibilityScheduleData _data;

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleResource"/> class for mocking. </summary>
        protected RoleEligibilityScheduleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RoleEligibilityScheduleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RoleEligibilityScheduleResource(ArmClient client, RoleEligibilityScheduleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RoleEligibilityScheduleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleEligibilityScheduleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string roleEligibilityScheduleApiVersion);
            _roleEligibilityScheduleRestClient = new RoleEligibilitySchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleEligibilityScheduleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/roleEligibilitySchedules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RoleEligibilityScheduleData Data
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
        /// Get the specified role eligibility schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RoleEligibilityScheduleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _roleEligibilityScheduleClientDiagnostics.CreateScope("RoleEligibilityScheduleResource.Get");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role eligibility schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RoleEligibilityScheduleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _roleEligibilityScheduleClientDiagnostics.CreateScope("RoleEligibilityScheduleResource.Get");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}