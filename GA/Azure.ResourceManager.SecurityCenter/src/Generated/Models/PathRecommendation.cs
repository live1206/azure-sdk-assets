// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Represents a path that is recommended to be allowed and its properties. </summary>
    public partial class PathRecommendation
    {
        /// <summary> Initializes a new instance of PathRecommendation. </summary>
        public PathRecommendation()
        {
            UserSids = new ChangeTrackingList<string>();
            Usernames = new ChangeTrackingList<UserRecommendation>();
        }

        /// <summary> Initializes a new instance of PathRecommendation. </summary>
        /// <param name="path"> The full path of the file, or an identifier of the application. </param>
        /// <param name="action"> The recommendation action of the machine or rule. </param>
        /// <param name="iotSecurityRecommendationType"> The type of IoT Security recommendation. </param>
        /// <param name="publisherInfo"> Represents the publisher information of a process/rule. </param>
        /// <param name="isCommon"> Whether the application is commonly run on the machine. </param>
        /// <param name="userSids"></param>
        /// <param name="usernames"></param>
        /// <param name="fileType"> The type of the file (for Linux files - Executable is used). </param>
        /// <param name="configurationStatus"> The configuration status of the machines group or machine or rule. </param>
        internal PathRecommendation(string path, RecommendationAction? action, IotSecurityRecommendationType? iotSecurityRecommendationType, SecurityCenterPublisherInfo publisherInfo, bool? isCommon, IList<string> userSids, IList<UserRecommendation> usernames, PathRecommendationFileType? fileType, SecurityCenterConfigurationStatus? configurationStatus)
        {
            Path = path;
            Action = action;
            IotSecurityRecommendationType = iotSecurityRecommendationType;
            PublisherInfo = publisherInfo;
            IsCommon = isCommon;
            UserSids = userSids;
            Usernames = usernames;
            FileType = fileType;
            ConfigurationStatus = configurationStatus;
        }

        /// <summary> The full path of the file, or an identifier of the application. </summary>
        public string Path { get; set; }
        /// <summary> The recommendation action of the machine or rule. </summary>
        public RecommendationAction? Action { get; set; }
        /// <summary> The type of IoT Security recommendation. </summary>
        public IotSecurityRecommendationType? IotSecurityRecommendationType { get; set; }
        /// <summary> Represents the publisher information of a process/rule. </summary>
        public SecurityCenterPublisherInfo PublisherInfo { get; set; }
        /// <summary> Whether the application is commonly run on the machine. </summary>
        public bool? IsCommon { get; set; }
        /// <summary> Gets the user sids. </summary>
        public IList<string> UserSids { get; }
        /// <summary> Gets the usernames. </summary>
        public IList<UserRecommendation> Usernames { get; }
        /// <summary> The type of the file (for Linux files - Executable is used). </summary>
        public PathRecommendationFileType? FileType { get; set; }
        /// <summary> The configuration status of the machines group or machine or rule. </summary>
        public SecurityCenterConfigurationStatus? ConfigurationStatus { get; set; }
    }
}
