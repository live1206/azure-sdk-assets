// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Direct Line channel. </summary>
    public partial class TelephonyChannelProperties
    {
        /// <summary> Initializes a new instance of TelephonyChannelProperties. </summary>
        public TelephonyChannelProperties()
        {
            PhoneNumbers = new ChangeTrackingList<TelephonyPhoneNumbers>();
            ApiConfigurations = new ChangeTrackingList<TelephonyChannelResourceApiConfiguration>();
        }

        /// <summary> Initializes a new instance of TelephonyChannelProperties. </summary>
        /// <param name="phoneNumbers"> The list of Telephony phone numbers. </param>
        /// <param name="apiConfigurations"> The list of Telephony api configuration. </param>
        /// <param name="cognitiveServiceSubscriptionKey"> The extensionKey1. </param>
        /// <param name="cognitiveServiceRegion"> The extensionKey2. </param>
        /// <param name="defaultLocale"> The default locale of the channel. </param>
        /// <param name="premiumSku"> The premium SKU applied to the channel. </param>
        /// <param name="isEnabled"> Whether the channel is enabled. </param>
        internal TelephonyChannelProperties(IList<TelephonyPhoneNumbers> phoneNumbers, IList<TelephonyChannelResourceApiConfiguration> apiConfigurations, string cognitiveServiceSubscriptionKey, string cognitiveServiceRegion, string defaultLocale, string premiumSku, bool? isEnabled)
        {
            PhoneNumbers = phoneNumbers;
            ApiConfigurations = apiConfigurations;
            CognitiveServiceSubscriptionKey = cognitiveServiceSubscriptionKey;
            CognitiveServiceRegion = cognitiveServiceRegion;
            DefaultLocale = defaultLocale;
            PremiumSku = premiumSku;
            IsEnabled = isEnabled;
        }

        /// <summary> The list of Telephony phone numbers. </summary>
        public IList<TelephonyPhoneNumbers> PhoneNumbers { get; }
        /// <summary> The list of Telephony api configuration. </summary>
        public IList<TelephonyChannelResourceApiConfiguration> ApiConfigurations { get; }
        /// <summary> The extensionKey1. </summary>
        public string CognitiveServiceSubscriptionKey { get; set; }
        /// <summary> The extensionKey2. </summary>
        public string CognitiveServiceRegion { get; set; }
        /// <summary> The default locale of the channel. </summary>
        public string DefaultLocale { get; set; }
        /// <summary> The premium SKU applied to the channel. </summary>
        public string PremiumSku { get; set; }
        /// <summary> Whether the channel is enabled. </summary>
        public bool? IsEnabled { get; set; }
    }
}