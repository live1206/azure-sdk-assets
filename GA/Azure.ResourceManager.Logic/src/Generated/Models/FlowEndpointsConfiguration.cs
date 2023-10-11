// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The endpoints configuration. </summary>
    public partial class FlowEndpointsConfiguration
    {
        /// <summary> Initializes a new instance of FlowEndpointsConfiguration. </summary>
        public FlowEndpointsConfiguration()
        {
        }

        /// <summary> Initializes a new instance of FlowEndpointsConfiguration. </summary>
        /// <param name="workflow"> The workflow endpoints. </param>
        /// <param name="connector"> The connector endpoints. </param>
        internal FlowEndpointsConfiguration(FlowEndpoints workflow, FlowEndpoints connector)
        {
            Workflow = workflow;
            Connector = connector;
        }

        /// <summary> The workflow endpoints. </summary>
        public FlowEndpoints Workflow { get; set; }
        /// <summary> The connector endpoints. </summary>
        public FlowEndpoints Connector { get; set; }
    }
}