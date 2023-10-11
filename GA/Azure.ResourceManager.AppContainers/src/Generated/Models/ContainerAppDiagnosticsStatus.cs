// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Rendering details of a diagnostics table. </summary>
    public partial class ContainerAppDiagnosticsStatus
    {
        /// <summary> Initializes a new instance of ContainerAppDiagnosticsStatus. </summary>
        public ContainerAppDiagnosticsStatus()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppDiagnosticsStatus. </summary>
        /// <param name="message"> Diagnostic message. </param>
        /// <param name="statusId"> Status. </param>
        internal ContainerAppDiagnosticsStatus(string message, int? statusId)
        {
            Message = message;
            StatusId = statusId;
        }

        /// <summary> Diagnostic message. </summary>
        public string Message { get; set; }
        /// <summary> Status. </summary>
        public int? StatusId { get; set; }
    }
}