// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Type of CDN resource used in CheckNameAvailability. </summary>
    public readonly partial struct CdnResourceType : IEquatable<CdnResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CdnResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CdnResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EndpointsValue = "Microsoft.Cdn/Profiles/Endpoints";
        private const string FrontDoorEndpointsValue = "Microsoft.Cdn/Profiles/AfdEndpoints";

        /// <summary> Microsoft.Cdn/Profiles/Endpoints. </summary>
        public static CdnResourceType Endpoints { get; } = new CdnResourceType(EndpointsValue);
        /// <summary> Microsoft.Cdn/Profiles/AfdEndpoints. </summary>
        public static CdnResourceType FrontDoorEndpoints { get; } = new CdnResourceType(FrontDoorEndpointsValue);
        /// <summary> Determines if two <see cref="CdnResourceType"/> values are the same. </summary>
        public static bool operator ==(CdnResourceType left, CdnResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CdnResourceType"/> values are not the same. </summary>
        public static bool operator !=(CdnResourceType left, CdnResourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CdnResourceType"/>. </summary>
        public static implicit operator CdnResourceType(string value) => new CdnResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CdnResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CdnResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}