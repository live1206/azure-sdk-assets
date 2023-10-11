// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> A class represent the assessment. </summary>
    public partial class Assessment
    {
        /// <summary> Initializes a new instance of Assessment. </summary>
        internal Assessment()
        {
            ResourceList = new ChangeTrackingList<AssessmentResourceContent>();
        }

        /// <summary> Initializes a new instance of Assessment. </summary>
        /// <param name="name"> The name of the assessment. </param>
        /// <param name="severity"> The severity level of this assessment. </param>
        /// <param name="description"> The description of the assessment. </param>
        /// <param name="remediation"> The remediation of the assessment. </param>
        /// <param name="isPass"> Indicates whether all the resource(s) are compliant. </param>
        /// <param name="policyId"> The policy id mapping to this assessment. </param>
        /// <param name="resourceList"> List of resource assessments. </param>
        internal Assessment(string name, AssessmentSeverity? severity, string description, string remediation, IsPass? isPass, string policyId, IReadOnlyList<AssessmentResourceContent> resourceList)
        {
            Name = name;
            Severity = severity;
            Description = description;
            Remediation = remediation;
            IsPass = isPass;
            PolicyId = policyId;
            ResourceList = resourceList;
        }

        /// <summary> The name of the assessment. </summary>
        public string Name { get; }
        /// <summary> The severity level of this assessment. </summary>
        public AssessmentSeverity? Severity { get; }
        /// <summary> The description of the assessment. </summary>
        public string Description { get; }
        /// <summary> The remediation of the assessment. </summary>
        public string Remediation { get; }
        /// <summary> Indicates whether all the resource(s) are compliant. </summary>
        public IsPass? IsPass { get; }
        /// <summary> The policy id mapping to this assessment. </summary>
        public string PolicyId { get; }
        /// <summary> List of resource assessments. </summary>
        public IReadOnlyList<AssessmentResourceContent> ResourceList { get; }
    }
}