// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> The current state of PowerBI Dedicated resource. The state is to indicate more states outside of resource provisioning. </summary>
    public readonly partial struct State : IEquatable<State>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="State"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public State(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string PausedValue = "Paused";
        private const string SuspendedValue = "Suspended";
        private const string ProvisioningValue = "Provisioning";
        private const string UpdatingValue = "Updating";
        private const string SuspendingValue = "Suspending";
        private const string PausingValue = "Pausing";
        private const string ResumingValue = "Resuming";
        private const string PreparingValue = "Preparing";
        private const string ScalingValue = "Scaling";

        /// <summary> Deleting. </summary>
        public static State Deleting { get; } = new State(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static State Succeeded { get; } = new State(SucceededValue);
        /// <summary> Failed. </summary>
        public static State Failed { get; } = new State(FailedValue);
        /// <summary> Paused. </summary>
        public static State Paused { get; } = new State(PausedValue);
        /// <summary> Suspended. </summary>
        public static State Suspended { get; } = new State(SuspendedValue);
        /// <summary> Provisioning. </summary>
        public static State Provisioning { get; } = new State(ProvisioningValue);
        /// <summary> Updating. </summary>
        public static State Updating { get; } = new State(UpdatingValue);
        /// <summary> Suspending. </summary>
        public static State Suspending { get; } = new State(SuspendingValue);
        /// <summary> Pausing. </summary>
        public static State Pausing { get; } = new State(PausingValue);
        /// <summary> Resuming. </summary>
        public static State Resuming { get; } = new State(ResumingValue);
        /// <summary> Preparing. </summary>
        public static State Preparing { get; } = new State(PreparingValue);
        /// <summary> Scaling. </summary>
        public static State Scaling { get; } = new State(ScalingValue);
        /// <summary> Determines if two <see cref="State"/> values are the same. </summary>
        public static bool operator ==(State left, State right) => left.Equals(right);
        /// <summary> Determines if two <see cref="State"/> values are not the same. </summary>
        public static bool operator !=(State left, State right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="State"/>. </summary>
        public static implicit operator State(string value) => new State(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is State other && Equals(other);
        /// <inheritdoc />
        public bool Equals(State other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}