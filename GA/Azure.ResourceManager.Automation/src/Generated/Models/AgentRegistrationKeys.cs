// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the agent registration keys. </summary>
    public partial class AgentRegistrationKeys
    {
        /// <summary> Initializes a new instance of AgentRegistrationKeys. </summary>
        internal AgentRegistrationKeys()
        {
        }

        /// <summary> Initializes a new instance of AgentRegistrationKeys. </summary>
        /// <param name="primary"> Gets or sets the primary key. </param>
        /// <param name="secondary"> Gets or sets the secondary key. </param>
        internal AgentRegistrationKeys(string primary, string secondary)
        {
            Primary = primary;
            Secondary = secondary;
        }

        /// <summary> Gets or sets the primary key. </summary>
        public string Primary { get; }
        /// <summary> Gets or sets the secondary key. </summary>
        public string Secondary { get; }
    }
}