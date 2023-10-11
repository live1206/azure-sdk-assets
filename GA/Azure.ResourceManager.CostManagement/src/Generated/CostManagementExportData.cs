// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A class representing the CostManagementExport data model.
    /// An export resource.
    /// </summary>
    public partial class CostManagementExportData : ResourceData
    {
        /// <summary> Initializes a new instance of CostManagementExportData. </summary>
        public CostManagementExportData()
        {
        }

        /// <summary> Initializes a new instance of CostManagementExportData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="format"> The format of the export being delivered. Currently only 'Csv' is supported. </param>
        /// <param name="deliveryInfo"> Has delivery information for the export. </param>
        /// <param name="definition"> Has the definition for the export. </param>
        /// <param name="runHistory"> If requested, has the most recent run history for the export. </param>
        /// <param name="partitionData"> If set to true, exported data will be partitioned by size and placed in a blob directory together with a manifest file. Note: this option is currently available only for Microsoft Customer Agreement commerce scopes. </param>
        /// <param name="nextRunTimeEstimate"> If the export has an active schedule, provides an estimate of the next run time. </param>
        /// <param name="schedule"> Has schedule information for the export. </param>
        /// <param name="eTag"> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </param>
        internal CostManagementExportData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ExportFormatType? format, ExportDeliveryInfo deliveryInfo, ExportDefinition definition, ExportExecutionListResult runHistory, bool? partitionData, DateTimeOffset? nextRunTimeEstimate, ExportSchedule schedule, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            Format = format;
            DeliveryInfo = deliveryInfo;
            Definition = definition;
            RunHistory = runHistory;
            PartitionData = partitionData;
            NextRunTimeEstimate = nextRunTimeEstimate;
            Schedule = schedule;
            ETag = eTag;
        }

        /// <summary> The format of the export being delivered. Currently only 'Csv' is supported. </summary>
        public ExportFormatType? Format { get; set; }
        /// <summary> Has delivery information for the export. </summary>
        internal ExportDeliveryInfo DeliveryInfo { get; set; }
        /// <summary> Has destination for the export being delivered. </summary>
        public ExportDeliveryDestination DeliveryInfoDestination
        {
            get => DeliveryInfo is null ? default : DeliveryInfo.Destination;
            set => DeliveryInfo = new ExportDeliveryInfo(value);
        }

        /// <summary> Has the definition for the export. </summary>
        public ExportDefinition Definition { get; set; }
        /// <summary> If requested, has the most recent run history for the export. </summary>
        internal ExportExecutionListResult RunHistory { get; set; }
        /// <summary> A list of export runs. </summary>
        public IReadOnlyList<ExportRun> RunHistoryValue
        {
            get
            {
                if (RunHistory is null)
                    RunHistory = new ExportExecutionListResult();
                return RunHistory.Value;
            }
        }

        /// <summary> If set to true, exported data will be partitioned by size and placed in a blob directory together with a manifest file. Note: this option is currently available only for Microsoft Customer Agreement commerce scopes. </summary>
        public bool? PartitionData { get; set; }
        /// <summary> If the export has an active schedule, provides an estimate of the next run time. </summary>
        public DateTimeOffset? NextRunTimeEstimate { get; }
        /// <summary> Has schedule information for the export. </summary>
        public ExportSchedule Schedule { get; set; }
        /// <summary> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </summary>
        public ETag? ETag { get; set; }
    }
}
