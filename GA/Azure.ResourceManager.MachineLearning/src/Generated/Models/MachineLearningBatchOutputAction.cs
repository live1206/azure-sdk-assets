// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum to determine how batch inferencing will handle output. </summary>
    public readonly partial struct MachineLearningBatchOutputAction : IEquatable<MachineLearningBatchOutputAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningBatchOutputAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningBatchOutputAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SummaryOnlyValue = "SummaryOnly";
        private const string AppendRowValue = "AppendRow";

        /// <summary> SummaryOnly. </summary>
        public static MachineLearningBatchOutputAction SummaryOnly { get; } = new MachineLearningBatchOutputAction(SummaryOnlyValue);
        /// <summary> AppendRow. </summary>
        public static MachineLearningBatchOutputAction AppendRow { get; } = new MachineLearningBatchOutputAction(AppendRowValue);
        /// <summary> Determines if two <see cref="MachineLearningBatchOutputAction"/> values are the same. </summary>
        public static bool operator ==(MachineLearningBatchOutputAction left, MachineLearningBatchOutputAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningBatchOutputAction"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningBatchOutputAction left, MachineLearningBatchOutputAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningBatchOutputAction"/>. </summary>
        public static implicit operator MachineLearningBatchOutputAction(string value) => new MachineLearningBatchOutputAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningBatchOutputAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningBatchOutputAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}