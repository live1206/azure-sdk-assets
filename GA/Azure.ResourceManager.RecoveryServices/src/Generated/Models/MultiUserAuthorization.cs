// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> MUA Settings of vault. </summary>
    public readonly partial struct MultiUserAuthorization : IEquatable<MultiUserAuthorization>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MultiUserAuthorization"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MultiUserAuthorization(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Invalid. </summary>
        public static MultiUserAuthorization Invalid { get; } = new MultiUserAuthorization(InvalidValue);
        /// <summary> Enabled. </summary>
        public static MultiUserAuthorization Enabled { get; } = new MultiUserAuthorization(EnabledValue);
        /// <summary> Disabled. </summary>
        public static MultiUserAuthorization Disabled { get; } = new MultiUserAuthorization(DisabledValue);
        /// <summary> Determines if two <see cref="MultiUserAuthorization"/> values are the same. </summary>
        public static bool operator ==(MultiUserAuthorization left, MultiUserAuthorization right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MultiUserAuthorization"/> values are not the same. </summary>
        public static bool operator !=(MultiUserAuthorization left, MultiUserAuthorization right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MultiUserAuthorization"/>. </summary>
        public static implicit operator MultiUserAuthorization(string value) => new MultiUserAuthorization(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MultiUserAuthorization other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MultiUserAuthorization other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}