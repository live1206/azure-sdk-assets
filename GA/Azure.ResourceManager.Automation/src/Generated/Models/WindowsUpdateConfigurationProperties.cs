// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Windows specific update configuration. </summary>
    public partial class WindowsUpdateConfigurationProperties
    {
        /// <summary> Initializes a new instance of WindowsUpdateConfigurationProperties. </summary>
        public WindowsUpdateConfigurationProperties()
        {
            ExcludedKBNumbers = new ChangeTrackingList<string>();
            IncludedKBNumbers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of WindowsUpdateConfigurationProperties. </summary>
        /// <param name="includedUpdateClassifications"> Update classification included in the software update configuration. A comma separated string with required values. </param>
        /// <param name="excludedKBNumbers"> KB numbers excluded from the software update configuration. </param>
        /// <param name="includedKBNumbers"> KB numbers included from the software update configuration. </param>
        /// <param name="rebootSetting"> Reboot setting for the software update configuration. </param>
        internal WindowsUpdateConfigurationProperties(WindowsUpdateClassification? includedUpdateClassifications, IList<string> excludedKBNumbers, IList<string> includedKBNumbers, string rebootSetting)
        {
            IncludedUpdateClassifications = includedUpdateClassifications;
            ExcludedKBNumbers = excludedKBNumbers;
            IncludedKBNumbers = includedKBNumbers;
            RebootSetting = rebootSetting;
        }

        /// <summary> Update classification included in the software update configuration. A comma separated string with required values. </summary>
        public WindowsUpdateClassification? IncludedUpdateClassifications { get; set; }
        /// <summary> KB numbers excluded from the software update configuration. </summary>
        public IList<string> ExcludedKBNumbers { get; }
        /// <summary> KB numbers included from the software update configuration. </summary>
        public IList<string> IncludedKBNumbers { get; }
        /// <summary> Reboot setting for the software update configuration. </summary>
        public string RebootSetting { get; set; }
    }
}