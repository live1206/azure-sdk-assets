// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Response of payload to be passed while installing VM agent. </summary>
    public partial class NewRelicObservabilityVmExtensionPayload
    {
        /// <summary> Initializes a new instance of NewRelicObservabilityVmExtensionPayload. </summary>
        internal NewRelicObservabilityVmExtensionPayload()
        {
        }

        /// <summary> Initializes a new instance of NewRelicObservabilityVmExtensionPayload. </summary>
        /// <param name="ingestionKey"> Ingestion key of the account. </param>
        internal NewRelicObservabilityVmExtensionPayload(string ingestionKey)
        {
            IngestionKey = ingestionKey;
        }

        /// <summary> Ingestion key of the account. </summary>
        public string IngestionKey { get; }
    }
}