// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Trino Coordinator. </summary>
    public partial class TrinoCoordinator
    {
        /// <summary> Initializes a new instance of TrinoCoordinator. </summary>
        public TrinoCoordinator()
        {
        }

        /// <summary> Initializes a new instance of TrinoCoordinator. </summary>
        /// <param name="highAvailabilityEnabled"> The flag that if enable coordinator HA, uses multiple coordinator replicas with auto failover, one per each head node. Default: true. </param>
        /// <param name="isEnabled"> The flag that if enable debug or not. </param>
        /// <param name="port"> The debug port. </param>
        /// <param name="suspend"> The flag that if suspend debug or not. </param>
        internal TrinoCoordinator(bool? highAvailabilityEnabled, bool? isEnabled, int? port, bool? suspend)
        {
            HighAvailabilityEnabled = highAvailabilityEnabled;
            IsEnabled = isEnabled;
            Port = port;
            Suspend = suspend;
        }

        /// <summary> The flag that if enable coordinator HA, uses multiple coordinator replicas with auto failover, one per each head node. Default: true. </summary>
        public bool? HighAvailabilityEnabled { get; set; }
        /// <summary> The flag that if enable debug or not. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The debug port. </summary>
        public int? Port { get; set; }
        /// <summary> The flag that if suspend debug or not. </summary>
        public bool? Suspend { get; set; }
    }
}