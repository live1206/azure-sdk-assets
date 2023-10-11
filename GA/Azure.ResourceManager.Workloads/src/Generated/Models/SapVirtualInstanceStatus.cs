// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the SAP Instance status. </summary>
    public readonly partial struct SapVirtualInstanceStatus : IEquatable<SapVirtualInstanceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapVirtualInstanceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapVirtualInstanceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StartingValue = "Starting";
        private const string RunningValue = "Running";
        private const string StoppingValue = "Stopping";
        private const string OfflineValue = "Offline";
        private const string PartiallyRunningValue = "PartiallyRunning";
        private const string UnavailableValue = "Unavailable";
        private const string SoftShutdownValue = "SoftShutdown";

        /// <summary> Starting. </summary>
        public static SapVirtualInstanceStatus Starting { get; } = new SapVirtualInstanceStatus(StartingValue);
        /// <summary> Running. </summary>
        public static SapVirtualInstanceStatus Running { get; } = new SapVirtualInstanceStatus(RunningValue);
        /// <summary> Stopping. </summary>
        public static SapVirtualInstanceStatus Stopping { get; } = new SapVirtualInstanceStatus(StoppingValue);
        /// <summary> Offline. </summary>
        public static SapVirtualInstanceStatus Offline { get; } = new SapVirtualInstanceStatus(OfflineValue);
        /// <summary> PartiallyRunning. </summary>
        public static SapVirtualInstanceStatus PartiallyRunning { get; } = new SapVirtualInstanceStatus(PartiallyRunningValue);
        /// <summary> Unavailable. </summary>
        public static SapVirtualInstanceStatus Unavailable { get; } = new SapVirtualInstanceStatus(UnavailableValue);
        /// <summary> SoftShutdown. </summary>
        public static SapVirtualInstanceStatus SoftShutdown { get; } = new SapVirtualInstanceStatus(SoftShutdownValue);
        /// <summary> Determines if two <see cref="SapVirtualInstanceStatus"/> values are the same. </summary>
        public static bool operator ==(SapVirtualInstanceStatus left, SapVirtualInstanceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapVirtualInstanceStatus"/> values are not the same. </summary>
        public static bool operator !=(SapVirtualInstanceStatus left, SapVirtualInstanceStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SapVirtualInstanceStatus"/>. </summary>
        public static implicit operator SapVirtualInstanceStatus(string value) => new SapVirtualInstanceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapVirtualInstanceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapVirtualInstanceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}