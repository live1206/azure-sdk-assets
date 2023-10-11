// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> The DatadogHost. </summary>
    public partial class DatadogHost
    {
        /// <summary> Initializes a new instance of DatadogHost. </summary>
        internal DatadogHost()
        {
            Aliases = new ChangeTrackingList<string>();
            Apps = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DatadogHost. </summary>
        /// <param name="name"> The name of the host. </param>
        /// <param name="aliases"> The aliases for the host. </param>
        /// <param name="apps"> The Datadog integrations reporting metrics for the host. </param>
        /// <param name="meta"></param>
        internal DatadogHost(string name, IReadOnlyList<string> aliases, IReadOnlyList<string> apps, DatadogHostMetadata meta)
        {
            Name = name;
            Aliases = aliases;
            Apps = apps;
            Meta = meta;
        }

        /// <summary> The name of the host. </summary>
        public string Name { get; }
        /// <summary> The aliases for the host. </summary>
        public IReadOnlyList<string> Aliases { get; }
        /// <summary> The Datadog integrations reporting metrics for the host. </summary>
        public IReadOnlyList<string> Apps { get; }
        /// <summary> Gets the meta. </summary>
        public DatadogHostMetadata Meta { get; }
    }
}