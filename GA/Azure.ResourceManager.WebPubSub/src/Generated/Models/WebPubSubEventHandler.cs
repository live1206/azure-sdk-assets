// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Properties of event handler. </summary>
    public partial class WebPubSubEventHandler
    {
        /// <summary> Initializes a new instance of WebPubSubEventHandler. </summary>
        /// <param name="urlTemplate">
        /// Gets or sets the EventHandler URL template. You can use a predefined parameter {hub} and {event} inside the template, the value of the EventHandler URL is dynamically calculated when the client request comes in.
        /// For example, UrlTemplate can be `http://example.com/api/{hub}/{event}`. The host part can't contains parameters.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="urlTemplate"/> is null. </exception>
        public WebPubSubEventHandler(string urlTemplate)
        {
            Argument.AssertNotNull(urlTemplate, nameof(urlTemplate));

            UrlTemplate = urlTemplate;
            SystemEvents = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of WebPubSubEventHandler. </summary>
        /// <param name="urlTemplate">
        /// Gets or sets the EventHandler URL template. You can use a predefined parameter {hub} and {event} inside the template, the value of the EventHandler URL is dynamically calculated when the client request comes in.
        /// For example, UrlTemplate can be `http://example.com/api/{hub}/{event}`. The host part can't contains parameters.
        /// </param>
        /// <param name="userEventPattern">
        /// Gets or sets the matching pattern for event names.
        /// There are 3 kind of patterns supported:
        ///     1. "*", it to matches any event name
        ///     2. Combine multiple events with ",", for example "event1,event2", it matches event "event1" and "event2"
        ///     3. The single event name, for example, "event1", it matches "event1"
        /// </param>
        /// <param name="systemEvents"> Gets ot sets the list of system events. </param>
        /// <param name="auth"> Upstream auth settings. If not set, no auth is used for upstream messages. </param>
        internal WebPubSubEventHandler(string urlTemplate, string userEventPattern, IList<string> systemEvents, UpstreamAuthSettings auth)
        {
            UrlTemplate = urlTemplate;
            UserEventPattern = userEventPattern;
            SystemEvents = systemEvents;
            Auth = auth;
        }

        /// <summary>
        /// Gets or sets the EventHandler URL template. You can use a predefined parameter {hub} and {event} inside the template, the value of the EventHandler URL is dynamically calculated when the client request comes in.
        /// For example, UrlTemplate can be `http://example.com/api/{hub}/{event}`. The host part can't contains parameters.
        /// </summary>
        public string UrlTemplate { get; set; }
        /// <summary>
        /// Gets or sets the matching pattern for event names.
        /// There are 3 kind of patterns supported:
        ///     1. "*", it to matches any event name
        ///     2. Combine multiple events with ",", for example "event1,event2", it matches event "event1" and "event2"
        ///     3. The single event name, for example, "event1", it matches "event1"
        /// </summary>
        public string UserEventPattern { get; set; }
        /// <summary> Gets ot sets the list of system events. </summary>
        public IList<string> SystemEvents { get; }
        /// <summary> Upstream auth settings. If not set, no auth is used for upstream messages. </summary>
        public UpstreamAuthSettings Auth { get; set; }
    }
}