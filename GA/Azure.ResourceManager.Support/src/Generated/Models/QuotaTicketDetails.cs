// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Additional set of information required for quota increase support ticket for certain quota types, e.g.: Virtual machine cores. Get complete details about Quota payload support request along with examples at [Support quota request](https://aka.ms/supportrpquotarequestpayload). </summary>
    public partial class QuotaTicketDetails
    {
        /// <summary> Initializes a new instance of QuotaTicketDetails. </summary>
        public QuotaTicketDetails()
        {
            QuotaChangeRequests = new ChangeTrackingList<SupportQuotaChangeContent>();
        }

        /// <summary> Initializes a new instance of QuotaTicketDetails. </summary>
        /// <param name="quotaChangeRequestSubType"> Required for certain quota types when there is a sub type, such as Batch, for which you are requesting a quota increase. </param>
        /// <param name="quotaChangeRequestVersion"> Quota change request version. </param>
        /// <param name="quotaChangeRequests"> This property is required for providing the region and new quota limits. </param>
        internal QuotaTicketDetails(string quotaChangeRequestSubType, string quotaChangeRequestVersion, IList<SupportQuotaChangeContent> quotaChangeRequests)
        {
            QuotaChangeRequestSubType = quotaChangeRequestSubType;
            QuotaChangeRequestVersion = quotaChangeRequestVersion;
            QuotaChangeRequests = quotaChangeRequests;
        }

        /// <summary> Required for certain quota types when there is a sub type, such as Batch, for which you are requesting a quota increase. </summary>
        public string QuotaChangeRequestSubType { get; set; }
        /// <summary> Quota change request version. </summary>
        public string QuotaChangeRequestVersion { get; set; }
        /// <summary> This property is required for providing the region and new quota limits. </summary>
        public IList<SupportQuotaChangeContent> QuotaChangeRequests { get; }
    }
}