// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The rotation, if any, to be applied to the input video, before it is encoded. Default is Auto. </summary>
    public readonly partial struct RotationSetting : IEquatable<RotationSetting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RotationSetting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RotationSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "Auto";
        private const string NoneValue = "None";
        private const string Rotate0Value = "Rotate0";
        private const string Rotate90Value = "Rotate90";
        private const string Rotate180Value = "Rotate180";
        private const string Rotate270Value = "Rotate270";

        /// <summary> Automatically detect and rotate as needed. </summary>
        public static RotationSetting Auto { get; } = new RotationSetting(AutoValue);
        /// <summary> Do not rotate the video.  If the output format supports it, any metadata about rotation is kept intact. </summary>
        public static RotationSetting None { get; } = new RotationSetting(NoneValue);
        /// <summary> Do not rotate the video but remove any metadata about the rotation. </summary>
        public static RotationSetting Rotate0 { get; } = new RotationSetting(Rotate0Value);
        /// <summary> Rotate 90 degrees clockwise. </summary>
        public static RotationSetting Rotate90 { get; } = new RotationSetting(Rotate90Value);
        /// <summary> Rotate 180 degrees clockwise. </summary>
        public static RotationSetting Rotate180 { get; } = new RotationSetting(Rotate180Value);
        /// <summary> Rotate 270 degrees clockwise. </summary>
        public static RotationSetting Rotate270 { get; } = new RotationSetting(Rotate270Value);
        /// <summary> Determines if two <see cref="RotationSetting"/> values are the same. </summary>
        public static bool operator ==(RotationSetting left, RotationSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RotationSetting"/> values are not the same. </summary>
        public static bool operator !=(RotationSetting left, RotationSetting right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RotationSetting"/>. </summary>
        public static implicit operator RotationSetting(string value) => new RotationSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RotationSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RotationSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}