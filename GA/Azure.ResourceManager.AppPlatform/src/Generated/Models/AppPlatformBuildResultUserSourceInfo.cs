// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Reference to a build result. </summary>
    public partial class AppPlatformBuildResultUserSourceInfo : AppPlatformUserSourceInfo
    {
        /// <summary> Initializes a new instance of AppPlatformBuildResultUserSourceInfo. </summary>
        public AppPlatformBuildResultUserSourceInfo()
        {
            UserSourceInfoType = "BuildResult";
        }

        /// <summary> Initializes a new instance of AppPlatformBuildResultUserSourceInfo. </summary>
        /// <param name="userSourceInfoType"> Type of the source uploaded. </param>
        /// <param name="version"> Version of the source. </param>
        /// <param name="buildResultId"> Resource id of an existing succeeded build result under the same Spring instance. </param>
        internal AppPlatformBuildResultUserSourceInfo(string userSourceInfoType, string version, string buildResultId) : base(userSourceInfoType, version)
        {
            BuildResultId = buildResultId;
            UserSourceInfoType = userSourceInfoType ?? "BuildResult";
        }

        /// <summary> Resource id of an existing succeeded build result under the same Spring instance. </summary>
        public string BuildResultId { get; set; }
    }
}
