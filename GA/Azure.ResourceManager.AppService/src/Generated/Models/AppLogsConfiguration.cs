// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The AppLogsConfiguration. </summary>
    public partial class AppLogsConfiguration
    {
        /// <summary> Initializes a new instance of AppLogsConfiguration. </summary>
        public AppLogsConfiguration()
        {
        }

        /// <summary> Initializes a new instance of AppLogsConfiguration. </summary>
        /// <param name="destination"></param>
        /// <param name="logAnalyticsConfiguration"></param>
        internal AppLogsConfiguration(string destination, LogAnalyticsConfiguration logAnalyticsConfiguration)
        {
            Destination = destination;
            LogAnalyticsConfiguration = logAnalyticsConfiguration;
        }

        /// <summary> Gets or sets the destination. </summary>
        public string Destination { get; set; }
        /// <summary> Gets or sets the log analytics configuration. </summary>
        public LogAnalyticsConfiguration LogAnalyticsConfiguration { get; set; }
    }
}
