// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Service Provider Definition. </summary>
    public partial class BotServiceProvider
    {
        /// <summary> Initializes a new instance of BotServiceProvider. </summary>
        internal BotServiceProvider()
        {
        }

        /// <summary> Initializes a new instance of BotServiceProvider. </summary>
        /// <param name="properties"> The Properties of a Service Provider Object. </param>
        internal BotServiceProvider(BotServiceProviderProperties properties)
        {
            Properties = properties;
        }

        /// <summary> The Properties of a Service Provider Object. </summary>
        public BotServiceProviderProperties Properties { get; }
    }
}