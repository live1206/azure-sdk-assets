// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Membership type of the role assignment schedule. </summary>
    public readonly partial struct RoleManagementScheduleMemberType : IEquatable<RoleManagementScheduleMemberType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoleManagementScheduleMemberType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoleManagementScheduleMemberType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InheritedValue = "Inherited";
        private const string DirectValue = "Direct";
        private const string GroupValue = "Group";

        /// <summary> Inherited. </summary>
        public static RoleManagementScheduleMemberType Inherited { get; } = new RoleManagementScheduleMemberType(InheritedValue);
        /// <summary> Direct. </summary>
        public static RoleManagementScheduleMemberType Direct { get; } = new RoleManagementScheduleMemberType(DirectValue);
        /// <summary> Group. </summary>
        public static RoleManagementScheduleMemberType Group { get; } = new RoleManagementScheduleMemberType(GroupValue);
        /// <summary> Determines if two <see cref="RoleManagementScheduleMemberType"/> values are the same. </summary>
        public static bool operator ==(RoleManagementScheduleMemberType left, RoleManagementScheduleMemberType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoleManagementScheduleMemberType"/> values are not the same. </summary>
        public static bool operator !=(RoleManagementScheduleMemberType left, RoleManagementScheduleMemberType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoleManagementScheduleMemberType"/>. </summary>
        public static implicit operator RoleManagementScheduleMemberType(string value) => new RoleManagementScheduleMemberType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoleManagementScheduleMemberType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoleManagementScheduleMemberType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}