// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> The quota or usages limit types. </summary>
    public readonly partial struct QuotaLimitType : IEquatable<QuotaLimitType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QuotaLimitType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QuotaLimitType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IndependentValue = "Independent";
        private const string SharedValue = "Shared";

        /// <summary> Independent. </summary>
        public static QuotaLimitType Independent { get; } = new QuotaLimitType(IndependentValue);
        /// <summary> Shared. </summary>
        public static QuotaLimitType Shared { get; } = new QuotaLimitType(SharedValue);
        /// <summary> Determines if two <see cref="QuotaLimitType"/> values are the same. </summary>
        public static bool operator ==(QuotaLimitType left, QuotaLimitType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QuotaLimitType"/> values are not the same. </summary>
        public static bool operator !=(QuotaLimitType left, QuotaLimitType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QuotaLimitType"/>. </summary>
        public static implicit operator QuotaLimitType(string value) => new QuotaLimitType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QuotaLimitType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QuotaLimitType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}