// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The LogRankingMetric. </summary>
    public readonly partial struct LogRankingMetric : IEquatable<LogRankingMetric>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogRankingMetric"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogRankingMetric(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClientRequestCountValue = "clientRequestCount";
        private const string ClientRequestTrafficValue = "clientRequestTraffic";
        private const string HitCountValue = "hitCount";
        private const string MissCountValue = "missCount";
        private const string UserErrorCountValue = "userErrorCount";
        private const string ErrorCountValue = "errorCount";

        /// <summary> clientRequestCount. </summary>
        public static LogRankingMetric ClientRequestCount { get; } = new LogRankingMetric(ClientRequestCountValue);
        /// <summary> clientRequestTraffic. </summary>
        public static LogRankingMetric ClientRequestTraffic { get; } = new LogRankingMetric(ClientRequestTrafficValue);
        /// <summary> hitCount. </summary>
        public static LogRankingMetric HitCount { get; } = new LogRankingMetric(HitCountValue);
        /// <summary> missCount. </summary>
        public static LogRankingMetric MissCount { get; } = new LogRankingMetric(MissCountValue);
        /// <summary> userErrorCount. </summary>
        public static LogRankingMetric UserErrorCount { get; } = new LogRankingMetric(UserErrorCountValue);
        /// <summary> errorCount. </summary>
        public static LogRankingMetric ErrorCount { get; } = new LogRankingMetric(ErrorCountValue);
        /// <summary> Determines if two <see cref="LogRankingMetric"/> values are the same. </summary>
        public static bool operator ==(LogRankingMetric left, LogRankingMetric right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogRankingMetric"/> values are not the same. </summary>
        public static bool operator !=(LogRankingMetric left, LogRankingMetric right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogRankingMetric"/>. </summary>
        public static implicit operator LogRankingMetric(string value) => new LogRankingMetric(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogRankingMetric other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogRankingMetric other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}