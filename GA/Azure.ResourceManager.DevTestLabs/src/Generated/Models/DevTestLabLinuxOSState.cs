// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> The state of the Linux OS (i.e. NonDeprovisioned, DeprovisionRequested, DeprovisionApplied). </summary>
    public readonly partial struct DevTestLabLinuxOSState : IEquatable<DevTestLabLinuxOSState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevTestLabLinuxOSState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevTestLabLinuxOSState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NonDeprovisionedValue = "NonDeprovisioned";
        private const string DeprovisionRequestedValue = "DeprovisionRequested";
        private const string DeprovisionAppliedValue = "DeprovisionApplied";

        /// <summary> NonDeprovisioned. </summary>
        public static DevTestLabLinuxOSState NonDeprovisioned { get; } = new DevTestLabLinuxOSState(NonDeprovisionedValue);
        /// <summary> DeprovisionRequested. </summary>
        public static DevTestLabLinuxOSState DeprovisionRequested { get; } = new DevTestLabLinuxOSState(DeprovisionRequestedValue);
        /// <summary> DeprovisionApplied. </summary>
        public static DevTestLabLinuxOSState DeprovisionApplied { get; } = new DevTestLabLinuxOSState(DeprovisionAppliedValue);
        /// <summary> Determines if two <see cref="DevTestLabLinuxOSState"/> values are the same. </summary>
        public static bool operator ==(DevTestLabLinuxOSState left, DevTestLabLinuxOSState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevTestLabLinuxOSState"/> values are not the same. </summary>
        public static bool operator !=(DevTestLabLinuxOSState left, DevTestLabLinuxOSState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevTestLabLinuxOSState"/>. </summary>
        public static implicit operator DevTestLabLinuxOSState(string value) => new DevTestLabLinuxOSState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevTestLabLinuxOSState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevTestLabLinuxOSState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}