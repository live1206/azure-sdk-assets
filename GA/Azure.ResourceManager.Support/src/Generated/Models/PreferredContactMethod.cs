// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Preferred contact method. </summary>
    public readonly partial struct PreferredContactMethod : IEquatable<PreferredContactMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PreferredContactMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PreferredContactMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EmailValue = "email";
        private const string PhoneValue = "phone";

        /// <summary> email. </summary>
        public static PreferredContactMethod Email { get; } = new PreferredContactMethod(EmailValue);
        /// <summary> phone. </summary>
        public static PreferredContactMethod Phone { get; } = new PreferredContactMethod(PhoneValue);
        /// <summary> Determines if two <see cref="PreferredContactMethod"/> values are the same. </summary>
        public static bool operator ==(PreferredContactMethod left, PreferredContactMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PreferredContactMethod"/> values are not the same. </summary>
        public static bool operator !=(PreferredContactMethod left, PreferredContactMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PreferredContactMethod"/>. </summary>
        public static implicit operator PreferredContactMethod(string value) => new PreferredContactMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PreferredContactMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PreferredContactMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}