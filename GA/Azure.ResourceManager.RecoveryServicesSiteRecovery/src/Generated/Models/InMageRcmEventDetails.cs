// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Event details for InMageRcm provider. </summary>
    public partial class InMageRcmEventDetails : SiteRecoveryEventProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of InMageRcmEventDetails. </summary>
        internal InMageRcmEventDetails()
        {
            InstanceType = "InMageRcm";
        }

        /// <summary> Initializes a new instance of InMageRcmEventDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="protectedItemName"> The protected item name. </param>
        /// <param name="vmName"> The protected item name. </param>
        /// <param name="latestAgentVersion"> The latest agent version. </param>
        /// <param name="jobId"> The job Id. </param>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="applianceName"> The appliance name. </param>
        /// <param name="serverType"> The server type. </param>
        /// <param name="componentDisplayName"> The component display name. </param>
        internal InMageRcmEventDetails(string instanceType, string protectedItemName, string vmName, string latestAgentVersion, ResourceIdentifier jobId, string fabricName, string applianceName, string serverType, string componentDisplayName) : base(instanceType)
        {
            ProtectedItemName = protectedItemName;
            VmName = vmName;
            LatestAgentVersion = latestAgentVersion;
            JobId = jobId;
            FabricName = fabricName;
            ApplianceName = applianceName;
            ServerType = serverType;
            ComponentDisplayName = componentDisplayName;
            InstanceType = instanceType ?? "InMageRcm";
        }

        /// <summary> The protected item name. </summary>
        public string ProtectedItemName { get; }
        /// <summary> The protected item name. </summary>
        public string VmName { get; }
        /// <summary> The latest agent version. </summary>
        public string LatestAgentVersion { get; }
        /// <summary> The job Id. </summary>
        public ResourceIdentifier JobId { get; }
        /// <summary> The fabric name. </summary>
        public string FabricName { get; }
        /// <summary> The appliance name. </summary>
        public string ApplianceName { get; }
        /// <summary> The server type. </summary>
        public string ServerType { get; }
        /// <summary> The component display name. </summary>
        public string ComponentDisplayName { get; }
    }
}