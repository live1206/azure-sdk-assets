// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Indicates if updates are available and at least one of the updates needs a reboot. </summary>
    public readonly partial struct InstallRebootBehavior : IEquatable<InstallRebootBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InstallRebootBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InstallRebootBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NeverRebootsValue = "NeverReboots";
        private const string RequiresRebootValue = "RequiresReboot";
        private const string RequestRebootValue = "RequestReboot";

        /// <summary> NeverReboots. </summary>
        public static InstallRebootBehavior NeverReboots { get; } = new InstallRebootBehavior(NeverRebootsValue);
        /// <summary> RequiresReboot. </summary>
        public static InstallRebootBehavior RequiresReboot { get; } = new InstallRebootBehavior(RequiresRebootValue);
        /// <summary> RequestReboot. </summary>
        public static InstallRebootBehavior RequestReboot { get; } = new InstallRebootBehavior(RequestRebootValue);
        /// <summary> Determines if two <see cref="InstallRebootBehavior"/> values are the same. </summary>
        public static bool operator ==(InstallRebootBehavior left, InstallRebootBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InstallRebootBehavior"/> values are not the same. </summary>
        public static bool operator !=(InstallRebootBehavior left, InstallRebootBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InstallRebootBehavior"/>. </summary>
        public static implicit operator InstallRebootBehavior(string value) => new InstallRebootBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InstallRebootBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InstallRebootBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}