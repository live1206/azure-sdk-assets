// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The detailed status of the storage appliance. </summary>
    public readonly partial struct StorageApplianceDetailedStatus : IEquatable<StorageApplianceDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageApplianceDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageApplianceDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string AvailableValue = "Available";
        private const string ProvisioningValue = "Provisioning";

        /// <summary> Error. </summary>
        public static StorageApplianceDetailedStatus Error { get; } = new StorageApplianceDetailedStatus(ErrorValue);
        /// <summary> Available. </summary>
        public static StorageApplianceDetailedStatus Available { get; } = new StorageApplianceDetailedStatus(AvailableValue);
        /// <summary> Provisioning. </summary>
        public static StorageApplianceDetailedStatus Provisioning { get; } = new StorageApplianceDetailedStatus(ProvisioningValue);
        /// <summary> Determines if two <see cref="StorageApplianceDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(StorageApplianceDetailedStatus left, StorageApplianceDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageApplianceDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(StorageApplianceDetailedStatus left, StorageApplianceDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageApplianceDetailedStatus"/>. </summary>
        public static implicit operator StorageApplianceDetailedStatus(string value) => new StorageApplianceDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageApplianceDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageApplianceDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}