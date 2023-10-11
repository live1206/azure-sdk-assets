// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Details about inquired protectable items under a given container. </summary>
    public partial class WorkloadContainerInquiryInfo
    {
        /// <summary> Initializes a new instance of WorkloadContainerInquiryInfo. </summary>
        public WorkloadContainerInquiryInfo()
        {
            InquiryDetails = new ChangeTrackingList<WorkloadInquiryDetails>();
        }

        /// <summary> Initializes a new instance of WorkloadContainerInquiryInfo. </summary>
        /// <param name="status">
        /// Inquiry Status for this container such as
        /// InProgress | Failed | Succeeded
        /// </param>
        /// <param name="errorDetail"> Error Details if the Status is non-success. </param>
        /// <param name="inquiryDetails">
        /// Inquiry Details which will have workload specific details.
        /// For e.g. - For SQL and oracle this will contain different details.
        /// </param>
        internal WorkloadContainerInquiryInfo(string status, BackupErrorDetail errorDetail, IList<WorkloadInquiryDetails> inquiryDetails)
        {
            Status = status;
            ErrorDetail = errorDetail;
            InquiryDetails = inquiryDetails;
        }

        /// <summary>
        /// Inquiry Status for this container such as
        /// InProgress | Failed | Succeeded
        /// </summary>
        public string Status { get; set; }
        /// <summary> Error Details if the Status is non-success. </summary>
        public BackupErrorDetail ErrorDetail { get; set; }
        /// <summary>
        /// Inquiry Details which will have workload specific details.
        /// For e.g. - For SQL and oracle this will contain different details.
        /// </summary>
        public IList<WorkloadInquiryDetails> InquiryDetails { get; }
    }
}