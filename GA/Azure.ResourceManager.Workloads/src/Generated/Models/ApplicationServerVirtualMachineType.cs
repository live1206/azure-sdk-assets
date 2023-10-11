// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the type of application server VM. </summary>
    public readonly partial struct ApplicationServerVirtualMachineType : IEquatable<ApplicationServerVirtualMachineType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationServerVirtualMachineType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationServerVirtualMachineType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string StandbyValue = "Standby";
        private const string UnknownValue = "Unknown";

        /// <summary> Active. </summary>
        public static ApplicationServerVirtualMachineType Active { get; } = new ApplicationServerVirtualMachineType(ActiveValue);
        /// <summary> Standby. </summary>
        public static ApplicationServerVirtualMachineType Standby { get; } = new ApplicationServerVirtualMachineType(StandbyValue);
        /// <summary> Unknown. </summary>
        public static ApplicationServerVirtualMachineType Unknown { get; } = new ApplicationServerVirtualMachineType(UnknownValue);
        /// <summary> Determines if two <see cref="ApplicationServerVirtualMachineType"/> values are the same. </summary>
        public static bool operator ==(ApplicationServerVirtualMachineType left, ApplicationServerVirtualMachineType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationServerVirtualMachineType"/> values are not the same. </summary>
        public static bool operator !=(ApplicationServerVirtualMachineType left, ApplicationServerVirtualMachineType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationServerVirtualMachineType"/>. </summary>
        public static implicit operator ApplicationServerVirtualMachineType(string value) => new ApplicationServerVirtualMachineType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationServerVirtualMachineType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationServerVirtualMachineType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}