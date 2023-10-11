// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Lease state of the container. </summary>
    public readonly partial struct StorageLeaseState : IEquatable<StorageLeaseState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageLeaseState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageLeaseState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string LeasedValue = "Leased";
        private const string ExpiredValue = "Expired";
        private const string BreakingValue = "Breaking";
        private const string BrokenValue = "Broken";

        /// <summary> Available. </summary>
        public static StorageLeaseState Available { get; } = new StorageLeaseState(AvailableValue);
        /// <summary> Leased. </summary>
        public static StorageLeaseState Leased { get; } = new StorageLeaseState(LeasedValue);
        /// <summary> Expired. </summary>
        public static StorageLeaseState Expired { get; } = new StorageLeaseState(ExpiredValue);
        /// <summary> Breaking. </summary>
        public static StorageLeaseState Breaking { get; } = new StorageLeaseState(BreakingValue);
        /// <summary> Broken. </summary>
        public static StorageLeaseState Broken { get; } = new StorageLeaseState(BrokenValue);
        /// <summary> Determines if two <see cref="StorageLeaseState"/> values are the same. </summary>
        public static bool operator ==(StorageLeaseState left, StorageLeaseState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageLeaseState"/> values are not the same. </summary>
        public static bool operator !=(StorageLeaseState left, StorageLeaseState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageLeaseState"/>. </summary>
        public static implicit operator StorageLeaseState(string value) => new StorageLeaseState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageLeaseState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageLeaseState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}