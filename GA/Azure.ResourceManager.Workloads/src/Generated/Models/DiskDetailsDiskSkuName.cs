// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the disk sku name. </summary>
    public readonly partial struct DiskDetailsDiskSkuName : IEquatable<DiskDetailsDiskSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskDetailsDiskSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskDetailsDiskSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardLrsValue = "Standard_LRS";
        private const string PremiumLrsValue = "Premium_LRS";
        private const string StandardSsdLrsValue = "StandardSSD_LRS";
        private const string UltraSsdLrsValue = "UltraSSD_LRS";
        private const string PremiumZrsValue = "Premium_ZRS";
        private const string StandardSsdZrsValue = "StandardSSD_ZRS";
        private const string PremiumV2LrsValue = "PremiumV2_LRS";

        /// <summary> Standard_LRS. </summary>
        public static DiskDetailsDiskSkuName StandardLrs { get; } = new DiskDetailsDiskSkuName(StandardLrsValue);
        /// <summary> Premium_LRS. </summary>
        public static DiskDetailsDiskSkuName PremiumLrs { get; } = new DiskDetailsDiskSkuName(PremiumLrsValue);
        /// <summary> StandardSSD_LRS. </summary>
        public static DiskDetailsDiskSkuName StandardSsdLrs { get; } = new DiskDetailsDiskSkuName(StandardSsdLrsValue);
        /// <summary> UltraSSD_LRS. </summary>
        public static DiskDetailsDiskSkuName UltraSsdLrs { get; } = new DiskDetailsDiskSkuName(UltraSsdLrsValue);
        /// <summary> Premium_ZRS. </summary>
        public static DiskDetailsDiskSkuName PremiumZrs { get; } = new DiskDetailsDiskSkuName(PremiumZrsValue);
        /// <summary> StandardSSD_ZRS. </summary>
        public static DiskDetailsDiskSkuName StandardSsdZrs { get; } = new DiskDetailsDiskSkuName(StandardSsdZrsValue);
        /// <summary> PremiumV2_LRS. </summary>
        public static DiskDetailsDiskSkuName PremiumV2Lrs { get; } = new DiskDetailsDiskSkuName(PremiumV2LrsValue);
        /// <summary> Determines if two <see cref="DiskDetailsDiskSkuName"/> values are the same. </summary>
        public static bool operator ==(DiskDetailsDiskSkuName left, DiskDetailsDiskSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskDetailsDiskSkuName"/> values are not the same. </summary>
        public static bool operator !=(DiskDetailsDiskSkuName left, DiskDetailsDiskSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskDetailsDiskSkuName"/>. </summary>
        public static implicit operator DiskDetailsDiskSkuName(string value) => new DiskDetailsDiskSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskDetailsDiskSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskDetailsDiskSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}