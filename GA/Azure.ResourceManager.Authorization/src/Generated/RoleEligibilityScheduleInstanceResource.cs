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
    /// A Class representing a RoleEligibilityScheduleInstance along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RoleEligibilityScheduleInstanceResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRoleEligibilityScheduleInstanceResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetRoleEligibilityScheduleInstance method.
    /// </summary>
    public partial class RoleEligibilityScheduleInstanceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RoleEligibilityScheduleInstanceResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string roleEligibilityScheduleInstanceName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _roleEligibilityScheduleInstanceClientDiagnostics;
        private readonly RoleEligibilityScheduleInstancesRestOperations _roleEligibilityScheduleInstanceRestClient;
        private readonly RoleEligibilityScheduleInstanceData _data;

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleInstanceResource"/> class for mocking. </summary>
        protected RoleEligibilityScheduleInstanceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RoleEligibilityScheduleInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RoleEligibilityScheduleInstanceResource(ArmClient client, RoleEligibilityScheduleInstanceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RoleEligibilityScheduleInstanceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleEligibilityScheduleInstanceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string roleEligibilityScheduleInstanceApiVersion);
            _roleEligibilityScheduleInstanceRestClient = new RoleEligibilityScheduleInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleEligibilityScheduleInstanceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/roleEligibilityScheduleInstances";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RoleEligibilityScheduleInstanceData Data
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
        /// Gets the specified role eligibility schedule instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RoleEligibilityScheduleInstanceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _roleEligibilityScheduleInstanceClientDiagnostics.CreateScope("RoleEligibilityScheduleInstanceResource.Get");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleInstanceRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified role eligibility schedule instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RoleEligibilityScheduleInstanceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _roleEligibilityScheduleInstanceClientDiagnostics.CreateScope("RoleEligibilityScheduleInstanceResource.Get");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleInstanceRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
