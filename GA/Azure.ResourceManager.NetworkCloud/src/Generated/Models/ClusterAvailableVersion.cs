// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterAvailableVersion represents the cluster version that the cluster manager can be asked to create and manage. </summary>
    public partial class ClusterAvailableVersion
    {
        /// <summary> Initializes a new instance of ClusterAvailableVersion. </summary>
        internal ClusterAvailableVersion()
        {
        }

        /// <summary> Initializes a new instance of ClusterAvailableVersion. </summary>
        /// <param name="supportExpiryDate"> The last date the version of the platform is supported. </param>
        /// <param name="targetClusterVersion"> The version of the cluster to be deployed. </param>
        internal ClusterAvailableVersion(string supportExpiryDate, string targetClusterVersion)
        {
            SupportExpiryDate = supportExpiryDate;
            TargetClusterVersion = targetClusterVersion;
        }

        /// <summary> The last date the version of the platform is supported. </summary>
        public string SupportExpiryDate { get; }
        /// <summary> The version of the cluster to be deployed. </summary>
        public string TargetClusterVersion { get; }
    }
}