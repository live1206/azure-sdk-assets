// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Name of the format. Valid values are:
    /// FileZilla3
    /// WebDeploy -- default
    /// Ftp
    /// </summary>
    public readonly partial struct PublishingProfileFormat : IEquatable<PublishingProfileFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PublishingProfileFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PublishingProfileFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FileZilla3Value = "FileZilla3";
        private const string WebDeployValue = "WebDeploy";
        private const string FtpValue = "Ftp";

        /// <summary> FileZilla3. </summary>
        public static PublishingProfileFormat FileZilla3 { get; } = new PublishingProfileFormat(FileZilla3Value);
        /// <summary> WebDeploy. </summary>
        public static PublishingProfileFormat WebDeploy { get; } = new PublishingProfileFormat(WebDeployValue);
        /// <summary> Ftp. </summary>
        public static PublishingProfileFormat Ftp { get; } = new PublishingProfileFormat(FtpValue);
        /// <summary> Determines if two <see cref="PublishingProfileFormat"/> values are the same. </summary>
        public static bool operator ==(PublishingProfileFormat left, PublishingProfileFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PublishingProfileFormat"/> values are not the same. </summary>
        public static bool operator !=(PublishingProfileFormat left, PublishingProfileFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PublishingProfileFormat"/>. </summary>
        public static implicit operator PublishingProfileFormat(string value) => new PublishingProfileFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PublishingProfileFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PublishingProfileFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}