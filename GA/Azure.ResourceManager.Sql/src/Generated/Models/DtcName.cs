// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The DtcName. </summary>
    public readonly partial struct DtcName : IEquatable<DtcName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DtcName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DtcName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentValue = "current";

        /// <summary> current. </summary>
        public static DtcName Current { get; } = new DtcName(CurrentValue);
        /// <summary> Determines if two <see cref="DtcName"/> values are the same. </summary>
        public static bool operator ==(DtcName left, DtcName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DtcName"/> values are not the same. </summary>
        public static bool operator !=(DtcName left, DtcName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DtcName"/>. </summary>
        public static implicit operator DtcName(string value) => new DtcName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DtcName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DtcName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}