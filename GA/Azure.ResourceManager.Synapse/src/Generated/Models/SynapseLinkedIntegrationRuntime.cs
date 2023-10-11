// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The linked integration runtime information. </summary>
    public partial class SynapseLinkedIntegrationRuntime
    {
        /// <summary> Initializes a new instance of SynapseLinkedIntegrationRuntime. </summary>
        internal SynapseLinkedIntegrationRuntime()
        {
        }

        /// <summary> Initializes a new instance of SynapseLinkedIntegrationRuntime. </summary>
        /// <param name="name"> The name of the linked integration runtime. </param>
        /// <param name="subscriptionId"> The subscription ID for which the linked integration runtime belong to. </param>
        /// <param name="dataFactoryName"> The name of the workspace for which the linked integration runtime belong to. </param>
        /// <param name="dataFactoryLocation"> The location of the workspace for which the linked integration runtime belong to. </param>
        /// <param name="createOn"> The creating time of the linked integration runtime. </param>
        internal SynapseLinkedIntegrationRuntime(string name, string subscriptionId, string dataFactoryName, string dataFactoryLocation, DateTimeOffset? createOn)
        {
            Name = name;
            SubscriptionId = subscriptionId;
            DataFactoryName = dataFactoryName;
            DataFactoryLocation = dataFactoryLocation;
            CreateOn = createOn;
        }

        /// <summary> The name of the linked integration runtime. </summary>
        public string Name { get; }
        /// <summary> The subscription ID for which the linked integration runtime belong to. </summary>
        public string SubscriptionId { get; }
        /// <summary> The name of the workspace for which the linked integration runtime belong to. </summary>
        public string DataFactoryName { get; }
        /// <summary> The location of the workspace for which the linked integration runtime belong to. </summary>
        public string DataFactoryLocation { get; }
        /// <summary> The creating time of the linked integration runtime. </summary>
        public DateTimeOffset? CreateOn { get; }
    }
}