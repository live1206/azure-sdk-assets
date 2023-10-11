// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing Response from Diagnostic Detectors. </summary>
    public partial class DiagnosticDetectorResponse : ResourceData
    {
        /// <summary> Initializes a new instance of DiagnosticDetectorResponse. </summary>
        public DiagnosticDetectorResponse()
        {
            Metrics = new ChangeTrackingList<DiagnosticMetricSet>();
            AbnormalTimePeriods = new ChangeTrackingList<DetectorAbnormalTimePeriod>();
            Data = new ChangeTrackingList<IList<AppServiceNameValuePair>>();
        }

        /// <summary> Initializes a new instance of DiagnosticDetectorResponse. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startOn"> Start time of the period. </param>
        /// <param name="endOn"> End time of the period. </param>
        /// <param name="issueDetected"> Flag representing Issue was detected. </param>
        /// <param name="detectorDefinition"> Detector's definition. </param>
        /// <param name="metrics"> Metrics provided by the detector. </param>
        /// <param name="abnormalTimePeriods"> List of Correlated events found by the detector. </param>
        /// <param name="data"> Additional Data that detector wants to send. </param>
        /// <param name="responseMetaData"> Meta Data. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal DiagnosticDetectorResponse(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? startOn, DateTimeOffset? endOn, bool? issueDetected, DetectorDefinition detectorDefinition, IList<DiagnosticMetricSet> metrics, IList<DetectorAbnormalTimePeriod> abnormalTimePeriods, IList<IList<AppServiceNameValuePair>> data, DetectorMetadata responseMetaData, string kind) : base(id, name, resourceType, systemData)
        {
            StartOn = startOn;
            EndOn = endOn;
            IssueDetected = issueDetected;
            DetectorDefinition = detectorDefinition;
            Metrics = metrics;
            AbnormalTimePeriods = abnormalTimePeriods;
            Data = data;
            ResponseMetaData = responseMetaData;
            Kind = kind;
        }

        /// <summary> Start time of the period. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time of the period. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Flag representing Issue was detected. </summary>
        public bool? IssueDetected { get; set; }
        /// <summary> Detector's definition. </summary>
        public DetectorDefinition DetectorDefinition { get; set; }
        /// <summary> Metrics provided by the detector. </summary>
        public IList<DiagnosticMetricSet> Metrics { get; }
        /// <summary> List of Correlated events found by the detector. </summary>
        public IList<DetectorAbnormalTimePeriod> AbnormalTimePeriods { get; }
        /// <summary> Additional Data that detector wants to send. </summary>
        public IList<IList<AppServiceNameValuePair>> Data { get; }
        /// <summary> Meta Data. </summary>
        internal DetectorMetadata ResponseMetaData { get; set; }
        /// <summary> Source of the Data. </summary>
        public DetectorDataSource DataSource
        {
            get => ResponseMetaData is null ? default : ResponseMetaData.DataSource;
            set
            {
                if (ResponseMetaData is null)
                    ResponseMetaData = new DetectorMetadata();
                ResponseMetaData.DataSource = value;
            }
        }

        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}