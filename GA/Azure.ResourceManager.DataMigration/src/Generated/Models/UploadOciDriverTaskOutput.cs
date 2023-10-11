// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the service task to upload an OCI driver. </summary>
    public partial class UploadOciDriverTaskOutput
    {
        /// <summary> Initializes a new instance of UploadOciDriverTaskOutput. </summary>
        internal UploadOciDriverTaskOutput()
        {
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of UploadOciDriverTaskOutput. </summary>
        /// <param name="driverPackageName"> The name of the driver package that was validated and uploaded. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        internal UploadOciDriverTaskOutput(string driverPackageName, IReadOnlyList<ReportableException> validationErrors)
        {
            DriverPackageName = driverPackageName;
            ValidationErrors = validationErrors;
        }

        /// <summary> The name of the driver package that was validated and uploaded. </summary>
        public string DriverPackageName { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}