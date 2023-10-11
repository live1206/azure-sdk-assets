// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Provisioning state of the App. </summary>
    public readonly partial struct AppPlatformAppProvisioningState : IEquatable<AppPlatformAppProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppPlatformAppProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppPlatformAppProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";

        /// <summary> Succeeded. </summary>
        public static AppPlatformAppProvisioningState Succeeded { get; } = new AppPlatformAppProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static AppPlatformAppProvisioningState Failed { get; } = new AppPlatformAppProvisioningState(FailedValue);
        /// <summary> Creating. </summary>
        public static AppPlatformAppProvisioningState Creating { get; } = new AppPlatformAppProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static AppPlatformAppProvisioningState Updating { get; } = new AppPlatformAppProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static AppPlatformAppProvisioningState Deleting { get; } = new AppPlatformAppProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="AppPlatformAppProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AppPlatformAppProvisioningState left, AppPlatformAppProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppPlatformAppProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AppPlatformAppProvisioningState left, AppPlatformAppProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppPlatformAppProvisioningState"/>. </summary>
        public static implicit operator AppPlatformAppProvisioningState(string value) => new AppPlatformAppProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppPlatformAppProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppPlatformAppProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
