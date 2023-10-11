// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The Linux operation systems profile. </summary>
    internal partial class OSProfile
    {
        /// <summary> Initializes a new instance of OSProfile. </summary>
        public OSProfile()
        {
        }

        /// <summary> Initializes a new instance of OSProfile. </summary>
        /// <param name="linuxProfile"> The Linux OS profile. </param>
        internal OSProfile(HDInsightLinuxOSProfile linuxProfile)
        {
            LinuxProfile = linuxProfile;
        }

        /// <summary> The Linux OS profile. </summary>
        public HDInsightLinuxOSProfile LinuxProfile { get; set; }
    }
}