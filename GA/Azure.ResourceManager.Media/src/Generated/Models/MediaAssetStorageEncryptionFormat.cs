// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The Asset encryption format. One of None or MediaStorageEncryption. </summary>
    public readonly partial struct MediaAssetStorageEncryptionFormat : IEquatable<MediaAssetStorageEncryptionFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaAssetStorageEncryptionFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaAssetStorageEncryptionFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string MediaStorageClientEncryptionValue = "MediaStorageClientEncryption";

        /// <summary> The Asset does not use client-side storage encryption (this is the only allowed value for new Assets). </summary>
        public static MediaAssetStorageEncryptionFormat None { get; } = new MediaAssetStorageEncryptionFormat(NoneValue);
        /// <summary> The Asset is encrypted with Media Services client-side encryption. </summary>
        public static MediaAssetStorageEncryptionFormat MediaStorageClientEncryption { get; } = new MediaAssetStorageEncryptionFormat(MediaStorageClientEncryptionValue);
        /// <summary> Determines if two <see cref="MediaAssetStorageEncryptionFormat"/> values are the same. </summary>
        public static bool operator ==(MediaAssetStorageEncryptionFormat left, MediaAssetStorageEncryptionFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaAssetStorageEncryptionFormat"/> values are not the same. </summary>
        public static bool operator !=(MediaAssetStorageEncryptionFormat left, MediaAssetStorageEncryptionFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaAssetStorageEncryptionFormat"/>. </summary>
        public static implicit operator MediaAssetStorageEncryptionFormat(string value) => new MediaAssetStorageEncryptionFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaAssetStorageEncryptionFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaAssetStorageEncryptionFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}