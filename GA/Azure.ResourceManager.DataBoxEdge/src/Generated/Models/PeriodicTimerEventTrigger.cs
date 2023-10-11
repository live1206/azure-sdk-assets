// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Trigger details. </summary>
    public partial class PeriodicTimerEventTrigger : DataBoxEdgeTriggerData
    {
        /// <summary> Initializes a new instance of PeriodicTimerEventTrigger. </summary>
        /// <param name="sourceInfo"> Periodic timer details. </param>
        /// <param name="sinkInfo"> Role Sink information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceInfo"/> or <paramref name="sinkInfo"/> is null. </exception>
        public PeriodicTimerEventTrigger(PeriodicTimerSourceInfo sourceInfo, DataBoxEdgeRoleSinkInfo sinkInfo)
        {
            Argument.AssertNotNull(sourceInfo, nameof(sourceInfo));
            Argument.AssertNotNull(sinkInfo, nameof(sinkInfo));

            SourceInfo = sourceInfo;
            SinkInfo = sinkInfo;
            Kind = TriggerEventType.PeriodicTimerEvent;
        }

        /// <summary> Initializes a new instance of PeriodicTimerEventTrigger. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Trigger Kind. </param>
        /// <param name="sourceInfo"> Periodic timer details. </param>
        /// <param name="sinkInfo"> Role Sink information. </param>
        /// <param name="customContextTag"> A custom context tag typically used to correlate the trigger against its usage. For example, if a periodic timer trigger is intended for certain specific IoT modules in the device, the tag can be the name or the image URL of the module. </param>
        internal PeriodicTimerEventTrigger(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TriggerEventType kind, PeriodicTimerSourceInfo sourceInfo, DataBoxEdgeRoleSinkInfo sinkInfo, string customContextTag) : base(id, name, resourceType, systemData, kind)
        {
            SourceInfo = sourceInfo;
            SinkInfo = sinkInfo;
            CustomContextTag = customContextTag;
            Kind = kind;
        }

        /// <summary> Periodic timer details. </summary>
        public PeriodicTimerSourceInfo SourceInfo { get; set; }
        /// <summary> Role Sink information. </summary>
        internal DataBoxEdgeRoleSinkInfo SinkInfo { get; set; }
        /// <summary> Compute role ID. </summary>
        public ResourceIdentifier SinkInfoRoleId
        {
            get => SinkInfo is null ? default : SinkInfo.RoleId;
            set => SinkInfo = new DataBoxEdgeRoleSinkInfo(value);
        }

        /// <summary> A custom context tag typically used to correlate the trigger against its usage. For example, if a periodic timer trigger is intended for certain specific IoT modules in the device, the tag can be the name or the image URL of the module. </summary>
        public string CustomContextTag { get; set; }
    }
}
