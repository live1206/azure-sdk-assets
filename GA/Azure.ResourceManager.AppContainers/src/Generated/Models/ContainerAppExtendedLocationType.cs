// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The type of extendedLocation. </summary>
    public readonly partial struct ContainerAppExtendedLocationType : IEquatable<ContainerAppExtendedLocationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppExtendedLocationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppExtendedLocationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CustomLocationValue = "CustomLocation";

        /// <summary> CustomLocation. </summary>
        public static ContainerAppExtendedLocationType CustomLocation { get; } = new ContainerAppExtendedLocationType(CustomLocationValue);
        /// <summary> Determines if two <see cref="ContainerAppExtendedLocationType"/> values are the same. </summary>
        public static bool operator ==(ContainerAppExtendedLocationType left, ContainerAppExtendedLocationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppExtendedLocationType"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppExtendedLocationType left, ContainerAppExtendedLocationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerAppExtendedLocationType"/>. </summary>
        public static implicit operator ContainerAppExtendedLocationType(string value) => new ContainerAppExtendedLocationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppExtendedLocationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppExtendedLocationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
