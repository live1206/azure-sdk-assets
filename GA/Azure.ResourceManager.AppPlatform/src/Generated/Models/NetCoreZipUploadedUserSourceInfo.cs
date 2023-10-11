// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Uploaded Jar binary for a deployment. </summary>
    public partial class NetCoreZipUploadedUserSourceInfo : AppPlatformUploadedUserSourceInfo
    {
        /// <summary> Initializes a new instance of NetCoreZipUploadedUserSourceInfo. </summary>
        public NetCoreZipUploadedUserSourceInfo()
        {
            UserSourceInfoType = "NetCoreZip";
        }

        /// <summary> Initializes a new instance of NetCoreZipUploadedUserSourceInfo. </summary>
        /// <param name="userSourceInfoType"> Type of the source uploaded. </param>
        /// <param name="version"> Version of the source. </param>
        /// <param name="relativePath"> Relative path of the storage which stores the source. </param>
        /// <param name="netCoreMainEntryPath"> The path to the .NET executable relative to zip root. </param>
        /// <param name="runtimeVersion"> Runtime version of the .Net file. </param>
        internal NetCoreZipUploadedUserSourceInfo(string userSourceInfoType, string version, string relativePath, string netCoreMainEntryPath, string runtimeVersion) : base(userSourceInfoType, version, relativePath)
        {
            NetCoreMainEntryPath = netCoreMainEntryPath;
            RuntimeVersion = runtimeVersion;
            UserSourceInfoType = userSourceInfoType ?? "NetCoreZip";
        }

        /// <summary> The path to the .NET executable relative to zip root. </summary>
        public string NetCoreMainEntryPath { get; set; }
        /// <summary> Runtime version of the .Net file. </summary>
        public string RuntimeVersion { get; set; }
    }
}