// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The ServiceAlertCollectionGetAllOptions. </summary>
    public partial class ServiceAlertCollectionGetAllOptions
    {
        /// <summary> Initializes a new instance of ServiceAlertCollectionGetAllOptions. </summary>
        public ServiceAlertCollectionGetAllOptions()
        {
        }

        /// <summary> Filter by target resource( which is full ARM ID) Default value is select all. </summary>
        public string TargetResource { get; set; }
        /// <summary> Filter by target resource type. Default value is select all. </summary>
        public string TargetResourceType { get; set; }
        /// <summary> Filter by target resource group name. Default value is select all. </summary>
        public string TargetResourceGroup { get; set; }
        /// <summary> Filter by monitor service which generates the alert instance. Default value is select all. </summary>
        public MonitorServiceSourceForAlert? MonitorService { get; set; }
        /// <summary> Filter by monitor condition which is either 'Fired' or 'Resolved'. Default value is to select all. </summary>
        public MonitorCondition? MonitorCondition { get; set; }
        /// <summary> Filter by severity.  Default value is select all. </summary>
        public ServiceAlertSeverity? Severity { get; set; }
        /// <summary> Filter by state of the alert instance. Default value is to select all. </summary>
        public ServiceAlertState? AlertState { get; set; }
        /// <summary> Filter by specific alert rule.  Default value is to select all. </summary>
        public string AlertRule { get; set; }
        /// <summary> Filter the alerts list by the Smart Group Id. Default value is none. </summary>
        public string SmartGroupId { get; set; }
        /// <summary> Include context which has contextual data specific to the monitor service. Default value is false'. </summary>
        public bool? IncludeContext { get; set; }
        /// <summary> Include egress config which would be used for displaying the content in portal.  Default value is 'false'. </summary>
        public bool? IncludeEgressConfig { get; set; }
        /// <summary> Determines number of alerts returned per page in response. Permissible value is between 1 to 250. When the "includeContent"  filter is selected, maximum value allowed is 25. Default value is 25. </summary>
        public long? PageCount { get; set; }
        /// <summary> Sort the query results by input field,  Default value is 'lastModifiedDateTime'. </summary>
        public ListServiceAlertsSortByField? SortBy { get; set; }
        /// <summary> Sort the query results order in either ascending or descending.  Default value is 'desc' for time fields and 'asc' for others. </summary>
        public AlertsManagementQuerySortOrder? SortOrder { get; set; }
        /// <summary> This filter allows to selection of the fields(comma separated) which would  be part of the essential section. This would allow to project only the  required fields rather than getting entire content.  Default is to fetch all the fields in the essentials section. </summary>
        public string Select { get; set; }
        /// <summary> Filter by time range by below listed values. Default value is 1 day. </summary>
        public TimeRangeFilter? TimeRange { get; set; }
        /// <summary> Filter by custom time range in the format &lt;start-time&gt;/&lt;end-time&gt;  where time is in (ISO-8601 format)'. Permissible values is within 30 days from  query time. Either timeRange or customTimeRange could be used but not both. Default is none. </summary>
        public string CustomTimeRange { get; set; }
    }
}