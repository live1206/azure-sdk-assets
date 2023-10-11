// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The indicator of whether to evacuate the node workload when the bare metal machine is cordoned. </summary>
    public readonly partial struct BareMetalMachineEvacuate : IEquatable<BareMetalMachineEvacuate>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineEvacuate"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BareMetalMachineEvacuate(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static BareMetalMachineEvacuate True { get; } = new BareMetalMachineEvacuate(TrueValue);
        /// <summary> False. </summary>
        public static BareMetalMachineEvacuate False { get; } = new BareMetalMachineEvacuate(FalseValue);
        /// <summary> Determines if two <see cref="BareMetalMachineEvacuate"/> values are the same. </summary>
        public static bool operator ==(BareMetalMachineEvacuate left, BareMetalMachineEvacuate right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BareMetalMachineEvacuate"/> values are not the same. </summary>
        public static bool operator !=(BareMetalMachineEvacuate left, BareMetalMachineEvacuate right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BareMetalMachineEvacuate"/>. </summary>
        public static implicit operator BareMetalMachineEvacuate(string value) => new BareMetalMachineEvacuate(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BareMetalMachineEvacuate other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BareMetalMachineEvacuate other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}