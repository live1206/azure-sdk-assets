// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The provisioning state of the resource. </summary>
    public readonly partial struct JobProvisioningState : IEquatable<JobProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string SuspendedValue = "Suspended";
        private const string ProcessingValue = "Processing";

        /// <summary> Failed. </summary>
        public static JobProvisioningState Failed { get; } = new JobProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static JobProvisioningState Succeeded { get; } = new JobProvisioningState(SucceededValue);
        /// <summary> Suspended. </summary>
        public static JobProvisioningState Suspended { get; } = new JobProvisioningState(SuspendedValue);
        /// <summary> Processing. </summary>
        public static JobProvisioningState Processing { get; } = new JobProvisioningState(ProcessingValue);
        /// <summary> Determines if two <see cref="JobProvisioningState"/> values are the same. </summary>
        public static bool operator ==(JobProvisioningState left, JobProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(JobProvisioningState left, JobProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobProvisioningState"/>. </summary>
        public static implicit operator JobProvisioningState(string value) => new JobProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}