// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a webhook. </summary>
    public partial class ContainerRegistryWebhookPatch
    {
        /// <summary> Initializes a new instance of ContainerRegistryWebhookPatch. </summary>
        public ContainerRegistryWebhookPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            CustomHeaders = new ChangeTrackingDictionary<string, string>();
            Actions = new ChangeTrackingList<ContainerRegistryWebhookAction>();
        }

        /// <summary> The tags for the webhook. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The service URI for the webhook to post notifications. </summary>
        public Uri ServiceUri { get; set; }
        /// <summary> Custom headers that will be added to the webhook notifications. </summary>
        public IDictionary<string, string> CustomHeaders { get; }
        /// <summary> The status of the webhook at the time the operation was called. </summary>
        public ContainerRegistryWebhookStatus? Status { get; set; }
        /// <summary> The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means all events. </summary>
        public string Scope { get; set; }
        /// <summary> The list of actions that trigger the webhook to post notifications. </summary>
        public IList<ContainerRegistryWebhookAction> Actions { get; }
    }
}