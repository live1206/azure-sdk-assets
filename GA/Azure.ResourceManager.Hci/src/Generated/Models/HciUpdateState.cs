// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> State of the update as it relates to this stamp. </summary>
    public readonly partial struct HciUpdateState : IEquatable<HciUpdateState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HciUpdateState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HciUpdateState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HasPrerequisiteValue = "HasPrerequisite";
        private const string ObsoleteValue = "Obsolete";
        private const string ReadyValue = "Ready";
        private const string NotApplicableBecauseAnotherUpdateIsInProgressValue = "NotApplicableBecauseAnotherUpdateIsInProgress";
        private const string PreparingValue = "Preparing";
        private const string InstallingValue = "Installing";
        private const string InstalledValue = "Installed";
        private const string PreparationFailedValue = "PreparationFailed";
        private const string InstallationFailedValue = "InstallationFailed";
        private const string InvalidValue = "Invalid";
        private const string RecalledValue = "Recalled";
        private const string DownloadingValue = "Downloading";
        private const string DownloadFailedValue = "DownloadFailed";
        private const string HealthCheckingValue = "HealthChecking";
        private const string HealthCheckFailedValue = "HealthCheckFailed";
        private const string ReadyToInstallValue = "ReadyToInstall";
        private const string ScanInProgressValue = "ScanInProgress";
        private const string ScanFailedValue = "ScanFailed";

        /// <summary> HasPrerequisite. </summary>
        public static HciUpdateState HasPrerequisite { get; } = new HciUpdateState(HasPrerequisiteValue);
        /// <summary> Obsolete. </summary>
        public static HciUpdateState Obsolete { get; } = new HciUpdateState(ObsoleteValue);
        /// <summary> Ready. </summary>
        public static HciUpdateState Ready { get; } = new HciUpdateState(ReadyValue);
        /// <summary> NotApplicableBecauseAnotherUpdateIsInProgress. </summary>
        public static HciUpdateState NotApplicableBecauseAnotherUpdateIsInProgress { get; } = new HciUpdateState(NotApplicableBecauseAnotherUpdateIsInProgressValue);
        /// <summary> Preparing. </summary>
        public static HciUpdateState Preparing { get; } = new HciUpdateState(PreparingValue);
        /// <summary> Installing. </summary>
        public static HciUpdateState Installing { get; } = new HciUpdateState(InstallingValue);
        /// <summary> Installed. </summary>
        public static HciUpdateState Installed { get; } = new HciUpdateState(InstalledValue);
        /// <summary> PreparationFailed. </summary>
        public static HciUpdateState PreparationFailed { get; } = new HciUpdateState(PreparationFailedValue);
        /// <summary> InstallationFailed. </summary>
        public static HciUpdateState InstallationFailed { get; } = new HciUpdateState(InstallationFailedValue);
        /// <summary> Invalid. </summary>
        public static HciUpdateState Invalid { get; } = new HciUpdateState(InvalidValue);
        /// <summary> Recalled. </summary>
        public static HciUpdateState Recalled { get; } = new HciUpdateState(RecalledValue);
        /// <summary> Downloading. </summary>
        public static HciUpdateState Downloading { get; } = new HciUpdateState(DownloadingValue);
        /// <summary> DownloadFailed. </summary>
        public static HciUpdateState DownloadFailed { get; } = new HciUpdateState(DownloadFailedValue);
        /// <summary> HealthChecking. </summary>
        public static HciUpdateState HealthChecking { get; } = new HciUpdateState(HealthCheckingValue);
        /// <summary> HealthCheckFailed. </summary>
        public static HciUpdateState HealthCheckFailed { get; } = new HciUpdateState(HealthCheckFailedValue);
        /// <summary> ReadyToInstall. </summary>
        public static HciUpdateState ReadyToInstall { get; } = new HciUpdateState(ReadyToInstallValue);
        /// <summary> ScanInProgress. </summary>
        public static HciUpdateState ScanInProgress { get; } = new HciUpdateState(ScanInProgressValue);
        /// <summary> ScanFailed. </summary>
        public static HciUpdateState ScanFailed { get; } = new HciUpdateState(ScanFailedValue);
        /// <summary> Determines if two <see cref="HciUpdateState"/> values are the same. </summary>
        public static bool operator ==(HciUpdateState left, HciUpdateState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HciUpdateState"/> values are not the same. </summary>
        public static bool operator !=(HciUpdateState left, HciUpdateState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HciUpdateState"/>. </summary>
        public static implicit operator HciUpdateState(string value) => new HciUpdateState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HciUpdateState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HciUpdateState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}