// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The FeaturesPolicy. </summary>
    public readonly partial struct FeaturesPolicy : IEquatable<FeaturesPolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FeaturesPolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FeaturesPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string AllValue = "All";

        /// <summary> Any. </summary>
        public static FeaturesPolicy Any { get; } = new FeaturesPolicy(AnyValue);
        /// <summary> All. </summary>
        public static FeaturesPolicy All { get; } = new FeaturesPolicy(AllValue);
        /// <summary> Determines if two <see cref="FeaturesPolicy"/> values are the same. </summary>
        public static bool operator ==(FeaturesPolicy left, FeaturesPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FeaturesPolicy"/> values are not the same. </summary>
        public static bool operator !=(FeaturesPolicy left, FeaturesPolicy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FeaturesPolicy"/>. </summary>
        public static implicit operator FeaturesPolicy(string value) => new FeaturesPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FeaturesPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FeaturesPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}