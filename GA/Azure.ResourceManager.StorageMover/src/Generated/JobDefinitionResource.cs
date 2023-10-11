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
using Azure.ResourceManager.StorageMover.Models;

namespace Azure.ResourceManager.StorageMover
{
    /// <summary>
    /// A Class representing a JobDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="JobDefinitionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetJobDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="StorageMoverProjectResource" /> using the GetJobDefinition method.
    /// </summary>
    public partial class JobDefinitionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="JobDefinitionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string storageMoverName, string projectName, string jobDefinitionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _jobDefinitionClientDiagnostics;
        private readonly JobDefinitionsRestOperations _jobDefinitionRestClient;
        private readonly JobDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="JobDefinitionResource"/> class for mocking. </summary>
        protected JobDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "JobDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal JobDefinitionResource(ArmClient client, JobDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="JobDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal JobDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jobDefinitionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageMover", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string jobDefinitionApiVersion);
            _jobDefinitionRestClient = new JobDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, jobDefinitionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StorageMover/storageMovers/projects/jobDefinitions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual JobDefinitionData Data
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

        /// <summary> Gets a collection of JobRunResources in the JobDefinition. </summary>
        /// <returns> An object representing collection of JobRunResources and their operations over a JobRunResource. </returns>
        public virtual JobRunCollection GetJobRuns()
        {
            return GetCachedClient(Client => new JobRunCollection(Client, Id));
        }

        /// <summary>
        /// Gets a Job Run resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobRunName"> The name of the Job Run resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobRunName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<JobRunResource>> GetJobRunAsync(string jobRunName, CancellationToken cancellationToken = default)
        {
            return await GetJobRuns().GetAsync(jobRunName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Job Run resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobRunName"> The name of the Job Run resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobRunName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<JobRunResource> GetJobRun(string jobRunName, CancellationToken cancellationToken = default)
        {
            return GetJobRuns().Get(jobRunName, cancellationToken);
        }

        /// <summary>
        /// Gets a Job Definition resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _jobDefinitionClientDiagnostics.CreateScope("JobDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _jobDefinitionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Job Definition resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _jobDefinitionClientDiagnostics.CreateScope("JobDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _jobDefinitionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Job Definition resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDefinitions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _jobDefinitionClientDiagnostics.CreateScope("JobDefinitionResource.Delete");
            scope.Start();
            try
            {
                var response = await _jobDefinitionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new StorageMoverArmOperation(_jobDefinitionClientDiagnostics, Pipeline, _jobDefinitionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Job Definition resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDefinitions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _jobDefinitionClientDiagnostics.CreateScope("JobDefinitionResource.Delete");
            scope.Start();
            try
            {
                var response = _jobDefinitionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new StorageMoverArmOperation(_jobDefinitionClientDiagnostics, Pipeline, _jobDefinitionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates properties for a Job Definition resource. Properties not specified in the request body will be unchanged.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDefinitions_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The JobDefinitionPatch to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<JobDefinitionResource>> UpdateAsync(JobDefinitionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _jobDefinitionClientDiagnostics.CreateScope("JobDefinitionResource.Update");
            scope.Start();
            try
            {
                var response = await _jobDefinitionRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new JobDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates properties for a Job Definition resource. Properties not specified in the request body will be unchanged.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDefinitions_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The JobDefinitionPatch to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<JobDefinitionResource> Update(JobDefinitionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _jobDefinitionClientDiagnostics.CreateScope("JobDefinitionResource.Update");
            scope.Start();
            try
            {
                var response = _jobDefinitionRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new JobDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Requests an Agent to start a new instance of this Job Definition, generating a new Job Run resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/startJob</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDefinitions_StartJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobRunResourceId>> StartJobAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _jobDefinitionClientDiagnostics.CreateScope("JobDefinitionResource.StartJob");
            scope.Start();
            try
            {
                var response = await _jobDefinitionRestClient.StartJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Requests an Agent to start a new instance of this Job Definition, generating a new Job Run resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/startJob</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDefinitions_StartJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobRunResourceId> StartJob(CancellationToken cancellationToken = default)
        {
            using var scope = _jobDefinitionClientDiagnostics.CreateScope("JobDefinitionResource.StartJob");
            scope.Start();
            try
            {
                var response = _jobDefinitionRestClient.StartJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Requests the Agent of any active instance of this Job Definition to stop.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/stopJob</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDefinitions_StopJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobRunResourceId>> StopJobAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _jobDefinitionClientDiagnostics.CreateScope("JobDefinitionResource.StopJob");
            scope.Start();
            try
            {
                var response = await _jobDefinitionRestClient.StopJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Requests the Agent of any active instance of this Job Definition to stop.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/stopJob</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDefinitions_StopJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobRunResourceId> StopJob(CancellationToken cancellationToken = default)
        {
            using var scope = _jobDefinitionClientDiagnostics.CreateScope("JobDefinitionResource.StopJob");
            scope.Start();
            try
            {
                var response = _jobDefinitionRestClient.StopJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
