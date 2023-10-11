// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The CapacityReservationGroupGetExpand. </summary>
    public readonly partial struct CapacityReservationGroupGetExpand : IEquatable<CapacityReservationGroupGetExpand>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CapacityReservationGroupGetExpand"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CapacityReservationGroupGetExpand(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VirtualMachineScaleSetVmsRefValue = "virtualMachineScaleSetVMs/$ref";
        private const string VirtualMachinesRefValue = "virtualMachines/$ref";

        /// <summary> virtualMachineScaleSetVMs/$ref. </summary>
        public static CapacityReservationGroupGetExpand VirtualMachineScaleSetVmsRef { get; } = new CapacityReservationGroupGetExpand(VirtualMachineScaleSetVmsRefValue);
        /// <summary> virtualMachines/$ref. </summary>
        public static CapacityReservationGroupGetExpand VirtualMachinesRef { get; } = new CapacityReservationGroupGetExpand(VirtualMachinesRefValue);
        /// <summary> Determines if two <see cref="CapacityReservationGroupGetExpand"/> values are the same. </summary>
        public static bool operator ==(CapacityReservationGroupGetExpand left, CapacityReservationGroupGetExpand right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CapacityReservationGroupGetExpand"/> values are not the same. </summary>
        public static bool operator !=(CapacityReservationGroupGetExpand left, CapacityReservationGroupGetExpand right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CapacityReservationGroupGetExpand"/>. </summary>
        public static implicit operator CapacityReservationGroupGetExpand(string value) => new CapacityReservationGroupGetExpand(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CapacityReservationGroupGetExpand other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CapacityReservationGroupGetExpand other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}