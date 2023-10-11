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

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A Class representing a DataProtectionBackupRecoveryPoint along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataProtectionBackupRecoveryPointResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataProtectionBackupRecoveryPointResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataProtectionBackupInstanceResource" /> using the GetDataProtectionBackupRecoveryPoint method.
    /// </summary>
    public partial class DataProtectionBackupRecoveryPointResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataProtectionBackupRecoveryPointResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName, string recoveryPointId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints/{recoveryPointId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics;
        private readonly RecoveryPointsRestOperations _dataProtectionBackupRecoveryPointRecoveryPointsRestClient;
        private readonly DataProtectionBackupRecoveryPointData _data;

        /// <summary> Initializes a new instance of the <see cref="DataProtectionBackupRecoveryPointResource"/> class for mocking. </summary>
        protected DataProtectionBackupRecoveryPointResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataProtectionBackupRecoveryPointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataProtectionBackupRecoveryPointResource(ArmClient client, DataProtectionBackupRecoveryPointData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataProtectionBackupRecoveryPointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataProtectionBackupRecoveryPointResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataProtectionBackup", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataProtectionBackupRecoveryPointRecoveryPointsApiVersion);
            _dataProtectionBackupRecoveryPointRecoveryPointsRestClient = new RecoveryPointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataProtectionBackupRecoveryPointRecoveryPointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataProtection/backupVaults/backupInstances/recoveryPoints";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataProtectionBackupRecoveryPointData Data
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
        /// Gets a Recovery Point using recoveryPointId for a Datasource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataProtectionBackupRecoveryPointResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataProtectionBackupRecoveryPointResource.Get");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Recovery Point using recoveryPointId for a Datasource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataProtectionBackupRecoveryPointResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataProtectionBackupRecoveryPointResource.Get");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
