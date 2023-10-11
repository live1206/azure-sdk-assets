// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Last backup operation status. Possible values: Healthy, Unhealthy. </summary>
    public readonly partial struct LastBackupStatus : IEquatable<LastBackupStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LastBackupStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LastBackupStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string HealthyValue = "Healthy";
        private const string UnhealthyValue = "Unhealthy";
        private const string IRPendingValue = "IRPending";

        /// <summary> Invalid. </summary>
        public static LastBackupStatus Invalid { get; } = new LastBackupStatus(InvalidValue);
        /// <summary> Healthy. </summary>
        public static LastBackupStatus Healthy { get; } = new LastBackupStatus(HealthyValue);
        /// <summary> Unhealthy. </summary>
        public static LastBackupStatus Unhealthy { get; } = new LastBackupStatus(UnhealthyValue);
        /// <summary> IRPending. </summary>
        public static LastBackupStatus IRPending { get; } = new LastBackupStatus(IRPendingValue);
        /// <summary> Determines if two <see cref="LastBackupStatus"/> values are the same. </summary>
        public static bool operator ==(LastBackupStatus left, LastBackupStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LastBackupStatus"/> values are not the same. </summary>
        public static bool operator !=(LastBackupStatus left, LastBackupStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LastBackupStatus"/>. </summary>
        public static implicit operator LastBackupStatus(string value) => new LastBackupStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LastBackupStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LastBackupStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}