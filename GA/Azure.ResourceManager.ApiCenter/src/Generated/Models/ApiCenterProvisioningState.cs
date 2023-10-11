// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiCenter.Models
{
    /// <summary> Provisioning state of the service. </summary>
    public readonly partial struct ApiCenterProvisioningState : IEquatable<ApiCenterProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApiCenterProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApiCenterProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static ApiCenterProvisioningState Succeeded { get; } = new ApiCenterProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ApiCenterProvisioningState Failed { get; } = new ApiCenterProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ApiCenterProvisioningState Canceled { get; } = new ApiCenterProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="ApiCenterProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ApiCenterProvisioningState left, ApiCenterProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApiCenterProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ApiCenterProvisioningState left, ApiCenterProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApiCenterProvisioningState"/>. </summary>
        public static implicit operator ApiCenterProvisioningState(string value) => new ApiCenterProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApiCenterProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApiCenterProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}