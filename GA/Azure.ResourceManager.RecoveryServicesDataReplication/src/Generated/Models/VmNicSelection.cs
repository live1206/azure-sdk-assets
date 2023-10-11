// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Gets or sets the selection type of the NIC. </summary>
    public readonly partial struct VmNicSelection : IEquatable<VmNicSelection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmNicSelection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmNicSelection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSelectedValue = "NotSelected";
        private const string SelectedByUserValue = "SelectedByUser";
        private const string SelectedByDefaultValue = "SelectedByDefault";
        private const string SelectedByUserOverrideValue = "SelectedByUserOverride";

        /// <summary> NotSelected. </summary>
        public static VmNicSelection NotSelected { get; } = new VmNicSelection(NotSelectedValue);
        /// <summary> SelectedByUser. </summary>
        public static VmNicSelection SelectedByUser { get; } = new VmNicSelection(SelectedByUserValue);
        /// <summary> SelectedByDefault. </summary>
        public static VmNicSelection SelectedByDefault { get; } = new VmNicSelection(SelectedByDefaultValue);
        /// <summary> SelectedByUserOverride. </summary>
        public static VmNicSelection SelectedByUserOverride { get; } = new VmNicSelection(SelectedByUserOverrideValue);
        /// <summary> Determines if two <see cref="VmNicSelection"/> values are the same. </summary>
        public static bool operator ==(VmNicSelection left, VmNicSelection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmNicSelection"/> values are not the same. </summary>
        public static bool operator !=(VmNicSelection left, VmNicSelection right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VmNicSelection"/>. </summary>
        public static implicit operator VmNicSelection(string value) => new VmNicSelection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmNicSelection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmNicSelection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}