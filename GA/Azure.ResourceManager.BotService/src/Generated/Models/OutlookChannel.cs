// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Outlook channel definition. </summary>
    public partial class OutlookChannel : BotChannelProperties
    {
        /// <summary> Initializes a new instance of OutlookChannel. </summary>
        public OutlookChannel()
        {
            ChannelName = "OutlookChannel";
        }

        /// <summary> Initializes a new instance of OutlookChannel. </summary>
        /// <param name="channelName"> The channel name. </param>
        /// <param name="etag"> Entity Tag of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        internal OutlookChannel(string channelName, ETag? etag, string provisioningState, AzureLocation? location) : base(channelName, etag, provisioningState, location)
        {
            ChannelName = channelName ?? "OutlookChannel";
        }
    }
}