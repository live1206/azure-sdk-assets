// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The current detailed status of the cluster. </summary>
    public readonly partial struct ClusterDetailedStatus : IEquatable<ClusterDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingDeploymentValue = "PendingDeployment";
        private const string DeployingValue = "Deploying";
        private const string RunningValue = "Running";
        private const string UpdatingValue = "Updating";
        private const string DegradedValue = "Degraded";
        private const string DeletingValue = "Deleting";
        private const string DisconnectedValue = "Disconnected";
        private const string FailedValue = "Failed";

        /// <summary> PendingDeployment. </summary>
        public static ClusterDetailedStatus PendingDeployment { get; } = new ClusterDetailedStatus(PendingDeploymentValue);
        /// <summary> Deploying. </summary>
        public static ClusterDetailedStatus Deploying { get; } = new ClusterDetailedStatus(DeployingValue);
        /// <summary> Running. </summary>
        public static ClusterDetailedStatus Running { get; } = new ClusterDetailedStatus(RunningValue);
        /// <summary> Updating. </summary>
        public static ClusterDetailedStatus Updating { get; } = new ClusterDetailedStatus(UpdatingValue);
        /// <summary> Degraded. </summary>
        public static ClusterDetailedStatus Degraded { get; } = new ClusterDetailedStatus(DegradedValue);
        /// <summary> Deleting. </summary>
        public static ClusterDetailedStatus Deleting { get; } = new ClusterDetailedStatus(DeletingValue);
        /// <summary> Disconnected. </summary>
        public static ClusterDetailedStatus Disconnected { get; } = new ClusterDetailedStatus(DisconnectedValue);
        /// <summary> Failed. </summary>
        public static ClusterDetailedStatus Failed { get; } = new ClusterDetailedStatus(FailedValue);
        /// <summary> Determines if two <see cref="ClusterDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(ClusterDetailedStatus left, ClusterDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(ClusterDetailedStatus left, ClusterDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClusterDetailedStatus"/>. </summary>
        public static implicit operator ClusterDetailedStatus(string value) => new ClusterDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}