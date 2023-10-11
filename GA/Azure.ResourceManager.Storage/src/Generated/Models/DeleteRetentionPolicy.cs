// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The service properties for soft delete. </summary>
    public partial class DeleteRetentionPolicy
    {
        /// <summary> Initializes a new instance of DeleteRetentionPolicy. </summary>
        public DeleteRetentionPolicy()
        {
        }

        /// <summary> Initializes a new instance of DeleteRetentionPolicy. </summary>
        /// <param name="isEnabled"> Indicates whether DeleteRetentionPolicy is enabled. </param>
        /// <param name="days"> Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365. </param>
        /// <param name="allowPermanentDelete"> This property when set to true allows deletion of the soft deleted blob versions and snapshots. This property cannot be used blob restore policy. This property only applies to blob service and does not apply to containers or file share. </param>
        internal DeleteRetentionPolicy(bool? isEnabled, int? days, bool? allowPermanentDelete)
        {
            IsEnabled = isEnabled;
            Days = days;
            AllowPermanentDelete = allowPermanentDelete;
        }

        /// <summary> Indicates whether DeleteRetentionPolicy is enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365. </summary>
        public int? Days { get; set; }
        /// <summary> This property when set to true allows deletion of the soft deleted blob versions and snapshots. This property cannot be used blob restore policy. This property only applies to blob service and does not apply to containers or file share. </summary>
        public bool? AllowPermanentDelete { get; set; }
    }
}