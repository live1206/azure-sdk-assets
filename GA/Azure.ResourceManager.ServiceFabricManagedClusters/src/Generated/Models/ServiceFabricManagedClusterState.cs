// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary>
    /// The current state of the cluster.
    ///
    /// </summary>
    public readonly partial struct ServiceFabricManagedClusterState : IEquatable<ServiceFabricManagedClusterState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedClusterState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceFabricManagedClusterState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WaitingForNodesValue = "WaitingForNodes";
        private const string DeployingValue = "Deploying";
        private const string BaselineUpgradeValue = "BaselineUpgrade";
        private const string UpgradingValue = "Upgrading";
        private const string UpgradeFailedValue = "UpgradeFailed";
        private const string ReadyValue = "Ready";

        /// <summary> Indicates that the cluster resource is created and the resource provider is waiting for Service Fabric VM extension to boot up and report to it. </summary>
        public static ServiceFabricManagedClusterState WaitingForNodes { get; } = new ServiceFabricManagedClusterState(WaitingForNodesValue);
        /// <summary> Indicates that the Service Fabric runtime is being installed on the VMs. Cluster resource will be in this state until the cluster boots up and system services are up. </summary>
        public static ServiceFabricManagedClusterState Deploying { get; } = new ServiceFabricManagedClusterState(DeployingValue);
        /// <summary> Indicates that the cluster is upgrading to establishes the cluster version. This upgrade is automatically initiated when the cluster boots up for the first time. </summary>
        public static ServiceFabricManagedClusterState BaselineUpgrade { get; } = new ServiceFabricManagedClusterState(BaselineUpgradeValue);
        /// <summary> Indicates that the cluster is being upgraded with the user provided configuration. </summary>
        public static ServiceFabricManagedClusterState Upgrading { get; } = new ServiceFabricManagedClusterState(UpgradingValue);
        /// <summary> Indicates that the last upgrade for the cluster has failed. </summary>
        public static ServiceFabricManagedClusterState UpgradeFailed { get; } = new ServiceFabricManagedClusterState(UpgradeFailedValue);
        /// <summary> Indicates that the cluster is in a stable state. </summary>
        public static ServiceFabricManagedClusterState Ready { get; } = new ServiceFabricManagedClusterState(ReadyValue);
        /// <summary> Determines if two <see cref="ServiceFabricManagedClusterState"/> values are the same. </summary>
        public static bool operator ==(ServiceFabricManagedClusterState left, ServiceFabricManagedClusterState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceFabricManagedClusterState"/> values are not the same. </summary>
        public static bool operator !=(ServiceFabricManagedClusterState left, ServiceFabricManagedClusterState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceFabricManagedClusterState"/>. </summary>
        public static implicit operator ServiceFabricManagedClusterState(string value) => new ServiceFabricManagedClusterState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceFabricManagedClusterState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceFabricManagedClusterState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}