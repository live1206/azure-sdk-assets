// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Auto-pausing properties of a Big Data pool powered by Apache Spark. </summary>
    public partial class BigDataPoolAutoPauseProperties
    {
        /// <summary> Initializes a new instance of BigDataPoolAutoPauseProperties. </summary>
        public BigDataPoolAutoPauseProperties()
        {
        }

        /// <summary> Initializes a new instance of BigDataPoolAutoPauseProperties. </summary>
        /// <param name="delayInMinutes"> Number of minutes of idle time before the Big Data pool is automatically paused. </param>
        /// <param name="isEnabled"> Whether auto-pausing is enabled for the Big Data pool. </param>
        internal BigDataPoolAutoPauseProperties(int? delayInMinutes, bool? isEnabled)
        {
            DelayInMinutes = delayInMinutes;
            IsEnabled = isEnabled;
        }

        /// <summary> Number of minutes of idle time before the Big Data pool is automatically paused. </summary>
        public int? DelayInMinutes { get; set; }
        /// <summary> Whether auto-pausing is enabled for the Big Data pool. </summary>
        public bool? IsEnabled { get; set; }
    }
}