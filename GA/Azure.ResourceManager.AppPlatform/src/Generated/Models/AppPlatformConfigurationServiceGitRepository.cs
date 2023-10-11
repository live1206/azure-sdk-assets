// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Git repository property payload for Application Configuration Service. </summary>
    public partial class AppPlatformConfigurationServiceGitRepository
    {
        /// <summary> Initializes a new instance of AppPlatformConfigurationServiceGitRepository. </summary>
        /// <param name="name"> Name of the repository. </param>
        /// <param name="patterns"> Collection of patterns of the repository. </param>
        /// <param name="uri"> URI of the repository. </param>
        /// <param name="label"> Label of the repository. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="patterns"/>, <paramref name="uri"/> or <paramref name="label"/> is null. </exception>
        public AppPlatformConfigurationServiceGitRepository(string name, IEnumerable<string> patterns, Uri uri, string label)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(patterns, nameof(patterns));
            Argument.AssertNotNull(uri, nameof(uri));
            Argument.AssertNotNull(label, nameof(label));

            Name = name;
            Patterns = patterns.ToList();
            Uri = uri;
            Label = label;
            SearchPaths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppPlatformConfigurationServiceGitRepository. </summary>
        /// <param name="name"> Name of the repository. </param>
        /// <param name="patterns"> Collection of patterns of the repository. </param>
        /// <param name="uri"> URI of the repository. </param>
        /// <param name="label"> Label of the repository. </param>
        /// <param name="searchPaths"> Searching path of the repository. </param>
        /// <param name="username"> Username of git repository basic auth. </param>
        /// <param name="password"> Password of git repository basic auth. </param>
        /// <param name="hostKey"> Public sshKey of git repository. </param>
        /// <param name="hostKeyAlgorithm"> SshKey algorithm of git repository. </param>
        /// <param name="privateKey"> Private sshKey algorithm of git repository. </param>
        /// <param name="isHostKeyCheckingStrict"> Strict host key checking or not. </param>
        internal AppPlatformConfigurationServiceGitRepository(string name, IList<string> patterns, Uri uri, string label, IList<string> searchPaths, string username, string password, string hostKey, string hostKeyAlgorithm, string privateKey, bool? isHostKeyCheckingStrict)
        {
            Name = name;
            Patterns = patterns;
            Uri = uri;
            Label = label;
            SearchPaths = searchPaths;
            Username = username;
            Password = password;
            HostKey = hostKey;
            HostKeyAlgorithm = hostKeyAlgorithm;
            PrivateKey = privateKey;
            IsHostKeyCheckingStrict = isHostKeyCheckingStrict;
        }

        /// <summary> Name of the repository. </summary>
        public string Name { get; set; }
        /// <summary> Collection of patterns of the repository. </summary>
        public IList<string> Patterns { get; }
        /// <summary> URI of the repository. </summary>
        public Uri Uri { get; set; }
        /// <summary> Label of the repository. </summary>
        public string Label { get; set; }
        /// <summary> Searching path of the repository. </summary>
        public IList<string> SearchPaths { get; }
        /// <summary> Username of git repository basic auth. </summary>
        public string Username { get; set; }
        /// <summary> Password of git repository basic auth. </summary>
        public string Password { get; set; }
        /// <summary> Public sshKey of git repository. </summary>
        public string HostKey { get; set; }
        /// <summary> SshKey algorithm of git repository. </summary>
        public string HostKeyAlgorithm { get; set; }
        /// <summary> Private sshKey algorithm of git repository. </summary>
        public string PrivateKey { get; set; }
        /// <summary> Strict host key checking or not. </summary>
        public bool? IsHostKeyCheckingStrict { get; set; }
    }
}
