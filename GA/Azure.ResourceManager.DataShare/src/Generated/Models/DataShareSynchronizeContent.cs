// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Payload for the synchronizing the data. </summary>
    public partial class DataShareSynchronizeContent
    {
        /// <summary> Initializes a new instance of DataShareSynchronizeContent. </summary>
        public DataShareSynchronizeContent()
        {
        }

        /// <summary> Mode of synchronization used in triggers and snapshot sync. Incremental by default. </summary>
        public SynchronizationMode? SynchronizationMode { get; set; }
    }
}