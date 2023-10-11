// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Virtual Network Rule State. </summary>
    public readonly partial struct SqlServerVirtualNetworkRuleState : IEquatable<SqlServerVirtualNetworkRuleState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlServerVirtualNetworkRuleState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlServerVirtualNetworkRuleState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitializingValue = "Initializing";
        private const string InProgressValue = "InProgress";
        private const string ReadyValue = "Ready";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";
        private const string UnknownValue = "Unknown";

        /// <summary> Initializing. </summary>
        public static SqlServerVirtualNetworkRuleState Initializing { get; } = new SqlServerVirtualNetworkRuleState(InitializingValue);
        /// <summary> InProgress. </summary>
        public static SqlServerVirtualNetworkRuleState InProgress { get; } = new SqlServerVirtualNetworkRuleState(InProgressValue);
        /// <summary> Ready. </summary>
        public static SqlServerVirtualNetworkRuleState Ready { get; } = new SqlServerVirtualNetworkRuleState(ReadyValue);
        /// <summary> Failed. </summary>
        public static SqlServerVirtualNetworkRuleState Failed { get; } = new SqlServerVirtualNetworkRuleState(FailedValue);
        /// <summary> Deleting. </summary>
        public static SqlServerVirtualNetworkRuleState Deleting { get; } = new SqlServerVirtualNetworkRuleState(DeletingValue);
        /// <summary> Unknown. </summary>
        public static SqlServerVirtualNetworkRuleState Unknown { get; } = new SqlServerVirtualNetworkRuleState(UnknownValue);
        /// <summary> Determines if two <see cref="SqlServerVirtualNetworkRuleState"/> values are the same. </summary>
        public static bool operator ==(SqlServerVirtualNetworkRuleState left, SqlServerVirtualNetworkRuleState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlServerVirtualNetworkRuleState"/> values are not the same. </summary>
        public static bool operator !=(SqlServerVirtualNetworkRuleState left, SqlServerVirtualNetworkRuleState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlServerVirtualNetworkRuleState"/>. </summary>
        public static implicit operator SqlServerVirtualNetworkRuleState(string value) => new SqlServerVirtualNetworkRuleState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlServerVirtualNetworkRuleState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlServerVirtualNetworkRuleState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}