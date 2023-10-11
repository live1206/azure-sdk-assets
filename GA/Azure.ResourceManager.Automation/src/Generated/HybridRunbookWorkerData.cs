// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the HybridRunbookWorker data model.
    /// Definition of hybrid runbook worker.
    /// </summary>
    public partial class HybridRunbookWorkerData : ResourceData
    {
        /// <summary> Initializes a new instance of HybridRunbookWorkerData. </summary>
        public HybridRunbookWorkerData()
        {
        }

        /// <summary> Initializes a new instance of HybridRunbookWorkerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="ip"> Gets or sets the assigned machine IP address. </param>
        /// <param name="registeredOn"> Gets or sets the registration time of the worker machine. </param>
        /// <param name="lastSeenOn"> Last Heartbeat from the Worker. </param>
        /// <param name="vmResourceId"> Azure Resource Manager Id for a virtual machine. </param>
        /// <param name="workerType"> Type of the HybridWorker. </param>
        /// <param name="workerName"> Name of the HybridWorker. </param>
        internal HybridRunbookWorkerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string ip, DateTimeOffset? registeredOn, DateTimeOffset? lastSeenOn, ResourceIdentifier vmResourceId, HybridWorkerType? workerType, string workerName) : base(id, name, resourceType, systemData)
        {
            IP = ip;
            RegisteredOn = registeredOn;
            LastSeenOn = lastSeenOn;
            VmResourceId = vmResourceId;
            WorkerType = workerType;
            WorkerName = workerName;
        }

        /// <summary> Gets or sets the assigned machine IP address. </summary>
        public string IP { get; set; }
        /// <summary> Gets or sets the registration time of the worker machine. </summary>
        public DateTimeOffset? RegisteredOn { get; set; }
        /// <summary> Last Heartbeat from the Worker. </summary>
        public DateTimeOffset? LastSeenOn { get; set; }
        /// <summary> Azure Resource Manager Id for a virtual machine. </summary>
        public ResourceIdentifier VmResourceId { get; set; }
        /// <summary> Type of the HybridWorker. </summary>
        public HybridWorkerType? WorkerType { get; set; }
        /// <summary> Name of the HybridWorker. </summary>
        public string WorkerName { get; set; }
    }
}