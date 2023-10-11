// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Property of git environment. </summary>
    internal partial class ConfigurationServiceGitProperty
    {
        /// <summary> Initializes a new instance of ConfigurationServiceGitProperty. </summary>
        public ConfigurationServiceGitProperty()
        {
            ConfigurationServiceGitRepositories = new ChangeTrackingList<AppPlatformConfigurationServiceGitRepository>();
        }

        /// <summary> Initializes a new instance of ConfigurationServiceGitProperty. </summary>
        /// <param name="configurationServiceGitRepositories"> Repositories of Application Configuration Service git property. </param>
        internal ConfigurationServiceGitProperty(IList<AppPlatformConfigurationServiceGitRepository> configurationServiceGitRepositories)
        {
            ConfigurationServiceGitRepositories = configurationServiceGitRepositories;
        }

        /// <summary> Repositories of Application Configuration Service git property. </summary>
        public IList<AppPlatformConfigurationServiceGitRepository> ConfigurationServiceGitRepositories { get; }
    }
}