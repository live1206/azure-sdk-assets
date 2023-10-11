// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Live trace category configuration of a Microsoft.SignalRService resource. </summary>
    public partial class SignalRLiveTraceCategory
    {
        /// <summary> Initializes a new instance of SignalRLiveTraceCategory. </summary>
        public SignalRLiveTraceCategory()
        {
        }

        /// <summary> Initializes a new instance of SignalRLiveTraceCategory. </summary>
        /// <param name="name">
        /// Gets or sets the live trace category's name.
        /// Available values: ConnectivityLogs, MessagingLogs.
        /// Case insensitive.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether or the live trace category is enabled.
        /// Available values: true, false.
        /// Case insensitive.
        /// </param>
        internal SignalRLiveTraceCategory(string name, string enabled)
        {
            Name = name;
            Enabled = enabled;
        }

        /// <summary>
        /// Gets or sets the live trace category's name.
        /// Available values: ConnectivityLogs, MessagingLogs.
        /// Case insensitive.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Indicates whether or the live trace category is enabled.
        /// Available values: true, false.
        /// Case insensitive.
        /// </summary>
        public string Enabled { get; set; }
    }
}