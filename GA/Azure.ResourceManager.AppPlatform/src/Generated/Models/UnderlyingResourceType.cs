// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The type of the underlying resource to mount as a persistent disk. </summary>
    internal readonly partial struct UnderlyingResourceType : IEquatable<UnderlyingResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UnderlyingResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UnderlyingResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureFileVolumeValue = "AzureFileVolume";

        /// <summary> AzureFileVolume. </summary>
        public static UnderlyingResourceType AzureFileVolume { get; } = new UnderlyingResourceType(AzureFileVolumeValue);
        /// <summary> Determines if two <see cref="UnderlyingResourceType"/> values are the same. </summary>
        public static bool operator ==(UnderlyingResourceType left, UnderlyingResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UnderlyingResourceType"/> values are not the same. </summary>
        public static bool operator !=(UnderlyingResourceType left, UnderlyingResourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UnderlyingResourceType"/>. </summary>
        public static implicit operator UnderlyingResourceType(string value) => new UnderlyingResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UnderlyingResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UnderlyingResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}