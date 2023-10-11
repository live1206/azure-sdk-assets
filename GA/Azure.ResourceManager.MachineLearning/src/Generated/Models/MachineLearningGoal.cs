// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Defines supported metric goals for hyperparameter tuning. </summary>
    public readonly partial struct MachineLearningGoal : IEquatable<MachineLearningGoal>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningGoal"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningGoal(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MinimizeValue = "Minimize";
        private const string MaximizeValue = "Maximize";

        /// <summary> Minimize. </summary>
        public static MachineLearningGoal Minimize { get; } = new MachineLearningGoal(MinimizeValue);
        /// <summary> Maximize. </summary>
        public static MachineLearningGoal Maximize { get; } = new MachineLearningGoal(MaximizeValue);
        /// <summary> Determines if two <see cref="MachineLearningGoal"/> values are the same. </summary>
        public static bool operator ==(MachineLearningGoal left, MachineLearningGoal right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningGoal"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningGoal left, MachineLearningGoal right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningGoal"/>. </summary>
        public static implicit operator MachineLearningGoal(string value) => new MachineLearningGoal(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningGoal other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningGoal other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}