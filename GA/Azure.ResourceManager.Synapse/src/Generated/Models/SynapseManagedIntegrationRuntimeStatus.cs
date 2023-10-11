// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Managed integration runtime status. </summary>
    public partial class SynapseManagedIntegrationRuntimeStatus : SynapseIntegrationRuntimeStatus
    {
        /// <summary> Initializes a new instance of SynapseManagedIntegrationRuntimeStatus. </summary>
        internal SynapseManagedIntegrationRuntimeStatus()
        {
            Nodes = new ChangeTrackingList<SynapseManagedIntegrationRuntimeNode>();
            OtherErrors = new ChangeTrackingList<SynapseManagedIntegrationRuntimeError>();
            RuntimeType = IntegrationRuntimeType.Managed;
        }

        /// <summary> Initializes a new instance of SynapseManagedIntegrationRuntimeStatus. </summary>
        /// <param name="runtimeType"> Type of integration runtime. </param>
        /// <param name="dataFactoryName"> The workspace name which the integration runtime belong to. </param>
        /// <param name="state"> The state of integration runtime. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="createOn"> The time at which the integration runtime was created, in ISO8601 format. </param>
        /// <param name="nodes"> The list of nodes for managed integration runtime. </param>
        /// <param name="otherErrors"> The errors that occurred on this integration runtime. </param>
        /// <param name="lastOperation"> The last operation result that occurred on this integration runtime. </param>
        internal SynapseManagedIntegrationRuntimeStatus(IntegrationRuntimeType runtimeType, string dataFactoryName, SynapseIntegrationRuntimeState? state, IReadOnlyDictionary<string, BinaryData> additionalProperties, DateTimeOffset? createOn, IReadOnlyList<SynapseManagedIntegrationRuntimeNode> nodes, IReadOnlyList<SynapseManagedIntegrationRuntimeError> otherErrors, SynapseManagedIntegrationRuntimeOperationResult lastOperation) : base(runtimeType, dataFactoryName, state, additionalProperties)
        {
            CreateOn = createOn;
            Nodes = nodes;
            OtherErrors = otherErrors;
            LastOperation = lastOperation;
            RuntimeType = runtimeType;
        }

        /// <summary> The time at which the integration runtime was created, in ISO8601 format. </summary>
        public DateTimeOffset? CreateOn { get; }
        /// <summary> The list of nodes for managed integration runtime. </summary>
        public IReadOnlyList<SynapseManagedIntegrationRuntimeNode> Nodes { get; }
        /// <summary> The errors that occurred on this integration runtime. </summary>
        public IReadOnlyList<SynapseManagedIntegrationRuntimeError> OtherErrors { get; }
        /// <summary> The last operation result that occurred on this integration runtime. </summary>
        public SynapseManagedIntegrationRuntimeOperationResult LastOperation { get; }
    }
}