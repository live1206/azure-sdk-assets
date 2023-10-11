// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> Whether or not zone redundancy is enabled for this container registry. </summary>
    public readonly partial struct ContainerRegistryZoneRedundancy : IEquatable<ContainerRegistryZoneRedundancy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryZoneRedundancy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryZoneRedundancy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ContainerRegistryZoneRedundancy Enabled { get; } = new ContainerRegistryZoneRedundancy(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ContainerRegistryZoneRedundancy Disabled { get; } = new ContainerRegistryZoneRedundancy(DisabledValue);
        /// <summary> Determines if two <see cref="ContainerRegistryZoneRedundancy"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryZoneRedundancy left, ContainerRegistryZoneRedundancy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryZoneRedundancy"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryZoneRedundancy left, ContainerRegistryZoneRedundancy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerRegistryZoneRedundancy"/>. </summary>
        public static implicit operator ContainerRegistryZoneRedundancy(string value) => new ContainerRegistryZoneRedundancy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryZoneRedundancy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryZoneRedundancy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}