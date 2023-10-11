// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HealthBot;

namespace Azure.ResourceManager.HealthBot.Models
{
    /// <summary> The list of Azure Health Bot operation response. </summary>
    internal partial class BotResponseList
    {
        /// <summary> Initializes a new instance of BotResponseList. </summary>
        internal BotResponseList()
        {
            Value = new ChangeTrackingList<HealthBotData>();
        }

        /// <summary> Initializes a new instance of BotResponseList. </summary>
        /// <param name="nextLink"> The link used to get the next page of bot service resources. </param>
        /// <param name="value"> Gets the list of Azure Health Bot results and their properties. </param>
        internal BotResponseList(string nextLink, IReadOnlyList<HealthBotData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of bot service resources. </summary>
        public string NextLink { get; }
        /// <summary> Gets the list of Azure Health Bot results and their properties. </summary>
        public IReadOnlyList<HealthBotData> Value { get; }
    }
}