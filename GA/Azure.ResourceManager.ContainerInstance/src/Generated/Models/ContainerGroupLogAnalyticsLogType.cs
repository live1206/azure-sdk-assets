// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The log type to be used. </summary>
    public readonly partial struct ContainerGroupLogAnalyticsLogType : IEquatable<ContainerGroupLogAnalyticsLogType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerGroupLogAnalyticsLogType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerGroupLogAnalyticsLogType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ContainerInsightsValue = "ContainerInsights";
        private const string ContainerInstanceLogsValue = "ContainerInstanceLogs";

        /// <summary> ContainerInsights. </summary>
        public static ContainerGroupLogAnalyticsLogType ContainerInsights { get; } = new ContainerGroupLogAnalyticsLogType(ContainerInsightsValue);
        /// <summary> ContainerInstanceLogs. </summary>
        public static ContainerGroupLogAnalyticsLogType ContainerInstanceLogs { get; } = new ContainerGroupLogAnalyticsLogType(ContainerInstanceLogsValue);
        /// <summary> Determines if two <see cref="ContainerGroupLogAnalyticsLogType"/> values are the same. </summary>
        public static bool operator ==(ContainerGroupLogAnalyticsLogType left, ContainerGroupLogAnalyticsLogType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerGroupLogAnalyticsLogType"/> values are not the same. </summary>
        public static bool operator !=(ContainerGroupLogAnalyticsLogType left, ContainerGroupLogAnalyticsLogType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerGroupLogAnalyticsLogType"/>. </summary>
        public static implicit operator ContainerGroupLogAnalyticsLogType(string value) => new ContainerGroupLogAnalyticsLogType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerGroupLogAnalyticsLogType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerGroupLogAnalyticsLogType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}