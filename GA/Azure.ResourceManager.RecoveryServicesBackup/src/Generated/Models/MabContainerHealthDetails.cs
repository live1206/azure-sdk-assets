// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> MAB workload-specific Health Details. </summary>
    public partial class MabContainerHealthDetails
    {
        /// <summary> Initializes a new instance of MabContainerHealthDetails. </summary>
        public MabContainerHealthDetails()
        {
            Recommendations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of MabContainerHealthDetails. </summary>
        /// <param name="code"> Health Code. </param>
        /// <param name="title"> Health Title. </param>
        /// <param name="message"> Health Message. </param>
        /// <param name="recommendations"> Health Recommended Actions. </param>
        internal MabContainerHealthDetails(int? code, string title, string message, IList<string> recommendations)
        {
            Code = code;
            Title = title;
            Message = message;
            Recommendations = recommendations;
        }

        /// <summary> Health Code. </summary>
        public int? Code { get; set; }
        /// <summary> Health Title. </summary>
        public string Title { get; set; }
        /// <summary> Health Message. </summary>
        public string Message { get; set; }
        /// <summary> Health Recommended Actions. </summary>
        public IList<string> Recommendations { get; }
    }
}