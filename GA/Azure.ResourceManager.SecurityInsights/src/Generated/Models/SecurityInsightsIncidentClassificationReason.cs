// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The classification reason the incident was closed with. </summary>
    public readonly partial struct SecurityInsightsIncidentClassificationReason : IEquatable<SecurityInsightsIncidentClassificationReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentClassificationReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsIncidentClassificationReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SuspiciousActivityValue = "SuspiciousActivity";
        private const string SuspiciousButExpectedValue = "SuspiciousButExpected";
        private const string IncorrectAlertLogicValue = "IncorrectAlertLogic";
        private const string InaccurateDataValue = "InaccurateData";

        /// <summary> Classification reason was suspicious activity. </summary>
        public static SecurityInsightsIncidentClassificationReason SuspiciousActivity { get; } = new SecurityInsightsIncidentClassificationReason(SuspiciousActivityValue);
        /// <summary> Classification reason was suspicious but expected. </summary>
        public static SecurityInsightsIncidentClassificationReason SuspiciousButExpected { get; } = new SecurityInsightsIncidentClassificationReason(SuspiciousButExpectedValue);
        /// <summary> Classification reason was incorrect alert logic. </summary>
        public static SecurityInsightsIncidentClassificationReason IncorrectAlertLogic { get; } = new SecurityInsightsIncidentClassificationReason(IncorrectAlertLogicValue);
        /// <summary> Classification reason was inaccurate data. </summary>
        public static SecurityInsightsIncidentClassificationReason InaccurateData { get; } = new SecurityInsightsIncidentClassificationReason(InaccurateDataValue);
        /// <summary> Determines if two <see cref="SecurityInsightsIncidentClassificationReason"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsIncidentClassificationReason left, SecurityInsightsIncidentClassificationReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsIncidentClassificationReason"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsIncidentClassificationReason left, SecurityInsightsIncidentClassificationReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsIncidentClassificationReason"/>. </summary>
        public static implicit operator SecurityInsightsIncidentClassificationReason(string value) => new SecurityInsightsIncidentClassificationReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsIncidentClassificationReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsIncidentClassificationReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}