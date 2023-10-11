// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Windows operating system settings to apply to the virtual machine. </summary>
    internal partial class WindowsConfiguration
    {
        /// <summary> Initializes a new instance of WindowsConfiguration. </summary>
        public WindowsConfiguration()
        {
        }

        /// <summary> Initializes a new instance of WindowsConfiguration. </summary>
        /// <param name="isAutomaticUpdateEnabled"> If omitted, the default value is true. </param>
        internal WindowsConfiguration(bool? isAutomaticUpdateEnabled)
        {
            IsAutomaticUpdateEnabled = isAutomaticUpdateEnabled;
        }

        /// <summary> If omitted, the default value is true. </summary>
        public bool? IsAutomaticUpdateEnabled { get; set; }
    }
}