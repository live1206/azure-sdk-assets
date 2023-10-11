// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Current state of an ComputeInstance. </summary>
    public readonly partial struct MachineLearningComputeInstanceState : IEquatable<MachineLearningComputeInstanceState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeInstanceState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningComputeInstanceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string CreateFailedValue = "CreateFailed";
        private const string DeletingValue = "Deleting";
        private const string RunningValue = "Running";
        private const string RestartingValue = "Restarting";
        private const string JobRunningValue = "JobRunning";
        private const string SettingUpValue = "SettingUp";
        private const string SetupFailedValue = "SetupFailed";
        private const string StartingValue = "Starting";
        private const string StoppedValue = "Stopped";
        private const string StoppingValue = "Stopping";
        private const string UserSettingUpValue = "UserSettingUp";
        private const string UserSetupFailedValue = "UserSetupFailed";
        private const string UnknownValue = "Unknown";
        private const string UnusableValue = "Unusable";

        /// <summary> Creating. </summary>
        public static MachineLearningComputeInstanceState Creating { get; } = new MachineLearningComputeInstanceState(CreatingValue);
        /// <summary> CreateFailed. </summary>
        public static MachineLearningComputeInstanceState CreateFailed { get; } = new MachineLearningComputeInstanceState(CreateFailedValue);
        /// <summary> Deleting. </summary>
        public static MachineLearningComputeInstanceState Deleting { get; } = new MachineLearningComputeInstanceState(DeletingValue);
        /// <summary> Running. </summary>
        public static MachineLearningComputeInstanceState Running { get; } = new MachineLearningComputeInstanceState(RunningValue);
        /// <summary> Restarting. </summary>
        public static MachineLearningComputeInstanceState Restarting { get; } = new MachineLearningComputeInstanceState(RestartingValue);
        /// <summary> JobRunning. </summary>
        public static MachineLearningComputeInstanceState JobRunning { get; } = new MachineLearningComputeInstanceState(JobRunningValue);
        /// <summary> SettingUp. </summary>
        public static MachineLearningComputeInstanceState SettingUp { get; } = new MachineLearningComputeInstanceState(SettingUpValue);
        /// <summary> SetupFailed. </summary>
        public static MachineLearningComputeInstanceState SetupFailed { get; } = new MachineLearningComputeInstanceState(SetupFailedValue);
        /// <summary> Starting. </summary>
        public static MachineLearningComputeInstanceState Starting { get; } = new MachineLearningComputeInstanceState(StartingValue);
        /// <summary> Stopped. </summary>
        public static MachineLearningComputeInstanceState Stopped { get; } = new MachineLearningComputeInstanceState(StoppedValue);
        /// <summary> Stopping. </summary>
        public static MachineLearningComputeInstanceState Stopping { get; } = new MachineLearningComputeInstanceState(StoppingValue);
        /// <summary> UserSettingUp. </summary>
        public static MachineLearningComputeInstanceState UserSettingUp { get; } = new MachineLearningComputeInstanceState(UserSettingUpValue);
        /// <summary> UserSetupFailed. </summary>
        public static MachineLearningComputeInstanceState UserSetupFailed { get; } = new MachineLearningComputeInstanceState(UserSetupFailedValue);
        /// <summary> Unknown. </summary>
        public static MachineLearningComputeInstanceState Unknown { get; } = new MachineLearningComputeInstanceState(UnknownValue);
        /// <summary> Unusable. </summary>
        public static MachineLearningComputeInstanceState Unusable { get; } = new MachineLearningComputeInstanceState(UnusableValue);
        /// <summary> Determines if two <see cref="MachineLearningComputeInstanceState"/> values are the same. </summary>
        public static bool operator ==(MachineLearningComputeInstanceState left, MachineLearningComputeInstanceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningComputeInstanceState"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningComputeInstanceState left, MachineLearningComputeInstanceState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningComputeInstanceState"/>. </summary>
        public static implicit operator MachineLearningComputeInstanceState(string value) => new MachineLearningComputeInstanceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningComputeInstanceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningComputeInstanceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
