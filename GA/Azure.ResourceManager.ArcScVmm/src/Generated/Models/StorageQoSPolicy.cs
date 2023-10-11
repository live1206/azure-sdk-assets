// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> The StorageQoSPolicy definition. </summary>
    public partial class StorageQoSPolicy
    {
        /// <summary> Initializes a new instance of StorageQoSPolicy. </summary>
        internal StorageQoSPolicy()
        {
        }

        /// <summary> Initializes a new instance of StorageQoSPolicy. </summary>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="id"> The ID of the QoS policy. </param>
        /// <param name="iopsMaximum"> The maximum IO operations per second. </param>
        /// <param name="iopsMinimum"> The minimum IO operations per second. </param>
        /// <param name="bandwidthLimit"> The Bandwidth Limit for internet traffic. </param>
        /// <param name="policyId"> The underlying policy. </param>
        internal StorageQoSPolicy(string name, string id, long? iopsMaximum, long? iopsMinimum, long? bandwidthLimit, string policyId)
        {
            Name = name;
            Id = id;
            IopsMaximum = iopsMaximum;
            IopsMinimum = iopsMinimum;
            BandwidthLimit = bandwidthLimit;
            PolicyId = policyId;
        }

        /// <summary> The name of the policy. </summary>
        public string Name { get; }
        /// <summary> The ID of the QoS policy. </summary>
        public string Id { get; }
        /// <summary> The maximum IO operations per second. </summary>
        public long? IopsMaximum { get; }
        /// <summary> The minimum IO operations per second. </summary>
        public long? IopsMinimum { get; }
        /// <summary> The Bandwidth Limit for internet traffic. </summary>
        public long? BandwidthLimit { get; }
        /// <summary> The underlying policy. </summary>
        public string PolicyId { get; }
    }
}