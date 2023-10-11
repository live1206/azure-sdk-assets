// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary>
    /// The IP allocation mechanism for the virtual machine.
    /// Dynamic and Static are only valid for l3Network which may also specify Disabled.
    /// Otherwise, Disabled is the only permitted value.
    /// </summary>
    public readonly partial struct VirtualMachineIPAllocationMethod : IEquatable<VirtualMachineIPAllocationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineIPAllocationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualMachineIPAllocationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DynamicValue = "Dynamic";
        private const string StaticValue = "Static";
        private const string DisabledValue = "Disabled";

        /// <summary> Dynamic. </summary>
        public static VirtualMachineIPAllocationMethod Dynamic { get; } = new VirtualMachineIPAllocationMethod(DynamicValue);
        /// <summary> Static. </summary>
        public static VirtualMachineIPAllocationMethod Static { get; } = new VirtualMachineIPAllocationMethod(StaticValue);
        /// <summary> Disabled. </summary>
        public static VirtualMachineIPAllocationMethod Disabled { get; } = new VirtualMachineIPAllocationMethod(DisabledValue);
        /// <summary> Determines if two <see cref="VirtualMachineIPAllocationMethod"/> values are the same. </summary>
        public static bool operator ==(VirtualMachineIPAllocationMethod left, VirtualMachineIPAllocationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualMachineIPAllocationMethod"/> values are not the same. </summary>
        public static bool operator !=(VirtualMachineIPAllocationMethod left, VirtualMachineIPAllocationMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualMachineIPAllocationMethod"/>. </summary>
        public static implicit operator VirtualMachineIPAllocationMethod(string value) => new VirtualMachineIPAllocationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualMachineIPAllocationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualMachineIPAllocationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
