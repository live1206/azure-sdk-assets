// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> The managed mode of the server (0 = not managed, 1 = managed). </summary>
    public readonly partial struct AnalysisManagedMode : IEquatable<AnalysisManagedMode>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="AnalysisManagedMode"/>. </summary>
        public AnalysisManagedMode(int value)
        {
            _value = value;
        }

        private const int ZeroValue = 0;
        private const int OneValue = 1;

        /// <summary> 0. </summary>
        public static AnalysisManagedMode Zero { get; } = new AnalysisManagedMode(ZeroValue);
        /// <summary> 1. </summary>
        public static AnalysisManagedMode One { get; } = new AnalysisManagedMode(OneValue);

        internal int ToSerialInt32() => _value;

        /// <summary> Determines if two <see cref="AnalysisManagedMode"/> values are the same. </summary>
        public static bool operator ==(AnalysisManagedMode left, AnalysisManagedMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnalysisManagedMode"/> values are not the same. </summary>
        public static bool operator !=(AnalysisManagedMode left, AnalysisManagedMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AnalysisManagedMode"/>. </summary>
        public static implicit operator AnalysisManagedMode(int value) => new AnalysisManagedMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnalysisManagedMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnalysisManagedMode other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
