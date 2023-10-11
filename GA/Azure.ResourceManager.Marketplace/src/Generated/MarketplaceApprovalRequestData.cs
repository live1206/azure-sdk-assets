// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing the MarketplaceApprovalRequest data model.
    /// Request approval resource.
    /// </summary>
    public partial class MarketplaceApprovalRequestData : ResourceData
    {
        /// <summary> Initializes a new instance of MarketplaceApprovalRequestData. </summary>
        public MarketplaceApprovalRequestData()
        {
            PlansDetails = new ChangeTrackingList<PrivateStorePlanDetails>();
        }

        /// <summary> Initializes a new instance of MarketplaceApprovalRequestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="offerId"> Gets or sets unique offer id. </param>
        /// <param name="offerDisplayName"> Gets offer display name. </param>
        /// <param name="publisherId"> The offer's publisher id. </param>
        /// <param name="plansDetails"> Gets or sets the plans details. </param>
        /// <param name="isClosed"> Gets a value indicating whether the request is closed. </param>
        /// <param name="messageCode"> Gets or sets the request approval message code. </param>
        internal MarketplaceApprovalRequestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string offerId, string offerDisplayName, string publisherId, IList<PrivateStorePlanDetails> plansDetails, bool? isClosed, long? messageCode) : base(id, name, resourceType, systemData)
        {
            OfferId = offerId;
            OfferDisplayName = offerDisplayName;
            PublisherId = publisherId;
            PlansDetails = plansDetails;
            IsClosed = isClosed;
            MessageCode = messageCode;
        }

        /// <summary> Gets or sets unique offer id. </summary>
        public string OfferId { get; set; }
        /// <summary> Gets offer display name. </summary>
        public string OfferDisplayName { get; }
        /// <summary> The offer's publisher id. </summary>
        public string PublisherId { get; set; }
        /// <summary> Gets or sets the plans details. </summary>
        public IList<PrivateStorePlanDetails> PlansDetails { get; }
        /// <summary> Gets a value indicating whether the request is closed. </summary>
        public bool? IsClosed { get; }
        /// <summary> Gets or sets the request approval message code. </summary>
        public long? MessageCode { get; set; }
    }
}