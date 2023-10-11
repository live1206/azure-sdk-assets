// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The compute resource properties for managed integration runtime. </summary>
    public partial class SynapseIntegrationRuntimeComputeProperties
    {
        /// <summary> Initializes a new instance of SynapseIntegrationRuntimeComputeProperties. </summary>
        public SynapseIntegrationRuntimeComputeProperties()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of SynapseIntegrationRuntimeComputeProperties. </summary>
        /// <param name="location"> The location for managed integration runtime. The supported regions could be found on https://docs.microsoft.com/en-us/azure/data-factory/data-factory-data-movement-activities. </param>
        /// <param name="nodeSize"> The node size requirement to managed integration runtime. </param>
        /// <param name="numberOfNodes"> The required number of nodes for managed integration runtime. </param>
        /// <param name="maxParallelExecutionsPerNode"> Maximum parallel executions count per node for managed integration runtime. </param>
        /// <param name="dataFlowProperties"> Data flow properties for managed integration runtime. </param>
        /// <param name="vnetProperties"> VNet properties for managed integration runtime. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SynapseIntegrationRuntimeComputeProperties(AzureLocation? location, string nodeSize, int? numberOfNodes, int? maxParallelExecutionsPerNode, SynapseIntegrationRuntimeDataFlowProperties dataFlowProperties, SynapseIntegrationRuntimeVnetProperties vnetProperties, IDictionary<string, BinaryData> additionalProperties)
        {
            Location = location;
            NodeSize = nodeSize;
            NumberOfNodes = numberOfNodes;
            MaxParallelExecutionsPerNode = maxParallelExecutionsPerNode;
            DataFlowProperties = dataFlowProperties;
            VnetProperties = vnetProperties;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The location for managed integration runtime. The supported regions could be found on https://docs.microsoft.com/en-us/azure/data-factory/data-factory-data-movement-activities. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The node size requirement to managed integration runtime. </summary>
        public string NodeSize { get; set; }
        /// <summary> The required number of nodes for managed integration runtime. </summary>
        public int? NumberOfNodes { get; set; }
        /// <summary> Maximum parallel executions count per node for managed integration runtime. </summary>
        public int? MaxParallelExecutionsPerNode { get; set; }
        /// <summary> Data flow properties for managed integration runtime. </summary>
        public SynapseIntegrationRuntimeDataFlowProperties DataFlowProperties { get; set; }
        /// <summary> VNet properties for managed integration runtime. </summary>
        public SynapseIntegrationRuntimeVnetProperties VnetProperties { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
