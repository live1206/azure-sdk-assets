// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Granular Copy Log Details for customer disk. </summary>
    public partial class DataBoxDiskGranularCopyLogDetails : GranularCopyLogDetails
    {
        /// <summary> Initializes a new instance of DataBoxDiskGranularCopyLogDetails. </summary>
        internal DataBoxDiskGranularCopyLogDetails()
        {
            CopyLogDetailsType = DataBoxOrderType.DataBoxCustomerDisk;
        }

        /// <summary> Initializes a new instance of DataBoxDiskGranularCopyLogDetails. </summary>
        /// <param name="copyLogDetailsType"> Indicates the type of job details. </param>
        /// <param name="serialNumber"> Disk Serial Number. </param>
        /// <param name="accountId"> Account id. </param>
        /// <param name="errorLogLink"> Link for copy error logs. </param>
        /// <param name="verboseLogLink"> Link for copy verbose logs. </param>
        internal DataBoxDiskGranularCopyLogDetails(DataBoxOrderType copyLogDetailsType, string serialNumber, ResourceIdentifier accountId, string errorLogLink, string verboseLogLink) : base(copyLogDetailsType)
        {
            SerialNumber = serialNumber;
            AccountId = accountId;
            ErrorLogLink = errorLogLink;
            VerboseLogLink = verboseLogLink;
            CopyLogDetailsType = copyLogDetailsType;
        }

        /// <summary> Disk Serial Number. </summary>
        public string SerialNumber { get; }
        /// <summary> Account id. </summary>
        public ResourceIdentifier AccountId { get; }
        /// <summary> Link for copy error logs. </summary>
        public string ErrorLogLink { get; }
        /// <summary> Link for copy verbose logs. </summary>
        public string VerboseLogLink { get; }
    }
}