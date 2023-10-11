// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Private endpoint state for backup. </summary>
    public readonly partial struct VaultPrivateEndpointState : IEquatable<VaultPrivateEndpointState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VaultPrivateEndpointState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VaultPrivateEndpointState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string EnabledValue = "Enabled";

        /// <summary> None. </summary>
        public static VaultPrivateEndpointState None { get; } = new VaultPrivateEndpointState(NoneValue);
        /// <summary> Enabled. </summary>
        public static VaultPrivateEndpointState Enabled { get; } = new VaultPrivateEndpointState(EnabledValue);
        /// <summary> Determines if two <see cref="VaultPrivateEndpointState"/> values are the same. </summary>
        public static bool operator ==(VaultPrivateEndpointState left, VaultPrivateEndpointState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VaultPrivateEndpointState"/> values are not the same. </summary>
        public static bool operator !=(VaultPrivateEndpointState left, VaultPrivateEndpointState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VaultPrivateEndpointState"/>. </summary>
        public static implicit operator VaultPrivateEndpointState(string value) => new VaultPrivateEndpointState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VaultPrivateEndpointState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VaultPrivateEndpointState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}