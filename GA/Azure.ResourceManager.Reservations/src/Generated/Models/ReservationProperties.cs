// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The properties of the reservations. </summary>
    public partial class ReservationProperties
    {
        /// <summary> Initializes a new instance of ReservationProperties. </summary>
        internal ReservationProperties()
        {
            AppliedScopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ReservationProperties. </summary>
        /// <param name="reservedResourceType"> The type of the resource that is being reserved. </param>
        /// <param name="instanceFlexibility"> Allows reservation discount to be applied across skus within the same auto fit group. Not all skus support instance size flexibility. </param>
        /// <param name="displayName"> Friendly name for user to easily identify the reservation. </param>
        /// <param name="appliedScopes"> The list of applied scopes. </param>
        /// <param name="appliedScopeType"> The applied scope type. </param>
        /// <param name="isArchived"> Indicates if the reservation is archived. </param>
        /// <param name="capabilities"> Capabilities of the reservation. </param>
        /// <param name="quantity"> Quantity of the skus that are part of the reservation. </param>
        /// <param name="provisioningState"> Current state of the reservation. </param>
        /// <param name="effectOn"> DateTime of the reservation starting when this version is effective from. </param>
        /// <param name="benefitStartOn"> This is the DateTime when the reservation benefit started. </param>
        /// <param name="lastUpdatedOn"> DateTime of the last time the reservation was updated. </param>
        /// <param name="expireOn"> This is the date when the reservation will expire. </param>
        /// <param name="reservationExpireOn"> This is the date-time when the reservation will expire. </param>
        /// <param name="reviewOn"> This is the date-time when the Azure Hybrid Benefit needs to be reviewed. </param>
        /// <param name="skuDescription"> Description of the sku in english. </param>
        /// <param name="extendedStatusInfo"> The message giving detailed information about the status code. </param>
        /// <param name="billingPlan"> The billing plan options available for this sku. </param>
        /// <param name="displayProvisioningState"> The provisioning state of the reservation for display, e.g. Succeeded. </param>
        /// <param name="provisioningSubState"> The provisioning sub-state of the reservation, e.g. Succeeded. </param>
        /// <param name="purchaseOn"> This is the date when the reservation was purchased. </param>
        /// <param name="reservationPurchaseOn"> This is the date-time when the reservation was purchased. </param>
        /// <param name="splitProperties"> Properties of reservation split. </param>
        /// <param name="mergeProperties"> Properties of reservation merge. </param>
        /// <param name="swapProperties"> Properties of reservation swap. </param>
        /// <param name="appliedScopeProperties"> Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId if AppliedScopeType is ManagementGroup. </param>
        /// <param name="billingScopeId"> Subscription that will be charged for purchasing reservation or savings plan. </param>
        /// <param name="isRenewEnabled"> Setting this to true will automatically purchase a new reservation on the expiration date time. </param>
        /// <param name="renewSource"> Reservation Id of the reservation from which this reservation is renewed. Format of the resource Id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </param>
        /// <param name="renewDestination"> Reservation Id of the reservation which is purchased because of renew. Format of the resource Id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </param>
        /// <param name="renewProperties"> The renew properties for a reservation. </param>
        /// <param name="term"> Represent the term of reservation. </param>
        /// <param name="userFriendlyAppliedScopeType"> The applied scope type of the reservation for display, e.g. Shared. </param>
        /// <param name="userFriendlyRenewState"> The renew state of the reservation for display, e.g. On. </param>
        /// <param name="utilization"> Reservation utilization. </param>
        internal ReservationProperties(ReservedResourceType? reservedResourceType, InstanceFlexibility? instanceFlexibility, string displayName, IReadOnlyList<string> appliedScopes, AppliedScopeType? appliedScopeType, bool? isArchived, string capabilities, int? quantity, ReservationProvisioningState? provisioningState, DateTimeOffset? effectOn, DateTimeOffset? benefitStartOn, DateTimeOffset? lastUpdatedOn, DateTimeOffset? expireOn, DateTimeOffset? reservationExpireOn, DateTimeOffset? reviewOn, string skuDescription, ExtendedStatusInfo extendedStatusInfo, ReservationBillingPlan? billingPlan, string displayProvisioningState, string provisioningSubState, DateTimeOffset? purchaseOn, DateTimeOffset? reservationPurchaseOn, ReservationSplitProperties splitProperties, ReservationMergeProperties mergeProperties, ReservationSwapProperties swapProperties, AppliedScopeProperties appliedScopeProperties, ResourceIdentifier billingScopeId, bool? isRenewEnabled, string renewSource, string renewDestination, RenewProperties renewProperties, ReservationTerm? term, string userFriendlyAppliedScopeType, string userFriendlyRenewState, ReservationPropertiesUtilization utilization)
        {
            ReservedResourceType = reservedResourceType;
            InstanceFlexibility = instanceFlexibility;
            DisplayName = displayName;
            AppliedScopes = appliedScopes;
            AppliedScopeType = appliedScopeType;
            IsArchived = isArchived;
            Capabilities = capabilities;
            Quantity = quantity;
            ProvisioningState = provisioningState;
            EffectOn = effectOn;
            BenefitStartOn = benefitStartOn;
            LastUpdatedOn = lastUpdatedOn;
            ExpireOn = expireOn;
            ReservationExpireOn = reservationExpireOn;
            ReviewOn = reviewOn;
            SkuDescription = skuDescription;
            ExtendedStatusInfo = extendedStatusInfo;
            BillingPlan = billingPlan;
            DisplayProvisioningState = displayProvisioningState;
            ProvisioningSubState = provisioningSubState;
            PurchaseOn = purchaseOn;
            ReservationPurchaseOn = reservationPurchaseOn;
            SplitProperties = splitProperties;
            MergeProperties = mergeProperties;
            SwapProperties = swapProperties;
            AppliedScopeProperties = appliedScopeProperties;
            BillingScopeId = billingScopeId;
            IsRenewEnabled = isRenewEnabled;
            RenewSource = renewSource;
            RenewDestination = renewDestination;
            RenewProperties = renewProperties;
            Term = term;
            UserFriendlyAppliedScopeType = userFriendlyAppliedScopeType;
            UserFriendlyRenewState = userFriendlyRenewState;
            Utilization = utilization;
        }

        /// <summary> The type of the resource that is being reserved. </summary>
        public ReservedResourceType? ReservedResourceType { get; }
        /// <summary> Allows reservation discount to be applied across skus within the same auto fit group. Not all skus support instance size flexibility. </summary>
        public InstanceFlexibility? InstanceFlexibility { get; }
        /// <summary> Friendly name for user to easily identify the reservation. </summary>
        public string DisplayName { get; }
        /// <summary> The list of applied scopes. </summary>
        public IReadOnlyList<string> AppliedScopes { get; }
        /// <summary> The applied scope type. </summary>
        public AppliedScopeType? AppliedScopeType { get; }
        /// <summary> Indicates if the reservation is archived. </summary>
        public bool? IsArchived { get; }
        /// <summary> Capabilities of the reservation. </summary>
        public string Capabilities { get; }
        /// <summary> Quantity of the skus that are part of the reservation. </summary>
        public int? Quantity { get; }
        /// <summary> Current state of the reservation. </summary>
        public ReservationProvisioningState? ProvisioningState { get; }
        /// <summary> DateTime of the reservation starting when this version is effective from. </summary>
        public DateTimeOffset? EffectOn { get; }
        /// <summary> This is the DateTime when the reservation benefit started. </summary>
        public DateTimeOffset? BenefitStartOn { get; }
        /// <summary> DateTime of the last time the reservation was updated. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> This is the date when the reservation will expire. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> This is the date-time when the reservation will expire. </summary>
        public DateTimeOffset? ReservationExpireOn { get; }
        /// <summary> This is the date-time when the Azure Hybrid Benefit needs to be reviewed. </summary>
        public DateTimeOffset? ReviewOn { get; }
        /// <summary> Description of the sku in english. </summary>
        public string SkuDescription { get; }
        /// <summary> The message giving detailed information about the status code. </summary>
        public ExtendedStatusInfo ExtendedStatusInfo { get; }
        /// <summary> The billing plan options available for this sku. </summary>
        public ReservationBillingPlan? BillingPlan { get; }
        /// <summary> The provisioning state of the reservation for display, e.g. Succeeded. </summary>
        public string DisplayProvisioningState { get; }
        /// <summary> The provisioning sub-state of the reservation, e.g. Succeeded. </summary>
        public string ProvisioningSubState { get; }
        /// <summary> This is the date when the reservation was purchased. </summary>
        public DateTimeOffset? PurchaseOn { get; }
        /// <summary> This is the date-time when the reservation was purchased. </summary>
        public DateTimeOffset? ReservationPurchaseOn { get; }
        /// <summary> Properties of reservation split. </summary>
        public ReservationSplitProperties SplitProperties { get; }
        /// <summary> Properties of reservation merge. </summary>
        public ReservationMergeProperties MergeProperties { get; }
        /// <summary> Properties of reservation swap. </summary>
        public ReservationSwapProperties SwapProperties { get; }
        /// <summary> Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId if AppliedScopeType is ManagementGroup. </summary>
        public AppliedScopeProperties AppliedScopeProperties { get; }
        /// <summary> Subscription that will be charged for purchasing reservation or savings plan. </summary>
        public ResourceIdentifier BillingScopeId { get; }
        /// <summary> Setting this to true will automatically purchase a new reservation on the expiration date time. </summary>
        public bool? IsRenewEnabled { get; }
        /// <summary> Reservation Id of the reservation from which this reservation is renewed. Format of the resource Id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public string RenewSource { get; }
        /// <summary> Reservation Id of the reservation which is purchased because of renew. Format of the resource Id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public string RenewDestination { get; }
        /// <summary> The renew properties for a reservation. </summary>
        public RenewProperties RenewProperties { get; }
        /// <summary> Represent the term of reservation. </summary>
        public ReservationTerm? Term { get; }
        /// <summary> The applied scope type of the reservation for display, e.g. Shared. </summary>
        public string UserFriendlyAppliedScopeType { get; }
        /// <summary> The renew state of the reservation for display, e.g. On. </summary>
        public string UserFriendlyRenewState { get; }
        /// <summary> Reservation utilization. </summary>
        public ReservationPropertiesUtilization Utilization { get; }
    }
}