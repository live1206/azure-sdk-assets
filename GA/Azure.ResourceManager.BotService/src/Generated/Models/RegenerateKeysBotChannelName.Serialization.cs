// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.BotService.Models
{
    internal static partial class RegenerateKeysBotChannelNameExtensions
    {
        public static string ToSerialString(this RegenerateKeysBotChannelName value) => value switch
        {
            RegenerateKeysBotChannelName.WebChatChannel => "WebChatChannel",
            RegenerateKeysBotChannelName.DirectLineChannel => "DirectLineChannel",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RegenerateKeysBotChannelName value.")
        };

        public static RegenerateKeysBotChannelName ToRegenerateKeysBotChannelName(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "WebChatChannel")) return RegenerateKeysBotChannelName.WebChatChannel;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "DirectLineChannel")) return RegenerateKeysBotChannelName.DirectLineChannel;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RegenerateKeysBotChannelName value.");
        }
    }
}