// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Application type of application. </summary>
    public readonly partial struct VirtualApplicationType : IEquatable<VirtualApplicationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualApplicationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualApplicationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RemoteAppValue = "RemoteApp";
        private const string DesktopValue = "Desktop";

        /// <summary> RemoteApp. </summary>
        public static VirtualApplicationType RemoteApp { get; } = new VirtualApplicationType(RemoteAppValue);
        /// <summary> Desktop. </summary>
        public static VirtualApplicationType Desktop { get; } = new VirtualApplicationType(DesktopValue);
        /// <summary> Determines if two <see cref="VirtualApplicationType"/> values are the same. </summary>
        public static bool operator ==(VirtualApplicationType left, VirtualApplicationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualApplicationType"/> values are not the same. </summary>
        public static bool operator !=(VirtualApplicationType left, VirtualApplicationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualApplicationType"/>. </summary>
        public static implicit operator VirtualApplicationType(string value) => new VirtualApplicationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualApplicationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualApplicationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}