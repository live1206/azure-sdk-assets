// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> Confluent Offer detail. </summary>
    public partial class ConfluentOfferDetail
    {
        /// <summary> Initializes a new instance of ConfluentOfferDetail. </summary>
        /// <param name="publisherId"> Publisher Id. </param>
        /// <param name="id"> Offer Id. </param>
        /// <param name="planId"> Offer Plan Id. </param>
        /// <param name="planName"> Offer Plan Name. </param>
        /// <param name="termUnit"> Offer Plan Term unit. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="id"/>, <paramref name="planId"/>, <paramref name="planName"/> or <paramref name="termUnit"/> is null. </exception>
        public ConfluentOfferDetail(string publisherId, string id, string planId, string planName, string termUnit)
        {
            Argument.AssertNotNull(publisherId, nameof(publisherId));
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(planId, nameof(planId));
            Argument.AssertNotNull(planName, nameof(planName));
            Argument.AssertNotNull(termUnit, nameof(termUnit));

            PublisherId = publisherId;
            Id = id;
            PlanId = planId;
            PlanName = planName;
            TermUnit = termUnit;
        }

        /// <summary> Initializes a new instance of ConfluentOfferDetail. </summary>
        /// <param name="publisherId"> Publisher Id. </param>
        /// <param name="id"> Offer Id. </param>
        /// <param name="planId"> Offer Plan Id. </param>
        /// <param name="planName"> Offer Plan Name. </param>
        /// <param name="termUnit"> Offer Plan Term unit. </param>
        /// <param name="status"> SaaS Offer Status. </param>
        internal ConfluentOfferDetail(string publisherId, string id, string planId, string planName, string termUnit, ConfluentSaaSOfferStatus? status)
        {
            PublisherId = publisherId;
            Id = id;
            PlanId = planId;
            PlanName = planName;
            TermUnit = termUnit;
            Status = status;
        }

        /// <summary> Publisher Id. </summary>
        public string PublisherId { get; set; }
        /// <summary> Offer Id. </summary>
        public string Id { get; set; }
        /// <summary> Offer Plan Id. </summary>
        public string PlanId { get; set; }
        /// <summary> Offer Plan Name. </summary>
        public string PlanName { get; set; }
        /// <summary> Offer Plan Term unit. </summary>
        public string TermUnit { get; set; }
        /// <summary> SaaS Offer Status. </summary>
        public ConfluentSaaSOfferStatus? Status { get; }
    }
}
