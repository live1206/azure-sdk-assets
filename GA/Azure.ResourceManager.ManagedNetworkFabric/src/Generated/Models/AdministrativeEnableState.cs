// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Administrative state. </summary>
    public readonly partial struct AdministrativeEnableState : IEquatable<AdministrativeEnableState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AdministrativeEnableState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AdministrativeEnableState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnableValue = "Enable";
        private const string DisableValue = "Disable";

        /// <summary> Enable. </summary>
        public static AdministrativeEnableState Enable { get; } = new AdministrativeEnableState(EnableValue);
        /// <summary> Disable. </summary>
        public static AdministrativeEnableState Disable { get; } = new AdministrativeEnableState(DisableValue);
        /// <summary> Determines if two <see cref="AdministrativeEnableState"/> values are the same. </summary>
        public static bool operator ==(AdministrativeEnableState left, AdministrativeEnableState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AdministrativeEnableState"/> values are not the same. </summary>
        public static bool operator !=(AdministrativeEnableState left, AdministrativeEnableState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AdministrativeEnableState"/>. </summary>
        public static implicit operator AdministrativeEnableState(string value) => new AdministrativeEnableState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AdministrativeEnableState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AdministrativeEnableState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}