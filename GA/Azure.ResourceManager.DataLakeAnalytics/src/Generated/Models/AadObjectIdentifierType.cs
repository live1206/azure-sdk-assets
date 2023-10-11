// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The type of AAD object the object identifier refers to.
    /// Serialized Name: AADObjectType
    /// </summary>
    public readonly partial struct AadObjectIdentifierType : IEquatable<AadObjectIdentifierType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AadObjectIdentifierType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AadObjectIdentifierType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserValue = "User";
        private const string GroupValue = "Group";
        private const string ServicePrincipalValue = "ServicePrincipal";

        /// <summary>
        /// User
        /// Serialized Name: AADObjectType.User
        /// </summary>
        public static AadObjectIdentifierType User { get; } = new AadObjectIdentifierType(UserValue);
        /// <summary>
        /// Group
        /// Serialized Name: AADObjectType.Group
        /// </summary>
        public static AadObjectIdentifierType Group { get; } = new AadObjectIdentifierType(GroupValue);
        /// <summary>
        /// ServicePrincipal
        /// Serialized Name: AADObjectType.ServicePrincipal
        /// </summary>
        public static AadObjectIdentifierType ServicePrincipal { get; } = new AadObjectIdentifierType(ServicePrincipalValue);
        /// <summary> Determines if two <see cref="AadObjectIdentifierType"/> values are the same. </summary>
        public static bool operator ==(AadObjectIdentifierType left, AadObjectIdentifierType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AadObjectIdentifierType"/> values are not the same. </summary>
        public static bool operator !=(AadObjectIdentifierType left, AadObjectIdentifierType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AadObjectIdentifierType"/>. </summary>
        public static implicit operator AadObjectIdentifierType(string value) => new AadObjectIdentifierType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AadObjectIdentifierType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AadObjectIdentifierType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}