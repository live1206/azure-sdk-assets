// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Extra Parameters specific to each Service Provider. </summary>
    public partial class BotServiceProviderParameter
    {
        /// <summary> Initializes a new instance of BotServiceProviderParameter. </summary>
        internal BotServiceProviderParameter()
        {
        }

        /// <summary> Initializes a new instance of BotServiceProviderParameter. </summary>
        /// <param name="name"> Name of the Service Provider. </param>
        /// <param name="serviceProviderParameterType"> Type of the Service Provider. </param>
        /// <param name="displayName"> Display Name of the Service Provider. </param>
        /// <param name="description"> Description of the Service Provider. </param>
        /// <param name="helpUri"> Help Url for the  Service Provider. </param>
        /// <param name="default"> Default Name for the Service Provider. </param>
        /// <param name="metadata"> Meta data for the Service Provider. </param>
        internal BotServiceProviderParameter(string name, string serviceProviderParameterType, string displayName, string description, Uri helpUri, string @default, ServiceProviderParameterMetadata metadata)
        {
            Name = name;
            ServiceProviderParameterType = serviceProviderParameterType;
            DisplayName = displayName;
            Description = description;
            HelpUri = helpUri;
            Default = @default;
            Metadata = metadata;
        }

        /// <summary> Name of the Service Provider. </summary>
        public string Name { get; }
        /// <summary> Type of the Service Provider. </summary>
        public string ServiceProviderParameterType { get; }
        /// <summary> Display Name of the Service Provider. </summary>
        public string DisplayName { get; }
        /// <summary> Description of the Service Provider. </summary>
        public string Description { get; }
        /// <summary> Help Url for the  Service Provider. </summary>
        public Uri HelpUri { get; }
        /// <summary> Default Name for the Service Provider. </summary>
        public string Default { get; }
        /// <summary> Meta data for the Service Provider. </summary>
        internal ServiceProviderParameterMetadata Metadata { get; }
        /// <summary> Whether required the constraints of the bot meta data. </summary>
        public bool? IsRequired
        {
            get => Metadata?.IsRequired;
        }
    }
}