// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Intelligence Pack containing a string name and boolean indicating if it's enabled. </summary>
    public partial class OperationalInsightsIntelligencePack
    {
        /// <summary> Initializes a new instance of OperationalInsightsIntelligencePack. </summary>
        internal OperationalInsightsIntelligencePack()
        {
        }

        /// <summary> Initializes a new instance of OperationalInsightsIntelligencePack. </summary>
        /// <param name="name"> The name of the intelligence pack. </param>
        /// <param name="isEnabled"> The enabled boolean for the intelligence pack. </param>
        /// <param name="displayName"> The display name of the intelligence pack. </param>
        internal OperationalInsightsIntelligencePack(string name, bool? isEnabled, string displayName)
        {
            Name = name;
            IsEnabled = isEnabled;
            DisplayName = displayName;
        }

        /// <summary> The name of the intelligence pack. </summary>
        public string Name { get; }
        /// <summary> The enabled boolean for the intelligence pack. </summary>
        public bool? IsEnabled { get; }
        /// <summary> The display name of the intelligence pack. </summary>
        public string DisplayName { get; }
    }
}
