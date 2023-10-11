// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Type of encapsulation. </summary>
    public readonly partial struct IsolationDomainEncapsulationType : IEquatable<IsolationDomainEncapsulationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IsolationDomainEncapsulationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IsolationDomainEncapsulationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string GreValue = "GRE";

        /// <summary> None. </summary>
        public static IsolationDomainEncapsulationType None { get; } = new IsolationDomainEncapsulationType(NoneValue);
        /// <summary> GRE. </summary>
        public static IsolationDomainEncapsulationType Gre { get; } = new IsolationDomainEncapsulationType(GreValue);
        /// <summary> Determines if two <see cref="IsolationDomainEncapsulationType"/> values are the same. </summary>
        public static bool operator ==(IsolationDomainEncapsulationType left, IsolationDomainEncapsulationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IsolationDomainEncapsulationType"/> values are not the same. </summary>
        public static bool operator !=(IsolationDomainEncapsulationType left, IsolationDomainEncapsulationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IsolationDomainEncapsulationType"/>. </summary>
        public static implicit operator IsolationDomainEncapsulationType(string value) => new IsolationDomainEncapsulationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IsolationDomainEncapsulationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IsolationDomainEncapsulationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}