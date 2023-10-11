// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> An alert that machines within a group can have. </summary>
    public readonly partial struct AdaptiveApplicationControlIssue : IEquatable<AdaptiveApplicationControlIssue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AdaptiveApplicationControlIssue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AdaptiveApplicationControlIssue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ViolationsAuditedValue = "ViolationsAudited";
        private const string ViolationsBlockedValue = "ViolationsBlocked";
        private const string MsiAndScriptViolationsAuditedValue = "MsiAndScriptViolationsAudited";
        private const string MsiAndScriptViolationsBlockedValue = "MsiAndScriptViolationsBlocked";
        private const string ExecutableViolationsAuditedValue = "ExecutableViolationsAudited";
        private const string RulesViolatedManuallyValue = "RulesViolatedManually";

        /// <summary> ViolationsAudited. </summary>
        public static AdaptiveApplicationControlIssue ViolationsAudited { get; } = new AdaptiveApplicationControlIssue(ViolationsAuditedValue);
        /// <summary> ViolationsBlocked. </summary>
        public static AdaptiveApplicationControlIssue ViolationsBlocked { get; } = new AdaptiveApplicationControlIssue(ViolationsBlockedValue);
        /// <summary> MsiAndScriptViolationsAudited. </summary>
        public static AdaptiveApplicationControlIssue MsiAndScriptViolationsAudited { get; } = new AdaptiveApplicationControlIssue(MsiAndScriptViolationsAuditedValue);
        /// <summary> MsiAndScriptViolationsBlocked. </summary>
        public static AdaptiveApplicationControlIssue MsiAndScriptViolationsBlocked { get; } = new AdaptiveApplicationControlIssue(MsiAndScriptViolationsBlockedValue);
        /// <summary> ExecutableViolationsAudited. </summary>
        public static AdaptiveApplicationControlIssue ExecutableViolationsAudited { get; } = new AdaptiveApplicationControlIssue(ExecutableViolationsAuditedValue);
        /// <summary> RulesViolatedManually. </summary>
        public static AdaptiveApplicationControlIssue RulesViolatedManually { get; } = new AdaptiveApplicationControlIssue(RulesViolatedManuallyValue);
        /// <summary> Determines if two <see cref="AdaptiveApplicationControlIssue"/> values are the same. </summary>
        public static bool operator ==(AdaptiveApplicationControlIssue left, AdaptiveApplicationControlIssue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AdaptiveApplicationControlIssue"/> values are not the same. </summary>
        public static bool operator !=(AdaptiveApplicationControlIssue left, AdaptiveApplicationControlIssue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AdaptiveApplicationControlIssue"/>. </summary>
        public static implicit operator AdaptiveApplicationControlIssue(string value) => new AdaptiveApplicationControlIssue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AdaptiveApplicationControlIssue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AdaptiveApplicationControlIssue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}