// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Alexa channel. </summary>
    public partial class AlexaChannelProperties
    {
        /// <summary> Initializes a new instance of AlexaChannelProperties. </summary>
        /// <param name="alexaSkillId"> The Alexa skill Id. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alexaSkillId"/> is null. </exception>
        public AlexaChannelProperties(string alexaSkillId, bool isEnabled)
        {
            Argument.AssertNotNull(alexaSkillId, nameof(alexaSkillId));

            AlexaSkillId = alexaSkillId;
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of AlexaChannelProperties. </summary>
        /// <param name="alexaSkillId"> The Alexa skill Id. </param>
        /// <param name="uriFragment"> Url fragment used in part of the Uri configured in Alexa. </param>
        /// <param name="serviceEndpointUri"> Full Uri used to configured the skill in Alexa. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        internal AlexaChannelProperties(string alexaSkillId, string uriFragment, Uri serviceEndpointUri, bool isEnabled)
        {
            AlexaSkillId = alexaSkillId;
            UriFragment = uriFragment;
            ServiceEndpointUri = serviceEndpointUri;
            IsEnabled = isEnabled;
        }

        /// <summary> The Alexa skill Id. </summary>
        public string AlexaSkillId { get; set; }
        /// <summary> Url fragment used in part of the Uri configured in Alexa. </summary>
        public string UriFragment { get; }
        /// <summary> Full Uri used to configured the skill in Alexa. </summary>
        public Uri ServiceEndpointUri { get; }
        /// <summary> Whether this channel is enabled for the bot. </summary>
        public bool IsEnabled { get; set; }
    }
}