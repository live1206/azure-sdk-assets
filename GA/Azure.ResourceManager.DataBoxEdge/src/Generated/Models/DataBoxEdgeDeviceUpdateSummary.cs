// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Details about ongoing updates and availability of updates on the device. </summary>
    public partial class DataBoxEdgeDeviceUpdateSummary : ResourceData
    {
        /// <summary> Initializes a new instance of DataBoxEdgeDeviceUpdateSummary. </summary>
        public DataBoxEdgeDeviceUpdateSummary()
        {
            UpdateTitles = new ChangeTrackingList<string>();
            Updates = new ChangeTrackingList<DataBoxEdgeUpdateDetails>();
        }

        /// <summary> Initializes a new instance of DataBoxEdgeDeviceUpdateSummary. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deviceVersionNumber"> The current version of the device in format: 1.2.17312.13.",. </param>
        /// <param name="friendlyDeviceVersionName"> The current version of the device in text format. </param>
        /// <param name="deviceLastScannedOn"> The last time when a scan was done on the device. </param>
        /// <param name="lastCompletedScanJobOn"> The time when the last scan job was completed (success/cancelled/failed) on the appliance. </param>
        /// <param name="lastSuccessfulScanJobOn"> Time when the last scan job is successfully completed. </param>
        /// <param name="lastCompletedDownloadJobOn"> The time when the last Download job was completed (success/cancelled/failed) on the appliance. </param>
        /// <param name="lastCompletedDownloadJobId"> JobId of the last ran download job.(Can be success/cancelled/failed). </param>
        /// <param name="lastDownloadJobStatus"> JobStatus of the last ran download job. </param>
        /// <param name="lastSuccessfulInstallJobOn"> The time when the Last Install job was completed successfully on the appliance. </param>
        /// <param name="lastCompletedInstallJobOn"> The time when the last Install job was completed (success/cancelled/failed) on the appliance. </param>
        /// <param name="lastCompletedInstallJobId"> JobId of the last ran install job.(Can be success/cancelled/failed). </param>
        /// <param name="lastInstallJobStatus"> JobStatus of the last ran install job. </param>
        /// <param name="totalNumberOfUpdatesAvailable"> The number of updates available for the current device version as per the last device scan. </param>
        /// <param name="totalNumberOfUpdatesPendingDownload"> The total number of items pending download. </param>
        /// <param name="totalNumberOfUpdatesPendingInstall"> The total number of items pending install. </param>
        /// <param name="rebootBehavior"> Indicates if updates are available and at least one of the updates needs a reboot. </param>
        /// <param name="ongoingUpdateOperation"> The current update operation. </param>
        /// <param name="inProgressDownloadJobId"> The job ID of the download job in progress. </param>
        /// <param name="inProgressInstallJobId"> The job ID of the install job in progress. </param>
        /// <param name="inProgressDownloadJobStartedOn"> The time when the currently running download (if any) started. </param>
        /// <param name="inProgressInstallJobStartedOn"> The time when the currently running install (if any) started. </param>
        /// <param name="updateTitles"> The list of updates available for install. </param>
        /// <param name="updates"> The list of updates available for install. </param>
        /// <param name="totalUpdateSizeInBytes"> The total size of updates available for download in bytes. </param>
        /// <param name="totalTimeInMinutes"> The total time in Minutes. </param>
        internal DataBoxEdgeDeviceUpdateSummary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string deviceVersionNumber, string friendlyDeviceVersionName, DateTimeOffset? deviceLastScannedOn, DateTimeOffset? lastCompletedScanJobOn, DateTimeOffset? lastSuccessfulScanJobOn, DateTimeOffset? lastCompletedDownloadJobOn, ResourceIdentifier lastCompletedDownloadJobId, DataBoxEdgeJobStatus? lastDownloadJobStatus, DateTimeOffset? lastSuccessfulInstallJobOn, DateTimeOffset? lastCompletedInstallJobOn, ResourceIdentifier lastCompletedInstallJobId, DataBoxEdgeJobStatus? lastInstallJobStatus, int? totalNumberOfUpdatesAvailable, int? totalNumberOfUpdatesPendingDownload, int? totalNumberOfUpdatesPendingInstall, InstallRebootBehavior? rebootBehavior, DataBoxEdgeUpdateOperation? ongoingUpdateOperation, ResourceIdentifier inProgressDownloadJobId, ResourceIdentifier inProgressInstallJobId, DateTimeOffset? inProgressDownloadJobStartedOn, DateTimeOffset? inProgressInstallJobStartedOn, IReadOnlyList<string> updateTitles, IReadOnlyList<DataBoxEdgeUpdateDetails> updates, double? totalUpdateSizeInBytes, int? totalTimeInMinutes) : base(id, name, resourceType, systemData)
        {
            DeviceVersionNumber = deviceVersionNumber;
            FriendlyDeviceVersionName = friendlyDeviceVersionName;
            DeviceLastScannedOn = deviceLastScannedOn;
            LastCompletedScanJobOn = lastCompletedScanJobOn;
            LastSuccessfulScanJobOn = lastSuccessfulScanJobOn;
            LastCompletedDownloadJobOn = lastCompletedDownloadJobOn;
            LastCompletedDownloadJobId = lastCompletedDownloadJobId;
            LastDownloadJobStatus = lastDownloadJobStatus;
            LastSuccessfulInstallJobOn = lastSuccessfulInstallJobOn;
            LastCompletedInstallJobOn = lastCompletedInstallJobOn;
            LastCompletedInstallJobId = lastCompletedInstallJobId;
            LastInstallJobStatus = lastInstallJobStatus;
            TotalNumberOfUpdatesAvailable = totalNumberOfUpdatesAvailable;
            TotalNumberOfUpdatesPendingDownload = totalNumberOfUpdatesPendingDownload;
            TotalNumberOfUpdatesPendingInstall = totalNumberOfUpdatesPendingInstall;
            RebootBehavior = rebootBehavior;
            OngoingUpdateOperation = ongoingUpdateOperation;
            InProgressDownloadJobId = inProgressDownloadJobId;
            InProgressInstallJobId = inProgressInstallJobId;
            InProgressDownloadJobStartedOn = inProgressDownloadJobStartedOn;
            InProgressInstallJobStartedOn = inProgressInstallJobStartedOn;
            UpdateTitles = updateTitles;
            Updates = updates;
            TotalUpdateSizeInBytes = totalUpdateSizeInBytes;
            TotalTimeInMinutes = totalTimeInMinutes;
        }

        /// <summary> The current version of the device in format: 1.2.17312.13.",. </summary>
        public string DeviceVersionNumber { get; set; }
        /// <summary> The current version of the device in text format. </summary>
        public string FriendlyDeviceVersionName { get; set; }
        /// <summary> The last time when a scan was done on the device. </summary>
        public DateTimeOffset? DeviceLastScannedOn { get; set; }
        /// <summary> The time when the last scan job was completed (success/cancelled/failed) on the appliance. </summary>
        public DateTimeOffset? LastCompletedScanJobOn { get; set; }
        /// <summary> Time when the last scan job is successfully completed. </summary>
        public DateTimeOffset? LastSuccessfulScanJobOn { get; set; }
        /// <summary> The time when the last Download job was completed (success/cancelled/failed) on the appliance. </summary>
        public DateTimeOffset? LastCompletedDownloadJobOn { get; }
        /// <summary> JobId of the last ran download job.(Can be success/cancelled/failed). </summary>
        public ResourceIdentifier LastCompletedDownloadJobId { get; }
        /// <summary> JobStatus of the last ran download job. </summary>
        public DataBoxEdgeJobStatus? LastDownloadJobStatus { get; }
        /// <summary> The time when the Last Install job was completed successfully on the appliance. </summary>
        public DateTimeOffset? LastSuccessfulInstallJobOn { get; set; }
        /// <summary> The time when the last Install job was completed (success/cancelled/failed) on the appliance. </summary>
        public DateTimeOffset? LastCompletedInstallJobOn { get; }
        /// <summary> JobId of the last ran install job.(Can be success/cancelled/failed). </summary>
        public ResourceIdentifier LastCompletedInstallJobId { get; }
        /// <summary> JobStatus of the last ran install job. </summary>
        public DataBoxEdgeJobStatus? LastInstallJobStatus { get; }
        /// <summary> The number of updates available for the current device version as per the last device scan. </summary>
        public int? TotalNumberOfUpdatesAvailable { get; }
        /// <summary> The total number of items pending download. </summary>
        public int? TotalNumberOfUpdatesPendingDownload { get; }
        /// <summary> The total number of items pending install. </summary>
        public int? TotalNumberOfUpdatesPendingInstall { get; }
        /// <summary> Indicates if updates are available and at least one of the updates needs a reboot. </summary>
        public InstallRebootBehavior? RebootBehavior { get; }
        /// <summary> The current update operation. </summary>
        public DataBoxEdgeUpdateOperation? OngoingUpdateOperation { get; }
        /// <summary> The job ID of the download job in progress. </summary>
        public ResourceIdentifier InProgressDownloadJobId { get; }
        /// <summary> The job ID of the install job in progress. </summary>
        public ResourceIdentifier InProgressInstallJobId { get; }
        /// <summary> The time when the currently running download (if any) started. </summary>
        public DateTimeOffset? InProgressDownloadJobStartedOn { get; }
        /// <summary> The time when the currently running install (if any) started. </summary>
        public DateTimeOffset? InProgressInstallJobStartedOn { get; }
        /// <summary> The list of updates available for install. </summary>
        public IReadOnlyList<string> UpdateTitles { get; }
        /// <summary> The list of updates available for install. </summary>
        public IReadOnlyList<DataBoxEdgeUpdateDetails> Updates { get; }
        /// <summary> The total size of updates available for download in bytes. </summary>
        public double? TotalUpdateSizeInBytes { get; }
        /// <summary> The total time in Minutes. </summary>
        public int? TotalTimeInMinutes { get; }
    }
}