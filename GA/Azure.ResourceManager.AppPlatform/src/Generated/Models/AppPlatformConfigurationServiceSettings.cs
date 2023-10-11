// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The settings of Application Configuration Service. </summary>
    public partial class AppPlatformConfigurationServiceSettings
    {
        /// <summary> Initializes a new instance of AppPlatformConfigurationServiceSettings. </summary>
        public AppPlatformConfigurationServiceSettings()
        {
        }

        /// <summary> Initializes a new instance of AppPlatformConfigurationServiceSettings. </summary>
        /// <param name="gitProperty"> Property of git environment. </param>
        internal AppPlatformConfigurationServiceSettings(ConfigurationServiceGitProperty gitProperty)
        {
            GitProperty = gitProperty;
        }

        /// <summary> Property of git environment. </summary>
        internal ConfigurationServiceGitProperty GitProperty { get; set; }
        /// <summary> Repositories of Application Configuration Service git property. </summary>
        public IList<AppPlatformConfigurationServiceGitRepository> ConfigurationServiceGitRepositories
        {
            get
            {
                if (GitProperty is null)
                    GitProperty = new ConfigurationServiceGitProperty();
                return GitProperty.ConfigurationServiceGitRepositories;
            }
        }
    }
}
