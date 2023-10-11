// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The type of the column data. </summary>
    public readonly partial struct DataColumnDefinitionType : IEquatable<DataColumnDefinitionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataColumnDefinitionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataColumnDefinitionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "string";
        private const string IntValue = "int";
        private const string LongValue = "long";
        private const string RealValue = "real";
        private const string BooleanValue = "boolean";
        private const string DatetimeValue = "datetime";
        private const string DynamicValue = "dynamic";

        /// <summary> string. </summary>
        public static DataColumnDefinitionType String { get; } = new DataColumnDefinitionType(StringValue);
        /// <summary> int. </summary>
        public static DataColumnDefinitionType Int { get; } = new DataColumnDefinitionType(IntValue);
        /// <summary> long. </summary>
        public static DataColumnDefinitionType Long { get; } = new DataColumnDefinitionType(LongValue);
        /// <summary> real. </summary>
        public static DataColumnDefinitionType Real { get; } = new DataColumnDefinitionType(RealValue);
        /// <summary> boolean. </summary>
        public static DataColumnDefinitionType Boolean { get; } = new DataColumnDefinitionType(BooleanValue);
        /// <summary> datetime. </summary>
        public static DataColumnDefinitionType Datetime { get; } = new DataColumnDefinitionType(DatetimeValue);
        /// <summary> dynamic. </summary>
        public static DataColumnDefinitionType Dynamic { get; } = new DataColumnDefinitionType(DynamicValue);
        /// <summary> Determines if two <see cref="DataColumnDefinitionType"/> values are the same. </summary>
        public static bool operator ==(DataColumnDefinitionType left, DataColumnDefinitionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataColumnDefinitionType"/> values are not the same. </summary>
        public static bool operator !=(DataColumnDefinitionType left, DataColumnDefinitionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataColumnDefinitionType"/>. </summary>
        public static implicit operator DataColumnDefinitionType(string value) => new DataColumnDefinitionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataColumnDefinitionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataColumnDefinitionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}