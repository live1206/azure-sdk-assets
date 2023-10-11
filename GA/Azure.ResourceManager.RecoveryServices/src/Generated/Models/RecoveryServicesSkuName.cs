// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig. </summary>
    public readonly partial struct RecoveryServicesSkuName : IEquatable<RecoveryServicesSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecoveryServicesSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string RS0Value = "RS0";

        /// <summary> Standard. </summary>
        public static RecoveryServicesSkuName Standard { get; } = new RecoveryServicesSkuName(StandardValue);
        /// <summary> RS0. </summary>
        public static RecoveryServicesSkuName RS0 { get; } = new RecoveryServicesSkuName(RS0Value);
        /// <summary> Determines if two <see cref="RecoveryServicesSkuName"/> values are the same. </summary>
        public static bool operator ==(RecoveryServicesSkuName left, RecoveryServicesSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecoveryServicesSkuName"/> values are not the same. </summary>
        public static bool operator !=(RecoveryServicesSkuName left, RecoveryServicesSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecoveryServicesSkuName"/>. </summary>
        public static implicit operator RecoveryServicesSkuName(string value) => new RecoveryServicesSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecoveryServicesSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecoveryServicesSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}