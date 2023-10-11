// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of a source based trigger. </summary>
    public partial class ContainerRegistrySourceTrigger
    {
        /// <summary> Initializes a new instance of ContainerRegistrySourceTrigger. </summary>
        /// <param name="sourceRepository"> The properties that describes the source(code) for the task. </param>
        /// <param name="sourceTriggerEvents"> The source event corresponding to the trigger. </param>
        /// <param name="name"> The name of the trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceRepository"/>, <paramref name="sourceTriggerEvents"/> or <paramref name="name"/> is null. </exception>
        public ContainerRegistrySourceTrigger(SourceCodeRepoProperties sourceRepository, IEnumerable<ContainerRegistrySourceTriggerEvent> sourceTriggerEvents, string name)
        {
            Argument.AssertNotNull(sourceRepository, nameof(sourceRepository));
            Argument.AssertNotNull(sourceTriggerEvents, nameof(sourceTriggerEvents));
            Argument.AssertNotNull(name, nameof(name));

            SourceRepository = sourceRepository;
            SourceTriggerEvents = sourceTriggerEvents.ToList();
            Name = name;
        }

        /// <summary> Initializes a new instance of ContainerRegistrySourceTrigger. </summary>
        /// <param name="sourceRepository"> The properties that describes the source(code) for the task. </param>
        /// <param name="sourceTriggerEvents"> The source event corresponding to the trigger. </param>
        /// <param name="status"> The current status of trigger. </param>
        /// <param name="name"> The name of the trigger. </param>
        internal ContainerRegistrySourceTrigger(SourceCodeRepoProperties sourceRepository, IList<ContainerRegistrySourceTriggerEvent> sourceTriggerEvents, ContainerRegistryTriggerStatus? status, string name)
        {
            SourceRepository = sourceRepository;
            SourceTriggerEvents = sourceTriggerEvents;
            Status = status;
            Name = name;
        }

        /// <summary> The properties that describes the source(code) for the task. </summary>
        public SourceCodeRepoProperties SourceRepository { get; set; }
        /// <summary> The source event corresponding to the trigger. </summary>
        public IList<ContainerRegistrySourceTriggerEvent> SourceTriggerEvents { get; }
        /// <summary> The current status of trigger. </summary>
        public ContainerRegistryTriggerStatus? Status { get; set; }
        /// <summary> The name of the trigger. </summary>
        public string Name { get; set; }
    }
}