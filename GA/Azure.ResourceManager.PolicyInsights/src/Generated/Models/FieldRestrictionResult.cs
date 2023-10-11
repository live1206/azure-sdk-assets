// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The type of restriction that is imposed on the field. </summary>
    public readonly partial struct FieldRestrictionResult : IEquatable<FieldRestrictionResult>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FieldRestrictionResult"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FieldRestrictionResult(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RequiredValue = "Required";
        private const string RemovedValue = "Removed";
        private const string DenyValue = "Deny";

        /// <summary> The field and/or values are required by policy. </summary>
        public static FieldRestrictionResult Required { get; } = new FieldRestrictionResult(RequiredValue);
        /// <summary> The field will be removed by policy. </summary>
        public static FieldRestrictionResult Removed { get; } = new FieldRestrictionResult(RemovedValue);
        /// <summary> The field and/or values will be denied by policy. </summary>
        public static FieldRestrictionResult Deny { get; } = new FieldRestrictionResult(DenyValue);
        /// <summary> Determines if two <see cref="FieldRestrictionResult"/> values are the same. </summary>
        public static bool operator ==(FieldRestrictionResult left, FieldRestrictionResult right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FieldRestrictionResult"/> values are not the same. </summary>
        public static bool operator !=(FieldRestrictionResult left, FieldRestrictionResult right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FieldRestrictionResult"/>. </summary>
        public static implicit operator FieldRestrictionResult(string value) => new FieldRestrictionResult(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FieldRestrictionResult other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FieldRestrictionResult other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}