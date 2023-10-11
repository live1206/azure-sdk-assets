// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The check availability result. </summary>
    public partial class DevCenterNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of DevCenterNameAvailabilityResult. </summary>
        internal DevCenterNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of DevCenterNameAvailabilityResult. </summary>
        /// <param name="isNameAvailable"> Indicates if the resource name is available. </param>
        /// <param name="reason"> The reason why the given name is not available. </param>
        /// <param name="message"> Detailed reason why the given name is available. </param>
        internal DevCenterNameAvailabilityResult(bool? isNameAvailable, DevCenterNameUnavailableReason? reason, string message)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> Indicates if the resource name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason why the given name is not available. </summary>
        public DevCenterNameUnavailableReason? Reason { get; }
        /// <summary> Detailed reason why the given name is available. </summary>
        public string Message { get; }
    }
}