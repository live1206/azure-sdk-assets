// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Web Chat channel. </summary>
    public partial class WebChatChannelProperties
    {
        /// <summary> Initializes a new instance of WebChatChannelProperties. </summary>
        public WebChatChannelProperties()
        {
            Sites = new ChangeTrackingList<WebChatSite>();
        }

        /// <summary> Initializes a new instance of WebChatChannelProperties. </summary>
        /// <param name="webChatEmbedCode"> Web chat control embed code. </param>
        /// <param name="sites"> The list of Web Chat sites. </param>
        internal WebChatChannelProperties(string webChatEmbedCode, IList<WebChatSite> sites)
        {
            WebChatEmbedCode = webChatEmbedCode;
            Sites = sites;
        }

        /// <summary> Web chat control embed code. </summary>
        public string WebChatEmbedCode { get; }
        /// <summary> The list of Web Chat sites. </summary>
        public IList<WebChatSite> Sites { get; }
    }
}