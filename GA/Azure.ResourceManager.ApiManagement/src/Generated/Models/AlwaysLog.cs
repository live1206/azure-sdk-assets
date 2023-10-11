// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Specifies for what type of messages sampling settings should not apply. </summary>
    public readonly partial struct AlwaysLog : IEquatable<AlwaysLog>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlwaysLog"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlwaysLog(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllErrorsValue = "allErrors";

        /// <summary> Always log all erroneous request regardless of sampling settings. </summary>
        public static AlwaysLog AllErrors { get; } = new AlwaysLog(AllErrorsValue);
        /// <summary> Determines if two <see cref="AlwaysLog"/> values are the same. </summary>
        public static bool operator ==(AlwaysLog left, AlwaysLog right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlwaysLog"/> values are not the same. </summary>
        public static bool operator !=(AlwaysLog left, AlwaysLog right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlwaysLog"/>. </summary>
        public static implicit operator AlwaysLog(string value) => new AlwaysLog(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlwaysLog other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlwaysLog other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}