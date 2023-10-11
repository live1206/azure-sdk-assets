// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The access control configuration. </summary>
    public partial class FlowAccessControlConfiguration
    {
        /// <summary> Initializes a new instance of FlowAccessControlConfiguration. </summary>
        public FlowAccessControlConfiguration()
        {
        }

        /// <summary> Initializes a new instance of FlowAccessControlConfiguration. </summary>
        /// <param name="triggers"> The access control configuration for invoking workflow triggers. </param>
        /// <param name="contents"> The access control configuration for accessing workflow run contents. </param>
        /// <param name="actions"> The access control configuration for workflow actions. </param>
        /// <param name="workflowManagement"> The access control configuration for workflow management. </param>
        internal FlowAccessControlConfiguration(FlowAccessControlConfigurationPolicy triggers, FlowAccessControlConfigurationPolicy contents, FlowAccessControlConfigurationPolicy actions, FlowAccessControlConfigurationPolicy workflowManagement)
        {
            Triggers = triggers;
            Contents = contents;
            Actions = actions;
            WorkflowManagement = workflowManagement;
        }

        /// <summary> The access control configuration for invoking workflow triggers. </summary>
        public FlowAccessControlConfigurationPolicy Triggers { get; set; }
        /// <summary> The access control configuration for accessing workflow run contents. </summary>
        public FlowAccessControlConfigurationPolicy Contents { get; set; }
        /// <summary> The access control configuration for workflow actions. </summary>
        public FlowAccessControlConfigurationPolicy Actions { get; set; }
        /// <summary> The access control configuration for workflow management. </summary>
        public FlowAccessControlConfigurationPolicy WorkflowManagement { get; set; }
    }
}