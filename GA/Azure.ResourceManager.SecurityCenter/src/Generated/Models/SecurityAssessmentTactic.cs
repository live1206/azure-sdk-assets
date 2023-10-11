// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Tactic of the assessment. </summary>
    public readonly partial struct SecurityAssessmentTactic : IEquatable<SecurityAssessmentTactic>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentTactic"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityAssessmentTactic(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReconnaissanceValue = "Reconnaissance";
        private const string ResourceDevelopmentValue = "Resource Development";
        private const string InitialAccessValue = "Initial Access";
        private const string ExecutionValue = "Execution";
        private const string PersistenceValue = "Persistence";
        private const string PrivilegeEscalationValue = "Privilege Escalation";
        private const string DefenseEvasionValue = "Defense Evasion";
        private const string CredentialAccessValue = "Credential Access";
        private const string DiscoveryValue = "Discovery";
        private const string LateralMovementValue = "Lateral Movement";
        private const string CollectionValue = "Collection";
        private const string CommandAndControlValue = "Command and Control";
        private const string ExfiltrationValue = "Exfiltration";
        private const string ImpactValue = "Impact";

        /// <summary> Reconnaissance. </summary>
        public static SecurityAssessmentTactic Reconnaissance { get; } = new SecurityAssessmentTactic(ReconnaissanceValue);
        /// <summary> Resource Development. </summary>
        public static SecurityAssessmentTactic ResourceDevelopment { get; } = new SecurityAssessmentTactic(ResourceDevelopmentValue);
        /// <summary> Initial Access. </summary>
        public static SecurityAssessmentTactic InitialAccess { get; } = new SecurityAssessmentTactic(InitialAccessValue);
        /// <summary> Execution. </summary>
        public static SecurityAssessmentTactic Execution { get; } = new SecurityAssessmentTactic(ExecutionValue);
        /// <summary> Persistence. </summary>
        public static SecurityAssessmentTactic Persistence { get; } = new SecurityAssessmentTactic(PersistenceValue);
        /// <summary> Privilege Escalation. </summary>
        public static SecurityAssessmentTactic PrivilegeEscalation { get; } = new SecurityAssessmentTactic(PrivilegeEscalationValue);
        /// <summary> Defense Evasion. </summary>
        public static SecurityAssessmentTactic DefenseEvasion { get; } = new SecurityAssessmentTactic(DefenseEvasionValue);
        /// <summary> Credential Access. </summary>
        public static SecurityAssessmentTactic CredentialAccess { get; } = new SecurityAssessmentTactic(CredentialAccessValue);
        /// <summary> Discovery. </summary>
        public static SecurityAssessmentTactic Discovery { get; } = new SecurityAssessmentTactic(DiscoveryValue);
        /// <summary> Lateral Movement. </summary>
        public static SecurityAssessmentTactic LateralMovement { get; } = new SecurityAssessmentTactic(LateralMovementValue);
        /// <summary> Collection. </summary>
        public static SecurityAssessmentTactic Collection { get; } = new SecurityAssessmentTactic(CollectionValue);
        /// <summary> Command and Control. </summary>
        public static SecurityAssessmentTactic CommandAndControl { get; } = new SecurityAssessmentTactic(CommandAndControlValue);
        /// <summary> Exfiltration. </summary>
        public static SecurityAssessmentTactic Exfiltration { get; } = new SecurityAssessmentTactic(ExfiltrationValue);
        /// <summary> Impact. </summary>
        public static SecurityAssessmentTactic Impact { get; } = new SecurityAssessmentTactic(ImpactValue);
        /// <summary> Determines if two <see cref="SecurityAssessmentTactic"/> values are the same. </summary>
        public static bool operator ==(SecurityAssessmentTactic left, SecurityAssessmentTactic right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityAssessmentTactic"/> values are not the same. </summary>
        public static bool operator !=(SecurityAssessmentTactic left, SecurityAssessmentTactic right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityAssessmentTactic"/>. </summary>
        public static implicit operator SecurityAssessmentTactic(string value) => new SecurityAssessmentTactic(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityAssessmentTactic other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityAssessmentTactic other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}