// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Policy for enabling follow-the-sun business models: link local cache to cloud behavior to pre-populate before local access. </summary>
    public readonly partial struct LocalCacheMode : IEquatable<LocalCacheMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LocalCacheMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LocalCacheMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DownloadNewAndModifiedFilesValue = "DownloadNewAndModifiedFiles";
        private const string UpdateLocallyCachedFilesValue = "UpdateLocallyCachedFiles";

        /// <summary> DownloadNewAndModifiedFiles. </summary>
        public static LocalCacheMode DownloadNewAndModifiedFiles { get; } = new LocalCacheMode(DownloadNewAndModifiedFilesValue);
        /// <summary> UpdateLocallyCachedFiles. </summary>
        public static LocalCacheMode UpdateLocallyCachedFiles { get; } = new LocalCacheMode(UpdateLocallyCachedFilesValue);
        /// <summary> Determines if two <see cref="LocalCacheMode"/> values are the same. </summary>
        public static bool operator ==(LocalCacheMode left, LocalCacheMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LocalCacheMode"/> values are not the same. </summary>
        public static bool operator !=(LocalCacheMode left, LocalCacheMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LocalCacheMode"/>. </summary>
        public static implicit operator LocalCacheMode(string value) => new LocalCacheMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LocalCacheMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LocalCacheMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}