// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The available sub plans. </summary>
    public readonly partial struct AvailableSubPlanType : IEquatable<AvailableSubPlanType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvailableSubPlanType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvailableSubPlanType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string P1Value = "P1";
        private const string P2Value = "P2";

        /// <summary> P1. </summary>
        public static AvailableSubPlanType P1 { get; } = new AvailableSubPlanType(P1Value);
        /// <summary> P2. </summary>
        public static AvailableSubPlanType P2 { get; } = new AvailableSubPlanType(P2Value);
        /// <summary> Determines if two <see cref="AvailableSubPlanType"/> values are the same. </summary>
        public static bool operator ==(AvailableSubPlanType left, AvailableSubPlanType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvailableSubPlanType"/> values are not the same. </summary>
        public static bool operator !=(AvailableSubPlanType left, AvailableSubPlanType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvailableSubPlanType"/>. </summary>
        public static implicit operator AvailableSubPlanType(string value) => new AvailableSubPlanType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvailableSubPlanType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvailableSubPlanType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}