// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The provisioning state of the workspace. </summary>
    public readonly partial struct OperationalInsightsWorkspaceEntityStatus : IEquatable<OperationalInsightsWorkspaceEntityStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspaceEntityStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationalInsightsWorkspaceEntityStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeletingValue = "Deleting";
        private const string ProvisioningAccountValue = "ProvisioningAccount";
        private const string UpdatingValue = "Updating";

        /// <summary> Creating. </summary>
        public static OperationalInsightsWorkspaceEntityStatus Creating { get; } = new OperationalInsightsWorkspaceEntityStatus(CreatingValue);
        /// <summary> Succeeded. </summary>
        public static OperationalInsightsWorkspaceEntityStatus Succeeded { get; } = new OperationalInsightsWorkspaceEntityStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static OperationalInsightsWorkspaceEntityStatus Failed { get; } = new OperationalInsightsWorkspaceEntityStatus(FailedValue);
        /// <summary> Canceled. </summary>
        public static OperationalInsightsWorkspaceEntityStatus Canceled { get; } = new OperationalInsightsWorkspaceEntityStatus(CanceledValue);
        /// <summary> Deleting. </summary>
        public static OperationalInsightsWorkspaceEntityStatus Deleting { get; } = new OperationalInsightsWorkspaceEntityStatus(DeletingValue);
        /// <summary> ProvisioningAccount. </summary>
        public static OperationalInsightsWorkspaceEntityStatus ProvisioningAccount { get; } = new OperationalInsightsWorkspaceEntityStatus(ProvisioningAccountValue);
        /// <summary> Updating. </summary>
        public static OperationalInsightsWorkspaceEntityStatus Updating { get; } = new OperationalInsightsWorkspaceEntityStatus(UpdatingValue);
        /// <summary> Determines if two <see cref="OperationalInsightsWorkspaceEntityStatus"/> values are the same. </summary>
        public static bool operator ==(OperationalInsightsWorkspaceEntityStatus left, OperationalInsightsWorkspaceEntityStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationalInsightsWorkspaceEntityStatus"/> values are not the same. </summary>
        public static bool operator !=(OperationalInsightsWorkspaceEntityStatus left, OperationalInsightsWorkspaceEntityStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationalInsightsWorkspaceEntityStatus"/>. </summary>
        public static implicit operator OperationalInsightsWorkspaceEntityStatus(string value) => new OperationalInsightsWorkspaceEntityStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationalInsightsWorkspaceEntityStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationalInsightsWorkspaceEntityStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}