// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The TemplateDeploymentPreflightOption. </summary>
    public readonly partial struct TemplateDeploymentPreflightOption : IEquatable<TemplateDeploymentPreflightOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TemplateDeploymentPreflightOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TemplateDeploymentPreflightOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ValidationRequestsValue = "ValidationRequests";
        private const string DeploymentRequestsValue = "DeploymentRequests";
        private const string TestOnlyValue = "TestOnly";
        private const string RegisteredOnlyValue = "RegisteredOnly";

        /// <summary> None. </summary>
        public static TemplateDeploymentPreflightOption None { get; } = new TemplateDeploymentPreflightOption(NoneValue);
        /// <summary> ValidationRequests. </summary>
        public static TemplateDeploymentPreflightOption ValidationRequests { get; } = new TemplateDeploymentPreflightOption(ValidationRequestsValue);
        /// <summary> DeploymentRequests. </summary>
        public static TemplateDeploymentPreflightOption DeploymentRequests { get; } = new TemplateDeploymentPreflightOption(DeploymentRequestsValue);
        /// <summary> TestOnly. </summary>
        public static TemplateDeploymentPreflightOption TestOnly { get; } = new TemplateDeploymentPreflightOption(TestOnlyValue);
        /// <summary> RegisteredOnly. </summary>
        public static TemplateDeploymentPreflightOption RegisteredOnly { get; } = new TemplateDeploymentPreflightOption(RegisteredOnlyValue);
        /// <summary> Determines if two <see cref="TemplateDeploymentPreflightOption"/> values are the same. </summary>
        public static bool operator ==(TemplateDeploymentPreflightOption left, TemplateDeploymentPreflightOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TemplateDeploymentPreflightOption"/> values are not the same. </summary>
        public static bool operator !=(TemplateDeploymentPreflightOption left, TemplateDeploymentPreflightOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TemplateDeploymentPreflightOption"/>. </summary>
        public static implicit operator TemplateDeploymentPreflightOption(string value) => new TemplateDeploymentPreflightOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TemplateDeploymentPreflightOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TemplateDeploymentPreflightOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}