// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    /// <summary> The endpoint access for the target resource. </summary>
    public partial class TargetResourceEndpointAccess
    {
        /// <summary> Initializes a new instance of TargetResourceEndpointAccess. </summary>
        internal TargetResourceEndpointAccess()
        {
        }

        /// <summary> Initializes a new instance of TargetResourceEndpointAccess. </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="namespaceNameSuffix"> The suffix domain name of relay namespace. </param>
        /// <param name="hybridConnectionName"> Azure Relay hybrid connection name for the resource. </param>
        /// <param name="accessKey"> Access key for hybrid connection. </param>
        /// <param name="expiresOn"> The expiration of access key in unix time. </param>
        internal TargetResourceEndpointAccess(string namespaceName, string namespaceNameSuffix, string hybridConnectionName, string accessKey, long? expiresOn)
        {
            NamespaceName = namespaceName;
            NamespaceNameSuffix = namespaceNameSuffix;
            HybridConnectionName = hybridConnectionName;
            AccessKey = accessKey;
            ExpiresOn = expiresOn;
        }

        /// <summary> The namespace name. </summary>
        public string NamespaceName { get; }
        /// <summary> The suffix domain name of relay namespace. </summary>
        public string NamespaceNameSuffix { get; }
        /// <summary> Azure Relay hybrid connection name for the resource. </summary>
        public string HybridConnectionName { get; }
        /// <summary> Access key for hybrid connection. </summary>
        public string AccessKey { get; }
        /// <summary> The expiration of access key in unix time. </summary>
        public long? ExpiresOn { get; }
    }
}