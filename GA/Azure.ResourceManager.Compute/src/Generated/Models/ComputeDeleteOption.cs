// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specify what happens to the network interface when the VM is deleted. </summary>
    public readonly partial struct ComputeDeleteOption : IEquatable<ComputeDeleteOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeDeleteOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeDeleteOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeleteValue = "Delete";
        private const string DetachValue = "Detach";

        /// <summary> Delete. </summary>
        public static ComputeDeleteOption Delete { get; } = new ComputeDeleteOption(DeleteValue);
        /// <summary> Detach. </summary>
        public static ComputeDeleteOption Detach { get; } = new ComputeDeleteOption(DetachValue);
        /// <summary> Determines if two <see cref="ComputeDeleteOption"/> values are the same. </summary>
        public static bool operator ==(ComputeDeleteOption left, ComputeDeleteOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeDeleteOption"/> values are not the same. </summary>
        public static bool operator !=(ComputeDeleteOption left, ComputeDeleteOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComputeDeleteOption"/>. </summary>
        public static implicit operator ComputeDeleteOption(string value) => new ComputeDeleteOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeDeleteOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeDeleteOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}