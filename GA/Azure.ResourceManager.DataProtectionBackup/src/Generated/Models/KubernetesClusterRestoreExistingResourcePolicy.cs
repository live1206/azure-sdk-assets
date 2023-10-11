// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Gets or sets the Conflict Policy property. This property sets policy during conflict of resources during restore. </summary>
    public readonly partial struct KubernetesClusterRestoreExistingResourcePolicy : IEquatable<KubernetesClusterRestoreExistingResourcePolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterRestoreExistingResourcePolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KubernetesClusterRestoreExistingResourcePolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SkipValue = "Skip";
        private const string PatchValue = "Patch";

        /// <summary> Skip. </summary>
        public static KubernetesClusterRestoreExistingResourcePolicy Skip { get; } = new KubernetesClusterRestoreExistingResourcePolicy(SkipValue);
        /// <summary> Patch. </summary>
        public static KubernetesClusterRestoreExistingResourcePolicy Patch { get; } = new KubernetesClusterRestoreExistingResourcePolicy(PatchValue);
        /// <summary> Determines if two <see cref="KubernetesClusterRestoreExistingResourcePolicy"/> values are the same. </summary>
        public static bool operator ==(KubernetesClusterRestoreExistingResourcePolicy left, KubernetesClusterRestoreExistingResourcePolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KubernetesClusterRestoreExistingResourcePolicy"/> values are not the same. </summary>
        public static bool operator !=(KubernetesClusterRestoreExistingResourcePolicy left, KubernetesClusterRestoreExistingResourcePolicy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KubernetesClusterRestoreExistingResourcePolicy"/>. </summary>
        public static implicit operator KubernetesClusterRestoreExistingResourcePolicy(string value) => new KubernetesClusterRestoreExistingResourcePolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KubernetesClusterRestoreExistingResourcePolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KubernetesClusterRestoreExistingResourcePolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}