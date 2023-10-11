// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Properties that define a Continuous Export configuration. </summary>
    public partial class ApplicationInsightsComponentExportConfiguration
    {
        /// <summary> Initializes a new instance of ApplicationInsightsComponentExportConfiguration. </summary>
        internal ApplicationInsightsComponentExportConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentExportConfiguration. </summary>
        /// <param name="exportId"> The unique ID of the export configuration inside an Application Insights component. It is auto generated when the Continuous Export configuration is created. </param>
        /// <param name="instrumentationKey"> The instrumentation key of the Application Insights component. </param>
        /// <param name="recordTypes"> This comma separated list of document types that will be exported. The possible values include 'Requests', 'Event', 'Exceptions', 'Metrics', 'PageViews', 'PageViewPerformance', 'Rdd', 'PerformanceCounters', 'Availability', 'Messages'. </param>
        /// <param name="applicationName"> The name of the Application Insights component. </param>
        /// <param name="subscriptionId"> The subscription of the Application Insights component. </param>
        /// <param name="resourceGroup"> The resource group of the Application Insights component. </param>
        /// <param name="destinationStorageSubscriptionId"> The destination storage account subscription ID. </param>
        /// <param name="destinationStorageLocationId"> The destination account location ID. </param>
        /// <param name="destinationAccountId"> The name of destination account. </param>
        /// <param name="destinationType"> The destination type. </param>
        /// <param name="isUserEnabled"> This will be 'true' if the Continuous Export configuration is enabled, otherwise it will be 'false'. </param>
        /// <param name="lastUserUpdate"> Last time the Continuous Export configuration was updated. </param>
        /// <param name="notificationQueueEnabled"> Deprecated. </param>
        /// <param name="exportStatus"> This indicates current Continuous Export configuration status. The possible values are 'Preparing', 'Success', 'Failure'. </param>
        /// <param name="lastSuccessTime"> The last time data was successfully delivered to the destination storage container for this Continuous Export configuration. </param>
        /// <param name="lastGapTime"> The last time the Continuous Export configuration started failing. </param>
        /// <param name="permanentErrorReason"> This is the reason the Continuous Export configuration started failing. It can be 'AzureStorageNotFound' or 'AzureStorageAccessDenied'. </param>
        /// <param name="storageName"> The name of the destination storage account. </param>
        /// <param name="containerName"> The name of the destination storage container. </param>
        internal ApplicationInsightsComponentExportConfiguration(string exportId, string instrumentationKey, string recordTypes, string applicationName, string subscriptionId, string resourceGroup, string destinationStorageSubscriptionId, string destinationStorageLocationId, string destinationAccountId, string destinationType, string isUserEnabled, string lastUserUpdate, string notificationQueueEnabled, string exportStatus, string lastSuccessTime, string lastGapTime, string permanentErrorReason, string storageName, string containerName)
        {
            ExportId = exportId;
            InstrumentationKey = instrumentationKey;
            RecordTypes = recordTypes;
            ApplicationName = applicationName;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            DestinationStorageSubscriptionId = destinationStorageSubscriptionId;
            DestinationStorageLocationId = destinationStorageLocationId;
            DestinationAccountId = destinationAccountId;
            DestinationType = destinationType;
            IsUserEnabled = isUserEnabled;
            LastUserUpdate = lastUserUpdate;
            NotificationQueueEnabled = notificationQueueEnabled;
            ExportStatus = exportStatus;
            LastSuccessTime = lastSuccessTime;
            LastGapTime = lastGapTime;
            PermanentErrorReason = permanentErrorReason;
            StorageName = storageName;
            ContainerName = containerName;
        }

        /// <summary> The unique ID of the export configuration inside an Application Insights component. It is auto generated when the Continuous Export configuration is created. </summary>
        public string ExportId { get; }
        /// <summary> The instrumentation key of the Application Insights component. </summary>
        public string InstrumentationKey { get; }
        /// <summary> This comma separated list of document types that will be exported. The possible values include 'Requests', 'Event', 'Exceptions', 'Metrics', 'PageViews', 'PageViewPerformance', 'Rdd', 'PerformanceCounters', 'Availability', 'Messages'. </summary>
        public string RecordTypes { get; }
        /// <summary> The name of the Application Insights component. </summary>
        public string ApplicationName { get; }
        /// <summary> The subscription of the Application Insights component. </summary>
        public string SubscriptionId { get; }
        /// <summary> The resource group of the Application Insights component. </summary>
        public string ResourceGroup { get; }
        /// <summary> The destination storage account subscription ID. </summary>
        public string DestinationStorageSubscriptionId { get; }
        /// <summary> The destination account location ID. </summary>
        public string DestinationStorageLocationId { get; }
        /// <summary> The name of destination account. </summary>
        public string DestinationAccountId { get; }
        /// <summary> The destination type. </summary>
        public string DestinationType { get; }
        /// <summary> This will be 'true' if the Continuous Export configuration is enabled, otherwise it will be 'false'. </summary>
        public string IsUserEnabled { get; }
        /// <summary> Last time the Continuous Export configuration was updated. </summary>
        public string LastUserUpdate { get; }
        /// <summary> Deprecated. </summary>
        public string NotificationQueueEnabled { get; }
        /// <summary> This indicates current Continuous Export configuration status. The possible values are 'Preparing', 'Success', 'Failure'. </summary>
        public string ExportStatus { get; }
        /// <summary> The last time data was successfully delivered to the destination storage container for this Continuous Export configuration. </summary>
        public string LastSuccessTime { get; }
        /// <summary> The last time the Continuous Export configuration started failing. </summary>
        public string LastGapTime { get; }
        /// <summary> This is the reason the Continuous Export configuration started failing. It can be 'AzureStorageNotFound' or 'AzureStorageAccessDenied'. </summary>
        public string PermanentErrorReason { get; }
        /// <summary> The name of the destination storage account. </summary>
        public string StorageName { get; }
        /// <summary> The name of the destination storage container. </summary>
        public string ContainerName { get; }
    }
}