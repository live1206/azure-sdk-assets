// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The private link configuration provisioning state, which only appears in the response. </summary>
    public readonly partial struct HDInsightPrivateLinkConfigurationProvisioningState : IEquatable<HDInsightPrivateLinkConfigurationProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightPrivateLinkConfigurationProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightPrivateLinkConfigurationProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string DeletingValue = "Deleting";

        /// <summary> InProgress. </summary>
        public static HDInsightPrivateLinkConfigurationProvisioningState InProgress { get; } = new HDInsightPrivateLinkConfigurationProvisioningState(InProgressValue);
        /// <summary> Failed. </summary>
        public static HDInsightPrivateLinkConfigurationProvisioningState Failed { get; } = new HDInsightPrivateLinkConfigurationProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static HDInsightPrivateLinkConfigurationProvisioningState Succeeded { get; } = new HDInsightPrivateLinkConfigurationProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static HDInsightPrivateLinkConfigurationProvisioningState Canceled { get; } = new HDInsightPrivateLinkConfigurationProvisioningState(CanceledValue);
        /// <summary> Deleting. </summary>
        public static HDInsightPrivateLinkConfigurationProvisioningState Deleting { get; } = new HDInsightPrivateLinkConfigurationProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="HDInsightPrivateLinkConfigurationProvisioningState"/> values are the same. </summary>
        public static bool operator ==(HDInsightPrivateLinkConfigurationProvisioningState left, HDInsightPrivateLinkConfigurationProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightPrivateLinkConfigurationProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(HDInsightPrivateLinkConfigurationProvisioningState left, HDInsightPrivateLinkConfigurationProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HDInsightPrivateLinkConfigurationProvisioningState"/>. </summary>
        public static implicit operator HDInsightPrivateLinkConfigurationProvisioningState(string value) => new HDInsightPrivateLinkConfigurationProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightPrivateLinkConfigurationProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightPrivateLinkConfigurationProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}