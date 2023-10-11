// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> The MoverDependencyLevel. </summary>
    public readonly partial struct MoverDependencyLevel : IEquatable<MoverDependencyLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MoverDependencyLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MoverDependencyLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DirectValue = "Direct";
        private const string DescendantValue = "Descendant";

        /// <summary> Direct. </summary>
        public static MoverDependencyLevel Direct { get; } = new MoverDependencyLevel(DirectValue);
        /// <summary> Descendant. </summary>
        public static MoverDependencyLevel Descendant { get; } = new MoverDependencyLevel(DescendantValue);
        /// <summary> Determines if two <see cref="MoverDependencyLevel"/> values are the same. </summary>
        public static bool operator ==(MoverDependencyLevel left, MoverDependencyLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MoverDependencyLevel"/> values are not the same. </summary>
        public static bool operator !=(MoverDependencyLevel left, MoverDependencyLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MoverDependencyLevel"/>. </summary>
        public static implicit operator MoverDependencyLevel(string value) => new MoverDependencyLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MoverDependencyLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MoverDependencyLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}