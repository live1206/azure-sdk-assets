// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The type of execution parameter. </summary>
    internal readonly partial struct ScriptExecutionParameterType : IEquatable<ScriptExecutionParameterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScriptExecutionParameterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScriptExecutionParameterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValueValue = "Value";
        private const string SecureValueValue = "SecureValue";
        private const string CredentialValue = "Credential";

        /// <summary> Value. </summary>
        public static ScriptExecutionParameterType Value { get; } = new ScriptExecutionParameterType(ValueValue);
        /// <summary> SecureValue. </summary>
        public static ScriptExecutionParameterType SecureValue { get; } = new ScriptExecutionParameterType(SecureValueValue);
        /// <summary> Credential. </summary>
        public static ScriptExecutionParameterType Credential { get; } = new ScriptExecutionParameterType(CredentialValue);
        /// <summary> Determines if two <see cref="ScriptExecutionParameterType"/> values are the same. </summary>
        public static bool operator ==(ScriptExecutionParameterType left, ScriptExecutionParameterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScriptExecutionParameterType"/> values are not the same. </summary>
        public static bool operator !=(ScriptExecutionParameterType left, ScriptExecutionParameterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScriptExecutionParameterType"/>. </summary>
        public static implicit operator ScriptExecutionParameterType(string value) => new ScriptExecutionParameterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScriptExecutionParameterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScriptExecutionParameterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}