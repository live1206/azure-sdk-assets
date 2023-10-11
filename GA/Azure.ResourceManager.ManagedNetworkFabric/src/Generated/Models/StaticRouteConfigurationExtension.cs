// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Extension. Example: NoExtension | NPB. </summary>
    public readonly partial struct StaticRouteConfigurationExtension : IEquatable<StaticRouteConfigurationExtension>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StaticRouteConfigurationExtension"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StaticRouteConfigurationExtension(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoExtensionValue = "NoExtension";
        private const string NpbValue = "NPB";

        /// <summary> NoExtension. </summary>
        public static StaticRouteConfigurationExtension NoExtension { get; } = new StaticRouteConfigurationExtension(NoExtensionValue);
        /// <summary> NPB. </summary>
        public static StaticRouteConfigurationExtension Npb { get; } = new StaticRouteConfigurationExtension(NpbValue);
        /// <summary> Determines if two <see cref="StaticRouteConfigurationExtension"/> values are the same. </summary>
        public static bool operator ==(StaticRouteConfigurationExtension left, StaticRouteConfigurationExtension right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StaticRouteConfigurationExtension"/> values are not the same. </summary>
        public static bool operator !=(StaticRouteConfigurationExtension left, StaticRouteConfigurationExtension right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StaticRouteConfigurationExtension"/>. </summary>
        public static implicit operator StaticRouteConfigurationExtension(string value) => new StaticRouteConfigurationExtension(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StaticRouteConfigurationExtension other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StaticRouteConfigurationExtension other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}