// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceValidation. </summary>
    public readonly partial struct ResourceValidation : IEquatable<ResourceValidation>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceValidation"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceValidation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string ReservedWordsValue = "ReservedWords";
        private const string ProfaneWordsValue = "ProfaneWords";

        /// <summary> NotSpecified. </summary>
        public static ResourceValidation NotSpecified { get; } = new ResourceValidation(NotSpecifiedValue);
        /// <summary> ReservedWords. </summary>
        public static ResourceValidation ReservedWords { get; } = new ResourceValidation(ReservedWordsValue);
        /// <summary> ProfaneWords. </summary>
        public static ResourceValidation ProfaneWords { get; } = new ResourceValidation(ProfaneWordsValue);
        /// <summary> Determines if two <see cref="ResourceValidation"/> values are the same. </summary>
        public static bool operator ==(ResourceValidation left, ResourceValidation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceValidation"/> values are not the same. </summary>
        public static bool operator !=(ResourceValidation left, ResourceValidation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceValidation"/>. </summary>
        public static implicit operator ResourceValidation(string value) => new ResourceValidation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceValidation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceValidation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}