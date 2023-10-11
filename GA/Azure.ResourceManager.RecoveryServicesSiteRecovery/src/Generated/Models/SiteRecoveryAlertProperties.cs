// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The properties of an alert. </summary>
    public partial class SiteRecoveryAlertProperties
    {
        /// <summary> Initializes a new instance of SiteRecoveryAlertProperties. </summary>
        internal SiteRecoveryAlertProperties()
        {
            CustomEmailAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SiteRecoveryAlertProperties. </summary>
        /// <param name="sendToOwners"> A value indicating whether to send email to subscription administrator. </param>
        /// <param name="customEmailAddresses"> The custom email address for sending emails. </param>
        /// <param name="locale"> The locale for the email notification. </param>
        internal SiteRecoveryAlertProperties(string sendToOwners, IReadOnlyList<string> customEmailAddresses, string locale)
        {
            SendToOwners = sendToOwners;
            CustomEmailAddresses = customEmailAddresses;
            Locale = locale;
        }

        /// <summary> A value indicating whether to send email to subscription administrator. </summary>
        public string SendToOwners { get; }
        /// <summary> The custom email address for sending emails. </summary>
        public IReadOnlyList<string> CustomEmailAddresses { get; }
        /// <summary> The locale for the email notification. </summary>
        public string Locale { get; }
    }
}