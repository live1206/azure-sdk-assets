// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Resource Type of ApplicationGroup. </summary>
    public readonly partial struct VirtualApplicationGroupType : IEquatable<VirtualApplicationGroupType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualApplicationGroupType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualApplicationGroupType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RemoteAppValue = "RemoteApp";
        private const string DesktopValue = "Desktop";

        /// <summary> RemoteApp. </summary>
        public static VirtualApplicationGroupType RemoteApp { get; } = new VirtualApplicationGroupType(RemoteAppValue);
        /// <summary> Desktop. </summary>
        public static VirtualApplicationGroupType Desktop { get; } = new VirtualApplicationGroupType(DesktopValue);
        /// <summary> Determines if two <see cref="VirtualApplicationGroupType"/> values are the same. </summary>
        public static bool operator ==(VirtualApplicationGroupType left, VirtualApplicationGroupType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualApplicationGroupType"/> values are not the same. </summary>
        public static bool operator !=(VirtualApplicationGroupType left, VirtualApplicationGroupType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualApplicationGroupType"/>. </summary>
        public static implicit operator VirtualApplicationGroupType(string value) => new VirtualApplicationGroupType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualApplicationGroupType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualApplicationGroupType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}