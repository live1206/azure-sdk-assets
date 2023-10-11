// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> GitHub Actions Web App stack settings. </summary>
    public partial class GitHubActionWebAppStackSettings
    {
        /// <summary> Initializes a new instance of GitHubActionWebAppStackSettings. </summary>
        internal GitHubActionWebAppStackSettings()
        {
        }

        /// <summary> Initializes a new instance of GitHubActionWebAppStackSettings. </summary>
        /// <param name="isSupported"> &lt;code&gt;true&lt;/code&gt; if GitHub Actions is supported for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="supportedVersion"> The minor version that is supported for GitHub Actions. </param>
        internal GitHubActionWebAppStackSettings(bool? isSupported, string supportedVersion)
        {
            IsSupported = isSupported;
            SupportedVersion = supportedVersion;
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; if GitHub Actions is supported for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsSupported { get; }
        /// <summary> The minor version that is supported for GitHub Actions. </summary>
        public string SupportedVersion { get; }
    }
}