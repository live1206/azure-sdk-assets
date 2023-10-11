// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> To scrub sensitive log fields. </summary>
    public partial class PolicySettingsLogScrubbing
    {
        /// <summary> Initializes a new instance of PolicySettingsLogScrubbing. </summary>
        public PolicySettingsLogScrubbing()
        {
            ScrubbingRules = new ChangeTrackingList<WebApplicationFirewallScrubbingRules>();
        }

        /// <summary> Initializes a new instance of PolicySettingsLogScrubbing. </summary>
        /// <param name="state"> State of the log scrubbing config. Default value is Enabled. </param>
        /// <param name="scrubbingRules"> The rules that are applied to the logs for scrubbing. </param>
        internal PolicySettingsLogScrubbing(WebApplicationFirewallScrubbingState? state, IList<WebApplicationFirewallScrubbingRules> scrubbingRules)
        {
            State = state;
            ScrubbingRules = scrubbingRules;
        }

        /// <summary> State of the log scrubbing config. Default value is Enabled. </summary>
        public WebApplicationFirewallScrubbingState? State { get; set; }
        /// <summary> The rules that are applied to the logs for scrubbing. </summary>
        public IList<WebApplicationFirewallScrubbingRules> ScrubbingRules { get; }
    }
}