// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize. </summary>
    public readonly partial struct InputVideoStretchMode : IEquatable<InputVideoStretchMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InputVideoStretchMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InputVideoStretchMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string AutoSizeValue = "AutoSize";
        private const string AutoFitValue = "AutoFit";

        /// <summary> Strictly respect the output resolution without considering the pixel aspect ratio or display aspect ratio of the input video. </summary>
        public static InputVideoStretchMode None { get; } = new InputVideoStretchMode(NoneValue);
        /// <summary> Override the output resolution, and change it to match the display aspect ratio of the input, without padding. For example, if the input is 1920x1080 and the encoding preset asks for 1280x1280, then the value in the preset is overridden, and the output will be at 1280x720, which maintains the input aspect ratio of 16:9. </summary>
        public static InputVideoStretchMode AutoSize { get; } = new InputVideoStretchMode(AutoSizeValue);
        /// <summary> Pad the output (with either letterbox or pillar box) to honor the output resolution, while ensuring that the active video region in the output has the same aspect ratio as the input. For example, if the input is 1920x1080 and the encoding preset asks for 1280x1280, then the output will be at 1280x1280, which contains an inner rectangle of 1280x720 at aspect ratio of 16:9, and pillar box regions 280 pixels wide at the left and right. </summary>
        public static InputVideoStretchMode AutoFit { get; } = new InputVideoStretchMode(AutoFitValue);
        /// <summary> Determines if two <see cref="InputVideoStretchMode"/> values are the same. </summary>
        public static bool operator ==(InputVideoStretchMode left, InputVideoStretchMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InputVideoStretchMode"/> values are not the same. </summary>
        public static bool operator !=(InputVideoStretchMode left, InputVideoStretchMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InputVideoStretchMode"/>. </summary>
        public static implicit operator InputVideoStretchMode(string value) => new InputVideoStretchMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InputVideoStretchMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InputVideoStretchMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}