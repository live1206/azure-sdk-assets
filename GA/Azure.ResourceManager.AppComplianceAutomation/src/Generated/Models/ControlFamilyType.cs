// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Indicates the control family type. </summary>
    public readonly partial struct ControlFamilyType : IEquatable<ControlFamilyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ControlFamilyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ControlFamilyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FullyAutomatedValue = "FullyAutomated";
        private const string PartiallyAutomatedValue = "PartiallyAutomated";
        private const string ManualValue = "Manual";

        /// <summary> FullyAutomated. </summary>
        public static ControlFamilyType FullyAutomated { get; } = new ControlFamilyType(FullyAutomatedValue);
        /// <summary> PartiallyAutomated. </summary>
        public static ControlFamilyType PartiallyAutomated { get; } = new ControlFamilyType(PartiallyAutomatedValue);
        /// <summary> Manual. </summary>
        public static ControlFamilyType Manual { get; } = new ControlFamilyType(ManualValue);
        /// <summary> Determines if two <see cref="ControlFamilyType"/> values are the same. </summary>
        public static bool operator ==(ControlFamilyType left, ControlFamilyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ControlFamilyType"/> values are not the same. </summary>
        public static bool operator !=(ControlFamilyType left, ControlFamilyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ControlFamilyType"/>. </summary>
        public static implicit operator ControlFamilyType(string value) => new ControlFamilyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ControlFamilyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ControlFamilyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}