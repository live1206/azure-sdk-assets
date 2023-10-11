// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The Azure mobile App push notification receiver. </summary>
    public partial class MonitorAzureAppPushReceiver
    {
        /// <summary> Initializes a new instance of MonitorAzureAppPushReceiver. </summary>
        /// <param name="name"> The name of the Azure mobile app push receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="emailAddress"> The email address registered for the Azure mobile app. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="emailAddress"/> is null. </exception>
        public MonitorAzureAppPushReceiver(string name, string emailAddress)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(emailAddress, nameof(emailAddress));

            Name = name;
            EmailAddress = emailAddress;
        }

        /// <summary> The name of the Azure mobile app push receiver. Names must be unique across all receivers within an action group. </summary>
        public string Name { get; set; }
        /// <summary> The email address registered for the Azure mobile app. </summary>
        public string EmailAddress { get; set; }
    }
}