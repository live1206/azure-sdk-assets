// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Configuration to use NNI for Infrastructure Management. Example: True/False. </summary>
    public readonly partial struct IsManagementType : IEquatable<IsManagementType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IsManagementType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IsManagementType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static IsManagementType True { get; } = new IsManagementType(TrueValue);
        /// <summary> False. </summary>
        public static IsManagementType False { get; } = new IsManagementType(FalseValue);
        /// <summary> Determines if two <see cref="IsManagementType"/> values are the same. </summary>
        public static bool operator ==(IsManagementType left, IsManagementType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IsManagementType"/> values are not the same. </summary>
        public static bool operator !=(IsManagementType left, IsManagementType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IsManagementType"/>. </summary>
        public static implicit operator IsManagementType(string value) => new IsManagementType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IsManagementType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IsManagementType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}