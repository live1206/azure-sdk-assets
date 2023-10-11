// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum to determine the input data delivery mode. </summary>
    public readonly partial struct MachineLearningInputDeliveryMode : IEquatable<MachineLearningInputDeliveryMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningInputDeliveryMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningInputDeliveryMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadOnlyMountValue = "ReadOnlyMount";
        private const string ReadWriteMountValue = "ReadWriteMount";
        private const string DownloadValue = "Download";
        private const string DirectValue = "Direct";
        private const string EvalMountValue = "EvalMount";
        private const string EvalDownloadValue = "EvalDownload";

        /// <summary> ReadOnlyMount. </summary>
        public static MachineLearningInputDeliveryMode ReadOnlyMount { get; } = new MachineLearningInputDeliveryMode(ReadOnlyMountValue);
        /// <summary> ReadWriteMount. </summary>
        public static MachineLearningInputDeliveryMode ReadWriteMount { get; } = new MachineLearningInputDeliveryMode(ReadWriteMountValue);
        /// <summary> Download. </summary>
        public static MachineLearningInputDeliveryMode Download { get; } = new MachineLearningInputDeliveryMode(DownloadValue);
        /// <summary> Direct. </summary>
        public static MachineLearningInputDeliveryMode Direct { get; } = new MachineLearningInputDeliveryMode(DirectValue);
        /// <summary> EvalMount. </summary>
        public static MachineLearningInputDeliveryMode EvalMount { get; } = new MachineLearningInputDeliveryMode(EvalMountValue);
        /// <summary> EvalDownload. </summary>
        public static MachineLearningInputDeliveryMode EvalDownload { get; } = new MachineLearningInputDeliveryMode(EvalDownloadValue);
        /// <summary> Determines if two <see cref="MachineLearningInputDeliveryMode"/> values are the same. </summary>
        public static bool operator ==(MachineLearningInputDeliveryMode left, MachineLearningInputDeliveryMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningInputDeliveryMode"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningInputDeliveryMode left, MachineLearningInputDeliveryMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningInputDeliveryMode"/>. </summary>
        public static implicit operator MachineLearningInputDeliveryMode(string value) => new MachineLearningInputDeliveryMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningInputDeliveryMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningInputDeliveryMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}