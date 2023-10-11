// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Databox Job Details. </summary>
    public partial class DataBoxJobDetails : DataBoxBasicJobDetails
    {
        /// <summary> Initializes a new instance of DataBoxJobDetails. </summary>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contactDetails"/> is null. </exception>
        public DataBoxJobDetails(DataBoxContactDetails contactDetails) : base(contactDetails)
        {
            Argument.AssertNotNull(contactDetails, nameof(contactDetails));

            CopyProgress = new ChangeTrackingList<DataBoxCopyProgress>();
            JobDetailsType = DataBoxOrderType.DataBox;
        }

        /// <summary> Initializes a new instance of DataBoxJobDetails. </summary>
        /// <param name="jobStages"> List of stages that run in the job. </param>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        /// <param name="shippingAddress"> Shipping address of the customer. </param>
        /// <param name="deliveryPackage"> Delivery package shipping details. </param>
        /// <param name="returnPackage"> Return package shipping details. </param>
        /// <param name="dataImportDetails"> Details of the data to be imported into azure. </param>
        /// <param name="dataExportDetails"> Details of the data to be exported from azure. </param>
        /// <param name="jobDetailsType"> Indicates the type of job details. </param>
        /// <param name="preferences"> Preferences for the order. </param>
        /// <param name="reverseShippingDetails"> Optional Reverse Shipping details for order. </param>
        /// <param name="copyLogDetails">
        /// List of copy log details.
        /// Please note <see cref="CopyLogDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxAccountCopyLogDetails"/>, <see cref="DataBoxCustomerDiskCopyLogDetails"/>, <see cref="DataBoxDiskCopyLogDetails"/> and <see cref="DataBoxHeavyAccountCopyLogDetails"/>.
        /// </param>
        /// <param name="reverseShipmentLabelSasKey"> Shared access key to download the return shipment label. </param>
        /// <param name="chainOfCustodySasKey"> Shared access key to download the chain of custody logs. </param>
        /// <param name="deviceErasureDetails"> Holds device data erasure details. </param>
        /// <param name="keyEncryptionKey"> Details about which key encryption type is being used. </param>
        /// <param name="expectedDataSizeInTerabytes"> The expected size of the data, which needs to be transferred in this job, in terabytes. </param>
        /// <param name="actions"> Available actions on the job. </param>
        /// <param name="lastMitigationActionOnJob"> Last mitigation action performed on the job. </param>
        /// <param name="dataCenterAddress">
        /// Datacenter address to ship to, for the given sku and storage location.
        /// Please note <see cref="DataCenterAddressResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataCenterAddressInstructionResult"/> and <see cref="DataCenterAddressLocationResult"/>.
        /// </param>
        /// <param name="dataCenterCode"> DataCenter code. </param>
        /// <param name="copyProgress"> Copy progress per storage account. </param>
        /// <param name="devicePassword"> Set Device password for unlocking Databox. Should not be passed for TransferType:ExportFromAzure jobs. If this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements :  Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets, numbers and these characters : @#\-$%^!+=;:_()]+. </param>
        internal DataBoxJobDetails(IReadOnlyList<DataBoxJobStage> jobStages, DataBoxContactDetails contactDetails, DataBoxShippingAddress shippingAddress, PackageShippingDetails deliveryPackage, PackageShippingDetails returnPackage, IList<DataImportDetails> dataImportDetails, IList<DataExportDetails> dataExportDetails, DataBoxOrderType jobDetailsType, DataBoxOrderPreferences preferences, ReverseShippingDetails reverseShippingDetails, IReadOnlyList<CopyLogDetails> copyLogDetails, string reverseShipmentLabelSasKey, string chainOfCustodySasKey, DeviceErasureDetails deviceErasureDetails, DataBoxKeyEncryptionKey keyEncryptionKey, int? expectedDataSizeInTerabytes, IReadOnlyList<CustomerResolutionCode> actions, LastMitigationActionOnJob lastMitigationActionOnJob, DataCenterAddressResult dataCenterAddress, DataCenterCode? dataCenterCode, IReadOnlyList<DataBoxCopyProgress> copyProgress, string devicePassword) : base(jobStages, contactDetails, shippingAddress, deliveryPackage, returnPackage, dataImportDetails, dataExportDetails, jobDetailsType, preferences, reverseShippingDetails, copyLogDetails, reverseShipmentLabelSasKey, chainOfCustodySasKey, deviceErasureDetails, keyEncryptionKey, expectedDataSizeInTerabytes, actions, lastMitigationActionOnJob, dataCenterAddress, dataCenterCode)
        {
            CopyProgress = copyProgress;
            DevicePassword = devicePassword;
            JobDetailsType = jobDetailsType;
        }

        /// <summary> Copy progress per storage account. </summary>
        public IReadOnlyList<DataBoxCopyProgress> CopyProgress { get; }
        /// <summary> Set Device password for unlocking Databox. Should not be passed for TransferType:ExportFromAzure jobs. If this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements :  Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets, numbers and these characters : @#\-$%^!+=;:_()]+. </summary>
        public string DevicePassword { get; set; }
    }
}