// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Compliance Status details. </summary>
    public partial class KubernetesConfigurationComplianceStatus
    {
        /// <summary> Initializes a new instance of KubernetesConfigurationComplianceStatus. </summary>
        internal KubernetesConfigurationComplianceStatus()
        {
        }

        /// <summary> Initializes a new instance of KubernetesConfigurationComplianceStatus. </summary>
        /// <param name="complianceState"> The compliance state of the configuration. </param>
        /// <param name="lastConfigAppliedOn"> Datetime the configuration was last applied. </param>
        /// <param name="message"> Message from when the configuration was applied. </param>
        /// <param name="messageLevel"> Level of the message. </param>
        internal KubernetesConfigurationComplianceStatus(KubernetesConfigurationComplianceStateType? complianceState, DateTimeOffset? lastConfigAppliedOn, string message, KubernetesConfigurationMesageLevel? messageLevel)
        {
            ComplianceState = complianceState;
            LastConfigAppliedOn = lastConfigAppliedOn;
            Message = message;
            MessageLevel = messageLevel;
        }

        /// <summary> The compliance state of the configuration. </summary>
        public KubernetesConfigurationComplianceStateType? ComplianceState { get; }
        /// <summary> Datetime the configuration was last applied. </summary>
        public DateTimeOffset? LastConfigAppliedOn { get; }
        /// <summary> Message from when the configuration was applied. </summary>
        public string Message { get; }
        /// <summary> Level of the message. </summary>
        public KubernetesConfigurationMesageLevel? MessageLevel { get; }
    }
}
