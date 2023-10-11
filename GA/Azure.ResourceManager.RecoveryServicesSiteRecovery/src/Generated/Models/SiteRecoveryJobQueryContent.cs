// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Query parameter to enumerate jobs. </summary>
    public partial class SiteRecoveryJobQueryContent
    {
        /// <summary> Initializes a new instance of SiteRecoveryJobQueryContent. </summary>
        public SiteRecoveryJobQueryContent()
        {
        }

        /// <summary> Date time to get jobs from. </summary>
        public string StartOn { get; set; }
        /// <summary> Date time to get jobs upto. </summary>
        public string EndOn { get; set; }
        /// <summary> The Id of the fabric to search jobs under. </summary>
        public ResourceIdentifier FabricId { get; set; }
        /// <summary> The type of objects. </summary>
        public string AffectedObjectTypes { get; set; }
        /// <summary> The states of the job to be filtered can be in. </summary>
        public string JobStatus { get; set; }
        /// <summary> The output type of the jobs. </summary>
        public ExportJobOutputSerializationType? JobOutputType { get; set; }
        /// <summary> The job Name. </summary>
        public string JobName { get; set; }
        /// <summary> The timezone offset for the location of the request (in minutes). </summary>
        public double? TimezoneOffset { get; set; }
    }
}